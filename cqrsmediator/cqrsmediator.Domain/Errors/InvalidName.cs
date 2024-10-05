using cqrsmediator.Domain.Enums;
namespace cqrsmediator.Domain.Errors
{
    public record InvalidName(string Detail) : Error(ErrorType.Validation.ToString(), nameof(InvalidName));
}

