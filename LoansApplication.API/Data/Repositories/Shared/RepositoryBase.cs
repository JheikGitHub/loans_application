using LoansApplication.API.Data.Context;
using LoansApplication.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LoansApplication.API.Data.Repositories.Shared
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : EntityBase
    {

        private readonly DataContext _context;
        private readonly DbSet<TEntity> _entitySet;

        public RepositoryBase(DataContext context)
        {
            _context = context;
            _entitySet = _context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _context.AddAsync(entity);
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
            => await _entitySet.ToListAsync();

        public async Task<TEntity> GetAsync(int id)
        {
            return await _entitySet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> expression)
            => await _entitySet.Where(expression).ToListAsync();
    }
}
