using CabaVS.Shared.Abstractions.Repository;
using System.Threading.Tasks;

namespace CabaVS.Shared.Abstractions.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

        Task<int> CommitAsync();
    }
}