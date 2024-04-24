using LibraryCore.Domain.Abstract;
using LibraryCore.Domain.Entities;
using System.Data.SqlClient;

namespace LibraryCore.DataAccess.MsSql.AdoNet
{
    public class SqlGenreRepository : IGenreRepository
    {
        private readonly string connectionString;
        public SqlGenreRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int Add(Genre item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string command = $"Insert into Genres output inserted.Id values({item.ModifierId},{item.Name},{item.Note},{item.IsActive},{DateTime.Now},{DateTime.Now})";

                using (SqlCommand cmd = new SqlCommand(command, connection))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Genre> GetAll()
        {
            throw new NotImplementedException();
        }

        public Genre GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Genre item)
        {
            throw new NotImplementedException();
        }
    }
}
