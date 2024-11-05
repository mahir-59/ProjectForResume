using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjectForResume.Controllers;
[ApiController]
[Route("api/[controller]")]
[AllowAnonymous]
public class TestController : ControllerBase
{
    [HttpGet("checkAuthorization")]
    public IActionResult CheckAuthorization()
    {
        var headers = Request.Headers;
        return Ok();
    }
}