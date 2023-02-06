using Microsoft.AspNetCore.Http;
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
            var basePrices = await _context.PretProdusGestiunes.ToListAsync();
            var discountPrices = await _context.FidelizareProduses.ToListAsync();
            var products = await _context.Produses.ToListAsync();
            IQueryable<ProdusePeMasa> productsOnTable = _context.ProdusePeMasas;
            if (idTable != null)
            {
                productsOnTable = productsOnTable.Where(x => x.Idscaun == idTable);
            }
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
                }
                billItemDTO.idTable = productOnTable.Idscaun;
                billItemDTO.Quantity = productOnTable.Cantitate;
                return billItemDTO;
            }));
        }
    }
}
