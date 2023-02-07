using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PIMRestaurantAPI.DTOs;

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
        public async Task<ActionResult<List<ProdusDTO>>> GetProducts([FromQuery] int? idGroup = null, [FromQuery] int? idLocation = null)
        {
            var basePrices = await _context.PretProdusGestiunes.ToListAsync();
            var discountPrices = await _context.FidelizareProduses.ToListAsync();

            IQueryable<Produse> products = _context.Produses;
            if (idGroup.HasValue)
            {
                products = products.Where(products => products.Grupa == idGroup);
            }
            if (idLocation.HasValue)
            {
                products = products.Where(products => products.Locatie == idLocation);
            }
            var result = await products.ToListAsync();
            if (!result.Any())
            {
                return NotFound();
            }
            return Ok(result.Select(product =>
            {
                var basePrice = basePrices.FirstOrDefault(price => price.Idprodus == product.Id);
                var discountPrice = discountPrices.FirstOrDefault(price => price.Produs == product.Id);
                var productDTO = _mapper.Map<Produse, ProdusDTO>(product);
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
        public async Task<ActionResult<List<BillItemDTO>>> AddProductToBill(long idProduct, long idTable)
        {
            var product = await _context.Produses.FindAsync(idProduct);
            var table = await _context.MeseScaunes.FindAsync(idTable);
            var productOnTable = await _context.ProdusePeMasas
                .Where(productOnTable => productOnTable.Idscaun == idTable && productOnTable.Idprodus == idProduct)
                .FirstOrDefaultAsync();
            if (productOnTable != null)
            {
                productOnTable.Cantitate = productOnTable.Cantitate + 1;
                await _context.SaveChangesAsync();
            } else
            {
                var newEntry = new ProdusePeMasa();
                newEntry.Idprodus = idProduct;
                newEntry.Idscaun = idTable;
                newEntry.Cantitate = 1;
                _context.ProdusePeMasas.Add(newEntry);
                await _context.SaveChangesAsync();
            }

            var basePrices = await _context.PretProdusGestiunes.ToListAsync();
            var discountPrices = await _context.FidelizareProduses.ToListAsync();
            var products = await _context.Produses.ToListAsync();
            IQueryable<ProdusePeMasa> productsOnTable = _context.ProdusePeMasas.Where(x => x.Idscaun == idTable);
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
