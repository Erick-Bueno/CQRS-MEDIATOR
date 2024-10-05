using cqrsmediator.Domain.Interfaces;

namespace cqrsmediator.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IBlogRepository BlogRepository { get; }
        Task CommitAsync();
    }

}