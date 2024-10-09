using cqrsmediator.Application.Request;
using Microsoft.AspNetCore.Mvc;

namespace cqrsmediator.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {

        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {

        }
    }
}