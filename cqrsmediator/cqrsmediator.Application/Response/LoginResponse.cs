namespace cqrsmediator.Application.Response
{
    public record LoginResponse(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string Password,
        string AccessToken,
        string RefreshToken
    );

}