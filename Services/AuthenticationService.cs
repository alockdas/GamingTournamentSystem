using Microsoft.Data.Sqlite;
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
            var command = new SqliteCommand(
                "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)");

            command.Parameters.AddWithValue("@username", user.Username);
            command.Parameters.AddWithValue("@password", user.Password);
            command.Parameters.AddWithValue("@role", user.Role);

            databaseManager.ExecuteCommand(command);

            Console.WriteLine("Registration Successful!");
        }

        public User? Login(string username, string password)
        {
            string query = @"SELECT * FROM Users
                             WHERE Username = @username
                             AND Password = @password";

            using var connection = databaseManager.GetConnection();
            connection.Open();

            using var command = new SqliteCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new User(
                    Convert.ToInt32(reader["Id"]),
                    reader["Username"].ToString()!,
                    reader["Password"].ToString()!,
                    reader["Role"].ToString()!
                );
            }

            return null;
            }
        }
}