using LoansApplication.API.Models;
using System.Linq.Expressions;

namespace LoansApplication.API.Data.Repositories.Shared
{
    public interface IRepositoryBase<TEntity>
        : IDisposable
        where TEntity : EntityBase
    {
        Task<TEntity> GetAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> expression);
    }
}
