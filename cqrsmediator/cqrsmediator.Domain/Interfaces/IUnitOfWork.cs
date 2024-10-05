using System.Data;

namespace cqrsmediator.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IDbTransaction BeginTransaction();
    }

}