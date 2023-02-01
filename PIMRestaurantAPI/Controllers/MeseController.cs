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
            IQueryable<MeseScaune> mese= _context.MeseScaunes;
            if (idSala.HasValue)
            {
                mese= mese.Where(x => x.Idsala == idSala.Value && x.Idcopil != null);
            }
            var result = await mese.ToListAsync();

            if (!result.Any())
            {
                return NotFound();
            }

            return Ok(result.Select(masa => _mapper.Map<MasaDTO>(masa)));
        }
    }
}
