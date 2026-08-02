using MySql.Data.MySqlClient;
using GamingTournamentSystem.Database;
using GamingTournamentSystem.Models;

namespace GamingTournamentSystem.Services
{
    public class AuthenticationService
    {
        private readonly DatabaseManager databaseManager;

        public AuthenticationService()
        {
            databaseManager = new DatabaseManager();
        }

        public void Register(User user)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"INSERT INTO Users
                                (FullName, Username, Email, Password, Role)
                                VALUES
                                (@fullname, @username, @email, @password, @role)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fullname", user.FullName);
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@role", user.Role);

                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Registration Successful!");
        }

        public User? Login(string username, string password)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"SELECT * FROM Users
                                 WHERE Username = @username
                                 AND Password = @password";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User(
                                Convert.ToInt32(reader["UserID"]),
                                reader["FullName"].ToString()!,
                                reader["Username"].ToString()!,
                                reader["Email"].ToString()!,
                                reader["Password"].ToString()!,
                                reader["Role"].ToString()!
                            );
                        }
                    }
                }
            }

            return null;
        }
    }
}