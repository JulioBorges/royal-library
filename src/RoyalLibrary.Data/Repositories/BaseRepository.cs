using Microsoft.EntityFrameworkCore;
using RoyalLibrary.Core.Domain;
using RoyalLibrary.Core.Repositories;

namespace RoyalLibrary.Data.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity>, IDisposable where TEntity : DefaultEntity
    {
        protected readonly BookContext _db;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepository(BookContext context)
        {
            _db = context;
            _dbSet = _db.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> GetQuery()
        {
            return _dbSet;
        }

        public async Task<IEnumerable<TEntity>> QueryToListAsync(IQueryable<TEntity> query)
        {
            return await query.ToListAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
