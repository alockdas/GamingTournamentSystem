using Microsoft.Data.Sqlite;

namespace GamingTournamentSystem.Database
{
    public class DatabaseManager
    {
        private readonly string connectionString = "Data Source=Data/tournament.db";

        public DatabaseManager()
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using var connection = new SqliteConnection(connectionString);

            connection.Open();

            string query = @"
            CREATE TABLE IF NOT EXISTS Users
            (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Username TEXT NOT NULL,
                Password TEXT NOT NULL,
                Role TEXT NOT NULL
            );";

            using var command = new SqliteCommand(query, connection);

            command.ExecuteNonQuery();

            Console.WriteLine("Users table created successfully.");
        }
        public void ExecuteNonQuery(string query)
        {
            using var connection = new SqliteConnection(connectionString);

            connection.Open();

            using var command = new SqliteCommand(query, connection);

            command.ExecuteNonQuery();
        }

        public void ExecuteCommand(SqliteCommand command)
        {
            using var connection = new SqliteConnection(connectionString);

            connection.Open();

            command.Connection = connection;

            command.ExecuteNonQuery();
        }
        public SqliteConnection GetConnection()
{       
            return new SqliteConnection(connectionString);
        }
    }
}