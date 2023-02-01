using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PIMRestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        private readonly PossistemContext _context;

        public SalaController(PossistemContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<ListaSali>>> GetSali()
        {
            return Ok(await _context.ListaSalis.ToListAsync());
        }
    }
}
