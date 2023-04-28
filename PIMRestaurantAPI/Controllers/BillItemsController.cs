using Microsoft.AspNetCore.Mvc;
using PIMRestaurantAPI.DTOs;


namespace PIMRestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillItemsController : ControllerBase
    {
        private readonly PossistemContext _context;
        private readonly IMapper _mapper;

        public BillItemsController(PossistemContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<BillItemDTO>>> GetBillItems([FromQuery] int? idTable = null)
        {
            IQueryable<ProdusePeMasa> productsOnTable = _context.ProdusePeMasas;
            if (idTable != null)
            {
                productsOnTable = productsOnTable.Where(x => x.Idscaun == idTable);
            }
            var result = await productsOnTable.ToListAsync();
            var bill = await GetBillFromProductsOnTableAsync(result);
            bill.Reverse();

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

    }
}
