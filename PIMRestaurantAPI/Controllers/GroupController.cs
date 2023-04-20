using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PIMRestaurantAPI.DTOs;

namespace PIMRestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly PossistemContext _context;
        private readonly IMapper _mapper;

        public GroupController(PossistemContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<GrupaDTO>>> GetGroups([FromQuery] int? idLocation = null)
        {
            var groups = await _context.NomenclatorGrupas.Where(group =>
                idLocation != null ? 
                    _context.Produses.Any(product => product.Grupa == group.Id && product.Locatie == idLocation) :
                    _context.Produses.Any(product => product.Grupa == group.Id)
            ).OrderBy(group => group.Denumire).ToListAsync();

            return Ok(groups.Select(group => _mapper.Map<GrupaDTO>(group)));
        }
    }
}
