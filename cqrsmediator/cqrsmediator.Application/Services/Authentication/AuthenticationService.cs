using cqrsmediator.Application.Request;
using cqrsmediator.Application.Response;

namespace cqrsmediator.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public Task<LoginResponse> Login(LoginRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<RegisterResponse> Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}