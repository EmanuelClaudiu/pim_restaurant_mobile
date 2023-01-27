using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace PIMRestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly PossistemContext _context;

        public ProductController(PossistemContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Produse>>> GetProducts()
        {
            return Ok(await _context.Produses.ToListAsync());
        }
    }
}
