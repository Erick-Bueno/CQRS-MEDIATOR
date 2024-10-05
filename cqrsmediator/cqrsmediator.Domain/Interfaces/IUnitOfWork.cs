using cqrsmediator.Domain.Interfaces;

public interface IUnitOfWork
{
    IBlogRepository BlogRepository{ get;}
    Task CommitAsync();
}