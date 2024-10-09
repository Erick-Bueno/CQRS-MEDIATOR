namespace cqrsmediator.Application.Response
{
    public record RegisterResponse(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string Password
    );
}