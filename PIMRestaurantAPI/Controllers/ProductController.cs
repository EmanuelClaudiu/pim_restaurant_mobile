using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PIMRestaurantAPI.DTOs;
using PIMRestaurantAPI.DTOs.Request_Models;
using System.Text.RegularExpressions;

namespace PIMRestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly PossistemContext _context;
        private readonly IMapper _mapper;

        public ProductController(PossistemContext context, IMapper mapper)
        {
            this._context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProdusDTO>>> GetProducts([FromQuery] int? idGroup = null, [FromQuery] int? idLocation = null, [FromQuery] string? searchPrompt = "")
        {
            var basePrices = await _context.PretProdusGestiunes.ToListAsync();
            var discountPrices = await _context.FidelizareProduses.ToListAsync();
            var predefinedQuantitiesList = await _context.ProdusCantitatiPredefinites.ToListAsync();
            var categoriiContabile = await _context.NomenclatorCategoriiContabiles.ToListAsync();

            IQueryable<Produse> products = _context.Produses;
            if (idGroup.HasValue)
            {
                products = products.Where(products => products.Grupa == idGroup);
            }
            if (idLocation.HasValue)
            {
                products = products.Where(products => products.Locatie == idLocation);
            }
            if (searchPrompt != "")
            {
                products = products.Where(product => product.Denumire.Trim().ToLower().Contains(searchPrompt.Trim().ToLower()));
            }

            Regex regex = new Regex(@"materii\sprime", RegexOptions.IgnoreCase);

            var result = new List<Produse>();

            foreach (var product in products)
            {
                var categorieContabila = categoriiContabile.FirstOrDefault(c => c.Id == product.CategorieContabila);
                if (categorieContabila != null && !regex.IsMatch(categorieContabila.Denumire) && product.AfisareVanzare == true)
                {
                    result.Add(product);
                }
            }

            if (!result.Any())
            {
                return NotFound("Nu au fost gasite produse cu filtrele precizate");
            }
            return Ok(result.Select(product =>
            {
                var basePrice = basePrices.FirstOrDefault(price => price.Idprodus == product.Id);
                var discountPrice = discountPrices.FirstOrDefault(price => price.Produs == product.Id);
                var predefinedQuantities = predefinedQuantitiesList.FindAll(q => q.Idprodus == product.Id);
                var productDTO = _mapper.Map<Produse, ProdusDTO>(product);
                productDTO.CantitatiPredefinite = predefinedQuantities.Select(q => _mapper.Map<ProdusCantitatiPredefinite, CantitatePredefinitaDTO>(q)).ToList();
                if (discountPrice != null)
                {
                    productDTO.Pret = discountPrice.PretNou;
                    return productDTO;
                }
                if (basePrice != null)
                {
                    productDTO.Pret = basePrice.PretVanzare;
                    return productDTO;
                }
                return productDTO;
            }));
        }

        [HttpPost("{idProduct}/AddToBill/{idTable}")]
        public async Task<ActionResult<List<BillItemDTO>>> AddProductToBill(long idProduct, long idTable, [FromBody] AddToBillBodyDTO request)
        {
            var product = await _context.Produses.FindAsync(idProduct);
            var table = await _context.MeseScaunes.FindAsync(idTable);
            var user = await _context.Utilizatoris.FindAsync(request.Iduser);
            var predefinedQuantitiesList = await _context.ProdusCantitatiPredefinites.ToListAsync();

            if (product == null || table == null || user == null)
            {
                return NotFound();
            }
           
            var newEntry = new ProdusePeMasa();
            newEntry.Idscaun = idTable;
            newEntry.Iduser = request.Iduser;
            newEntry.NumeUser = user.NumeUtilizator;
            newEntry.Locatie = GetLocationByProduct(product);
            newEntry.Idprodus = idProduct;
            newEntry.Um = GetUMByProduct(product);
            newEntry.PretUnitar = await GetPretUnitarByProductAsync(product);
            newEntry.Valoare = newEntry.PretUnitar;
            newEntry.Cantitate = 1;
            newEntry.ProdusText = product.Denumire;
            newEntry.AfiseazaMentiuni = true;
            newEntry.DataComandaProdus = DateTime.Now;
            newEntry.ComandaEfectuata = false;
            newEntry.NumeMasa = table.ToolTip;
            newEntry.NumeScaun = table.Name;
            newEntry.Idmasa = table.Idcopil;
            newEntry.Tva = GetTVAByProduct(product);
            newEntry.GrupaTva = GetTVAGroupByProduct(product);
            newEntry.HappyHour = false;
            newEntry.Idgestiune = table.Idgestiune;
            newEntry.NumarComanda = request.NumarComanda;
            newEntry.IntervalHappyHour = -1;
            newEntry.IduserProdus = request.Iduser;
            newEntry.GeneratNotaPlata = false;
            newEntry.TipReteta = await GetProdusRetetaByProduct(idProduct);
            newEntry.CantitatePredefinita = 1;
            newEntry.IdrezervareCamera = -1;
            newEntry.InventarCameraMinibar = false;

            if (request.IdProdusCantitatePredefinita != null)
            {
                var predefinedQuantity = await _context.ProdusCantitatiPredefinites.FindAsync(request.IdProdusCantitatePredefinita);
                if (predefinedQuantity == null)
                {
                    return NotFound();
                }

                newEntry.Valoare = newEntry.PretUnitar * predefinedQuantity.CantitatePredefinita;
                newEntry.Cantitate = predefinedQuantity.CantitatePredefinita;
                newEntry.CantitatePredefinita = predefinedQuantity.CantitatePredefinita;
            }

            _context.ProdusePeMasas.Add(newEntry);
            table.UtilizatorComanda = user.Id;
            await _context.SaveChangesAsync();
            

            IQueryable<ProdusePeMasa> productsOnTable = _context.ProdusePeMasas.Where(x => x.Idscaun == idTable);
            var result = await productsOnTable.ToListAsync();

            var bill = await GetBillFromProductsOnTableAsync(result);

            return Ok(bill);
        }

        private async Task<List<BillItemDTO>> GetBillFromProductsOnTableAsync(List<ProdusePeMasa> productsOnTable)
        {
            var products = await this._context.Produses.ToListAsync();
            var predefinedQuantitiesList = await _context.ProdusCantitatiPredefinites.ToListAsync();
            var basePrices = await _context.PretProdusGestiunes.ToListAsync();
            var discountPrices = await _context.FidelizareProduses.ToListAsync();

            if (products.Count == 0 || predefinedQuantitiesList.Count == 0 || basePrices.Count == 0 || discountPrices.Count == 0)
            {
                return new List<BillItemDTO>();
            }

            var bill = productsOnTable.Select(productOnTable =>
            {
                var product = products.FirstOrDefault(product => product.Id == productOnTable.Idprodus);
                var predefinedQuantities = predefinedQuantitiesList.FindAll(q => q.Idprodus == product.Id);
                var mention = _context.ProdusePeMasaMnetiunis.FirstOrDefault(p_m => p_m.Idprodus == productOnTable.Id);

                var billItemDTO = new BillItemDTO();
                if (product != null)
                {
                    var basePrice = basePrices.FirstOrDefault(price => price.Idprodus == product.Id);
                    var discountPrice = discountPrices.FirstOrDefault(price => price.Produs == product.Id);
                    var productDTO = _mapper.Map<Produse, ProdusDTO>(product);
                    productDTO.CantitatiPredefinite = predefinedQuantities.Select(q => _mapper.Map<ProdusCantitatiPredefinite, CantitatePredefinitaDTO>(q)).ToList();
                    if (basePrice != null)
                    {
                        productDTO.Pret = basePrice.PretVanzare;
                    }
                    if (discountPrice != null)
                    {
                        productDTO.Pret = discountPrice.PretNou;
                    }
                    if (mention != null)
                    {
                        billItemDTO.Mention = mention.Mentiune;
                    }
                    billItemDTO.Id = productOnTable.Id;
                    billItemDTO.Product = productDTO;
                    billItemDTO.orderSent = productOnTable.ComandaEfectuata;
                    billItemDTO.PredefinedQuantity = productOnTable.CantitatePredefinita;
                }
                billItemDTO.idTable = productOnTable.Idscaun;
                billItemDTO.Quantity = productOnTable.Cantitate;
                return billItemDTO;
            });

            return bill.ToList();
        }

        private string? GetLocationByProduct(Produse product)
        {
            var location = _context.NomenclatorLocaties.Where(location => location.Id == product.Locatie).FirstOrDefault();
            return location != null ? location.Denumire : null;
        }

        private string? GetUMByProduct(Produse product)
        {
            var um = _context.NomenclatorUms.Where(um => um.Id == product.Um).FirstOrDefault();
            return um != null ? um.Denumire : null;
        }

        private async Task<double?> GetPretUnitarByProductAsync(Produse product)
        {
            var basePrices = await _context.PretProdusGestiunes.ToListAsync();
            var discountPrices = await _context.FidelizareProduses.ToListAsync();

            var basePrice = basePrices.FirstOrDefault(price => price.Idprodus == product.Id);
            var discountPrice = discountPrices.FirstOrDefault(price => price.Produs == product.Id);

            if (discountPrice != null)
            {
                return discountPrice.PretNou;
            } else
            {
                return basePrice != null ? basePrice.PretVanzare : null;
            }
        }

        private double? GetTVAByProduct(Produse product)
        {
            var tva = _context.NomenclatorTvas.Where(t => t.Id == product.Tva).FirstOrDefault();
            return tva != null ? tva.Denumire : null;
        }

        private string? GetTVAGroupByProduct(Produse product)
        {
            var tva = _context.NomenclatorTvas.Where(t => t.Id == product.Tva).FirstOrDefault();
            return tva != null ? tva.GrupaTva : null;
        }

        private async Task<string> GetProdusRetetaByProduct(long idProduct)
        {
            var produsReteta = await _context.ProdusRetetes.Where(p => p.Idprodus == idProduct).FirstOrDefaultAsync();
            if (produsReteta != null)
            {
                if (produsReteta.Mod.Contains("Variabil"))
                {
                    return "Variabila";
                } else
                {
                    return "Fixa";
                }
            } else
            {
                return "Variabila";
            }
        }
    }
}
