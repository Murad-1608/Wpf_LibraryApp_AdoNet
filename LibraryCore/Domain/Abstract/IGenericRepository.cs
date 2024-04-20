namespace LibraryCore.Domain.Abstract
{
    public interface IGenericRepository<T>
    {
        void Add(T user);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}
