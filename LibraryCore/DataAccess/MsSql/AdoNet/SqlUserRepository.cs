using LibraryCore.Domain.Abstract;
using LibraryCore.Domain.Entities;
using System.Data.SqlClient;

namespace LibraryCore.DataAccess.MsSql.AdoNet
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly string connectionString;
        public SqlUserRepository(string connectionString)
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
            using (SqlConnection connection = new(connectionString))
            {
                string command = "select *from Users where IsActive=true";

                connection.Open();
                using (SqlCommand cmd = new SqlCommand(command, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<User> users = new List<User>();

                    while (reader.Read())
                    {
                        User user = new();

                        user.Id = int.Parse(reader["Id"].ToString()!);
                        user.Name = reader["Name"].ToString()!;
                        user.PasswordHash = reader["PasswordHash"].ToString()!;
                        user.CreatedAt = (DateTime)reader["CreatedAt"];
                        user.UpdatedAt = (DateTime)reader["UpdatedAt"];

                        users.Add(user);
                    }

                    return users;
                }
            }
        }

        public User GetById(int id)
        {
            using (SqlConnection connection = new(connectionString))
            {
                string command = $"select *from Users where IsActive=true and Id={id}";

                connection.Open();
                using (SqlCommand cmd = new SqlCommand(command, connection))
                {
                    User user = new();
                    var member = cmd.ExecuteNonQuery();

                    user.Id = int.Parse(member["Id"].ToString()!);
                    user.Name = reader["Name"].ToString()!;
                    user.PasswordHash = reader["PasswordHash"].ToString()!;
                    user.CreatedAt = (DateTime)reader["CreatedAt"];
                    user.UpdatedAt = (DateTime)reader["UpdatedAt"];

                    return users;
                }
            }
        }
    }
}
