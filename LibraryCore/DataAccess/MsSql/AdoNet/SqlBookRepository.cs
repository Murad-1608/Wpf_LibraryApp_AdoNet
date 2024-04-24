using LibraryCore.Domain.Abstract;
using LibraryCore.Domain.Entities;

namespace LibraryCore.DataAccess.MsSql.AdoNet
{
    public class SqlBookRepository : IBookRepository
    {
        private readonly string connectionString;
        public SqlBookRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
