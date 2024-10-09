using cqrsmediator.Application.Request;
using cqrsmediator.Application.Services.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace cqrsmediator.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationController(IAuthenticationService authenticationService){
            _authenticationService = authenticationService;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            return Ok(request);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            return Ok(request);
        }
    }
}