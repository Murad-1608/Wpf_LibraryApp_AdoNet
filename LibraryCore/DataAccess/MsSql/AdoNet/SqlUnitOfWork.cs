using LibraryCore.Domain.Abstract;
using System.Data.SqlClient;

namespace LibraryCore.DataAccess.MsSql.AdoNet
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        private readonly string connectionString;
        public SqlUnitOfWork()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(localdb)\mssqllocaldb";
            builder.InitialCatalog = "LibraryDb";

            connectionString = builder.ConnectionString;
        }

        public IUserRepository UserRepository => new SqlUserRepository(connectionString);
        public IBookRepository BookRepository => new SqlBookRepository(connectionString);
        public IGenreRepository GenreRepository => new SqlGenreRepository(connectionString);
    }
}
