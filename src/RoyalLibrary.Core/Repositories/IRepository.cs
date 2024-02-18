using RoyalLibrary.Core.Domain;

namespace RoyalLibrary.Core.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : DefaultEntity
    {
        IQueryable<TEntity> GetQuery();
        Task<IEnumerable<TEntity>> QueryToListAsync(IQueryable<TEntity> query);
    }
}
