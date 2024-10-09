namespace cqrsmediator.Application.Request
{
    public record LoginRequest(
        string Email,
        string Password
    );
}