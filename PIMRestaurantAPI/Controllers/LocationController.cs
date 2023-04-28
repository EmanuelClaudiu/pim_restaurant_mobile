using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PIMRestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly PossistemContext context;

        public LocationController(PossistemContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<NomenclatorLocatie>>> GetLocations()
        {
            var locations = await context.NomenclatorLocaties.Where(location =>
                context.Produses.Any(product => product.Locatie == location.Id)
            ).ToListAsync();
            return Ok(locations);
        }
    }
}
