using RoyalLibrary.Core.Domain;

namespace RoyalLibrary.Core.Ropositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : DefaultEntity
    {
        void Add(TEntity obj);
        TEntity? GetById(int id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(int id);
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
