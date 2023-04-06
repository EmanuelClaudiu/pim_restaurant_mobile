using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PIMRestaurantAPI.DTOs;
using System.Security.Cryptography;
using System.Text;

namespace PIMRestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private PossistemContext _context;
        private IMapper _mapper;

        public UserController(PossistemContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public class LoginBody
        {
            public string code { get; set; }
        }

        [HttpPost("/Login")]
        public async Task<ActionResult<UserDTO>> LoginUser([FromBody] LoginBody input)
        {
            var user = await _context.Utilizatoris.Where(user => user.ParolaUtilizator == EncryptRijndael(input.code)).FirstOrDefaultAsync();
            if (user == null)
            {
                return BadRequest();
            }
            UserDTO userDto = _mapper.Map<UserDTO>(user);
            userDto.PermisStornare = user.StornareProduseNotaPlata;
            return Ok(userDto);
        }

        private string? EncryptRijndael(string code)
        {
            var aesAlg = NewRijndaelManaged();
            var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            var msEncrypt = new MemoryStream();
            using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
            using (var swEncrypt = new StreamWriter(csEncrypt))
            {
                swEncrypt.Write(code);
            }
            return Convert.ToBase64String(msEncrypt.ToArray());
        }

        private RijndaelManaged NewRijndaelManaged()
        {
            var Inputkey = "256A18CD-6348-4CF0-DDE8-DDTVF9B6B9PIMPOS";
            var saltBytes = Encoding.ASCII.GetBytes(Inputkey);
            var key = new Rfc2898DeriveBytes(Inputkey, saltBytes);
            var aesAlg = new RijndaelManaged();
            aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
            aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);

            return aesAlg;
        }
    }
}
