using LibraryCore.Domain.Entities;

namespace LibraryCore.Domain.Abstract
{
    public interface IGenericRepository<T> where T : IEntity
    {
        int Add(T item);
        void Update(T item);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}
