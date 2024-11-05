using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectForResume.JwtToken;

namespace ProjectForResume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly JwtTokenService _tokenService;
        public LoginController(JwtTokenService tokenService)
        {
            _tokenService = tokenService;
        }
        [HttpGet]
        [Route("GetToken")]
        public IActionResult ValidateLogin([FromQuery] string username)
        {
            try
            {
                var token = _tokenService.GenerateToken(username, 2);
                return Ok(new { Token = token });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpGet]
        [Route("GetValues")]
        public IActionResult GetValues()
        {
            return Ok(new string[] { "value1", "value2" });
        }
    }
}
