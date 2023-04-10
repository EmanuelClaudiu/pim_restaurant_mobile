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
        public async Task<ActionResult<List<ListaSali>>> GetSali([FromQuery] int? idUser = null)
        {
            IQueryable<ListaSali> rooms = _context.ListaSalis;
            if (idUser.HasValue)
            {
                rooms = rooms.Where(room => _context.UtilizatoriMeses.Any(x => x.Idsala == room.Id && x.Idutilizator == idUser));
            }
            var result = await rooms.ToListAsync();
            return Ok(result);
        }
    }
}
