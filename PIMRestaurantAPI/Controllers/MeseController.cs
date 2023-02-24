using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PIMRestaurantAPI.DTOs;

namespace PIMRestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeseController : ControllerBase
    {
        private readonly PossistemContext _context;
        private readonly IMapper _mapper;

        public MeseController(PossistemContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<MasaDTO>>> GetMese([FromQuery] int? idSala = null)
        {
            var productsOnTable = await _context.ProdusePeMasas.ToListAsync();
            IQueryable<MeseScaune> mese = _context.MeseScaunes;
            if (idSala.HasValue)
            {
                mese = mese.Where(x => x.Idsala == idSala.Value && x.Idcopil != null);
            }
            var result = await mese.ToListAsync();

            if (!result.Any())
            {
                return NotFound();
            }

            return Ok(result.Select(masa => {
                var masaDTO = _mapper.Map<MasaDTO>(masa);
                var product = productsOnTable.FirstOrDefault(x => x.Idscaun == masa.Id);
                if (product != null)
                {
                    masaDTO.Occupied = true;
                } else
                {
                    masaDTO.Occupied = false;
                }
                return masaDTO;
            }));
        }

        [HttpPut("{id}/Bill")]
        public async Task<ActionResult<List<BillItemDTO>>> UpdateTableBill(int id, [FromBody] List<BillItemDTO> bill)
        {
            foreach(var billItem in bill)
            {
                var productOnTable = await _context.ProdusePeMasas.FirstOrDefaultAsync(tableProduct => tableProduct.Idscaun == id && tableProduct.Idprodus == billItem.Product.Id);
                if (productOnTable!= null)
                {
                    if (billItem.Quantity == 0)
                    {
                        _context.ProdusePeMasas.Remove(productOnTable);
                        await _context.SaveChangesAsync();
                    } else
                    {
                        productOnTable.Cantitate = billItem.Quantity;
                        await _context.SaveChangesAsync();
                    }
                } else
                {
                    return NotFound($"Bill Item with id {billItem.Id} not found.");
                }
            }

            var basePrices = await _context.PretProdusGestiunes.ToListAsync();
            var discountPrices = await _context.FidelizareProduses.ToListAsync();
            var products = await _context.Produses.ToListAsync();
            IQueryable<ProdusePeMasa> productsOnTable = _context.ProdusePeMasas.Where(x => x.Idscaun == id);
            var result = await productsOnTable.ToListAsync();

            return Ok(result.Select(productOnTable => {
                var product = products.FirstOrDefault(product => product.Id == productOnTable.Idprodus);
                var billItemDTO = new BillItemDTO();
                if (product != null)
                {
                    var basePrice = basePrices.FirstOrDefault(price => price.Idprodus == product.Id);
                    var discountPrice = discountPrices.FirstOrDefault(price => price.Produs == product.Id);
                    var productDTO = _mapper.Map<Produse, ProdusDTO>(product);
                    if (basePrice != null)
                    {
                        productDTO.Pret = basePrice.PretVanzare;
                    }
                    if (discountPrice != null)
                    {
                        productDTO.Pret = discountPrice.PretNou;
                    }
                    billItemDTO.Id = product.Id;
                    billItemDTO.Product = productDTO;
                    billItemDTO.orderSent = productOnTable.ComandaEfectuata;
                }
                billItemDTO.idTable = productOnTable.Idscaun;
                billItemDTO.Quantity = productOnTable.Cantitate;
                return billItemDTO;
            }));
        }

    }
}
