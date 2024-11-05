using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectForResume.JwtToken;

namespace ProjectForResume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
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
                return Ok(token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetValues")]
        [Authorize]
        public IActionResult GetValues()
        {
            return Ok(new string[] { "value1", "value2" });
        }
    }
}