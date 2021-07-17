using WIREDBRAINCOFFIE_STORAGE.Entities;

namespace WIREDBRAINCOFFIE_STORAGE.Repositories
{
    public interface ISQLRepository<T> where T : class, IEntityBase
    {
        void Add(T item);
        T GetByID(int id);
        void Remove(T item);
        void Save();
    }
}