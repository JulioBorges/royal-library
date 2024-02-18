using RoyalLibrary.Core.Domain;

namespace RoyalLibrary.Core.Services
{
    public interface IService<TEntity> : IDisposable where TEntity : DefaultEntity
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(int id);
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
