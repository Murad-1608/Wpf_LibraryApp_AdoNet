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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string command = $"update genres set isActive=0 where id={id}";

                using (SqlCommand cmd = new SqlCommand(command, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Genre> GetAll()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                string command = $"select *from Genres where isActive=1";

                using (SqlCommand cmd = new SqlCommand(command, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Genre> genres = new();

                        while (reader.Read())
                        {
                            Genre genre = new Genre()
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                Name = reader["name"].ToString(),
                                Note = reader["note"].ToString(),
                                ModifierId = Convert.ToInt32(reader["modifierid"].ToString()),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"].ToString()),
                                UpdatedAt = Convert.ToDateTime(reader["CreatedAt"].ToString()),
                            };
                            genres.Add(genre);
                        }
                        return genres;
                    }                   
                    
                }
            }
        }
        47:37

        public Genre GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                string command = $"select *from Genres where isActive=1 and id={id}";

                using (SqlCommand cmd = new SqlCommand(command, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                        return null;

                    return new Genre
                    {
                        Id = Convert.ToInt32(reader["Id"].ToString()),
                        Name = reader["name"].ToString(),
                        Note = reader["note"].ToString(),
                        ModifierId = Convert.ToInt32(reader["modifierid"].ToString()),
                        CreatedAt = Convert.ToDateTime(reader["CreatedAt"].ToString()),
                        UpdatedAt = Convert.ToDateTime(reader["CreatedAt"].ToString()),
                    };
                }
            }
        }
        public void Update(Genre item)
        {
            throw new NotImplementedException();
        }
    }
}