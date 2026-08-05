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

        public void AddPlayer(Player player)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // ==========================
                    // Insert into Users
                    // ==========================
                    string userQuery = @"INSERT INTO Users
                                        (FullName, Username, Email, Password, Role)
                                        VALUES
                                        (@FullName, @Username, @Email, @Password, 'Player')";

                    int userID;

                    using (MySqlCommand userCommand =
                        new MySqlCommand(userQuery, connection, transaction))
                    {
                        userCommand.Parameters.AddWithValue("@FullName", player.FullName);
                        userCommand.Parameters.AddWithValue("@Username", player.Username);
                        userCommand.Parameters.AddWithValue("@Email", player.Email);
                        userCommand.Parameters.AddWithValue("@Password", player.Password);

                        userCommand.ExecuteNonQuery();

                        userID = Convert.ToInt32(userCommand.LastInsertedId);
                    }

                    // ==========================
                    // Insert into Players
                    // ==========================
                    string playerQuery = @"INSERT INTO Players
                                          (UserID, TeamID, FullName, InGameName,
                                           Email, Phone, Age, Role)
                                          VALUES
                                          (@UserID, @TeamID, @FullName, @InGameName,
                                           @Email, @Phone, @Age, @Role)";

                    using (MySqlCommand playerCommand =
                        new MySqlCommand(playerQuery, connection, transaction))
                    {
                        playerCommand.Parameters.AddWithValue("@UserID", userID);
                        playerCommand.Parameters.AddWithValue("@TeamID", player.TeamID);
                        playerCommand.Parameters.AddWithValue("@FullName", player.FullName);
                        playerCommand.Parameters.AddWithValue("@InGameName", player.InGameName);
                        playerCommand.Parameters.AddWithValue("@Email", player.Email);
                        playerCommand.Parameters.AddWithValue("@Phone", player.Phone);
                        playerCommand.Parameters.AddWithValue("@Age", player.Age);
                        playerCommand.Parameters.AddWithValue("@Role", player.Role);

                        playerCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        // ======================================================
        // Get All Players
        // ======================================================
        public List<Player> GetAllPlayers()
        {
            List<Player> players = new List<Player>();

            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT
                        p.PlayerID,
                        p.UserID,
                        p.TeamID,
                        p.FullName,
                        u.Username,
                        p.Email,
                        u.Password,
                        p.InGameName,
                        p.Phone,
                        p.Age,
                        p.Role
                    FROM Players p
                    INNER JOIN Users u
                        ON p.UserID = u.UserID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Player player = new Player(
                            Convert.ToInt32(reader["PlayerID"]),
                            Convert.ToInt32(reader["UserID"]),
                            Convert.ToInt32(reader["TeamID"]),
                            reader["FullName"].ToString()!,
                            reader["Username"].ToString()!,
                            reader["Email"].ToString()!,
                            reader["Password"].ToString()!,
                            reader["InGameName"].ToString()!,
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

                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // =========================================
                    // Update Users Table
                    // =========================================
                    string userQuery = @"
                        UPDATE Users
                        SET FullName = @FullName,
                            Username = @Username,
                            Email = @Email,
                            Password = @Password
                        WHERE UserID = @UserID";

                    using (MySqlCommand userCommand =
                        new MySqlCommand(userQuery, connection, transaction))
                    {
                        userCommand.Parameters.AddWithValue("@UserID", player.UserID);
                        userCommand.Parameters.AddWithValue("@FullName", player.FullName);
                        userCommand.Parameters.AddWithValue("@Username", player.Username);
                        userCommand.Parameters.AddWithValue("@Email", player.Email);
                        userCommand.Parameters.AddWithValue("@Password", player.Password);

                        userCommand.ExecuteNonQuery();
                    }

                    // =========================================
                    // Update Players Table
                    // =========================================
                    string playerQuery = @"
                        UPDATE Players
                        SET TeamID = @TeamID,
                            FullName = @FullName,
                            InGameName = @InGameName,
                            Email = @Email,
                            Phone = @Phone,
                            Age = @Age,
                            Role = @Role
                        WHERE PlayerID = @PlayerID";

                    using (MySqlCommand playerCommand =
                        new MySqlCommand(playerQuery, connection, transaction))
                    {
                        playerCommand.Parameters.AddWithValue("@PlayerID", player.PlayerID);
                        playerCommand.Parameters.AddWithValue("@TeamID", player.TeamID);
                        playerCommand.Parameters.AddWithValue("@FullName", player.FullName);
                        playerCommand.Parameters.AddWithValue("@InGameName", player.InGameName);
                        playerCommand.Parameters.AddWithValue("@Email", player.Email);
                        playerCommand.Parameters.AddWithValue("@Phone", player.Phone);
                        playerCommand.Parameters.AddWithValue("@Age", player.Age);
                        playerCommand.Parameters.AddWithValue("@Role", player.Role);

                        playerCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
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


        // ======================================================
        // Get UserID by PlayerID
        // ======================================================
        public int GetUserIDByPlayerID(int playerID)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();
        
                string query = @"
                    SELECT UserID
                    FROM Players
                    WHERE PlayerID = @PlayerID";
        
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlayerID", playerID);
        
                    object? result = command.ExecuteScalar();
        
                    if (result != null)
                        return Convert.ToInt32(result);
        
                    return 0;
                }
            }
        }
    }
}