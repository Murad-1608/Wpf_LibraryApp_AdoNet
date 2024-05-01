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
        public int Add(Book item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Book item)
        {
            throw new NotImplementedException();
        }
    }
}
