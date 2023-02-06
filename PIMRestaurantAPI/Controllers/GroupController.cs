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
        public async Task<ActionResult<List<GrupaDTO>>> GetGroups()
        {
            var result = await _context.NomenclatorGrupas.ToListAsync();
            return Ok(result.Select(group => _mapper.Map<GrupaDTO>(group)));
        }
    }
}
