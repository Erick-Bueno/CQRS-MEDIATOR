using cqrsmediator.Application.Request;
using cqrsmediator.Application.Response;

namespace cqrsmediator.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        public Task<RegisterResponse> Register(RegisterRequest request);
        public Task<LoginResponse> Login (LoginRequest request);
    }
}