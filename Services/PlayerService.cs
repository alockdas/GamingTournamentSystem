using MySql.Data.MySqlClient;
using GamingTournamentSystem.Database;
using GamingTournamentSystem.Models;

namespace GamingTournamentSystem.Services
{
    public class PlayerService
    {
        private readonly DatabaseManager databaseManager;

        // Constructor
        public PlayerService()
        {
            databaseManager = new DatabaseManager();
        }

        // ======================================================
        // Add a new player
        // ======================================================
        public void AddPlayer(Player player)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"INSERT INTO Players
                                (TeamID, FullName, InGameName, Email, Phone, Age, Role)
                                VALUES
                                (@TeamID, @FullName, @InGameName, @Email, @Phone, @Age, @Role)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", player.TeamID);
                    command.Parameters.AddWithValue("@FullName", player.FullName);
                    command.Parameters.AddWithValue("@InGameName", player.InGameName);
                    command.Parameters.AddWithValue("@Email", player.Email);
                    command.Parameters.AddWithValue("@Phone", player.Phone);
                    command.Parameters.AddWithValue("@Age", player.Age);
                    command.Parameters.AddWithValue("@Role", player.Role);

                    command.ExecuteNonQuery();
                }
            }
        }

        // ======================================================
        // Get all players
        // ======================================================
        public List<Player> GetAllPlayers()
        {
            List<Player> players = new List<Player>();

            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = "SELECT * FROM Players";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Player player = new Player(
                            Convert.ToInt32(reader["PlayerID"]),
                            Convert.ToInt32(reader["TeamID"]),
                            reader["FullName"].ToString()!,
                            reader["InGameName"].ToString()!,
                            reader["Email"].ToString()!,
                            reader["Phone"].ToString()!,
                            Convert.ToInt32(reader["Age"]),
                            reader["Role"].ToString()!
                        );

                        players.Add(player);
                    }
                }
            }

            return players;
        }

        // ======================================================
        // Check if Player exists
        // ======================================================
        public bool PlayerExists(int playerID)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Players WHERE PlayerID = @PlayerID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlayerID", playerID);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        // ======================================================
        // Check if Email already exists
        // ======================================================
        public bool EmailExists(string email)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Players WHERE Email = @Email";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        // ======================================================
        // Update Player
        // ======================================================
        public bool UpdatePlayer(Player player)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"UPDATE Players
                                 SET TeamID = @TeamID,
                                     FullName = @FullName,
                                     InGameName = @InGameName,
                                     Email = @Email,
                                     Phone = @Phone,
                                     Age = @Age,
                                     Role = @Role
                                 WHERE PlayerID = @PlayerID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlayerID", player.PlayerID);
                    command.Parameters.AddWithValue("@TeamID", player.TeamID);
                    command.Parameters.AddWithValue("@FullName", player.FullName);
                    command.Parameters.AddWithValue("@InGameName", player.InGameName);
                    command.Parameters.AddWithValue("@Email", player.Email);
                    command.Parameters.AddWithValue("@Phone", player.Phone);
                    command.Parameters.AddWithValue("@Age", player.Age);
                    command.Parameters.AddWithValue("@Role", player.Role);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        // ======================================================
        // Delete Player
        // ======================================================
        public bool DeletePlayer(int playerID)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = "DELETE FROM Players WHERE PlayerID = @PlayerID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlayerID", playerID);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
    }
}