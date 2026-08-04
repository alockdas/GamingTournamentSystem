using MySql.Data.MySqlClient;
using GamingTournamentSystem.Database;
using GamingTournamentSystem.Models;

namespace GamingTournamentSystem.Services
{
    public class TeamService
    {
        private readonly DatabaseManager databaseManager;

        // Constructor
        public TeamService()
        {
            databaseManager = new DatabaseManager();
        }

        // ======================================================
        // Add a new team to the database
        // ======================================================
        public void AddTeam(Team team)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"INSERT INTO Teams
                                (TournamentID, TeamName, CaptainName, GameName, TotalPlayers, CoachName)
                                VALUES
                                (@TournamentID, @TeamName, @CaptainName, @GameName, @TotalPlayers, @CoachName)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", team.TournamentID);
                    command.Parameters.AddWithValue("@TeamName", team.TeamName);
                    command.Parameters.AddWithValue("@CaptainName", team.CaptainName);
                    command.Parameters.AddWithValue("@GameName", team.GameName);
                    command.Parameters.AddWithValue("@TotalPlayers", team.TotalPlayers);
                    command.Parameters.AddWithValue("@CoachName", team.CoachName);

                    command.ExecuteNonQuery();
                }
            }
        }


        // ======================================================
        // Get all teams from the database
        // ======================================================
        public List<Team> GetAllTeams()
        {
            List<Team> teams = new List<Team>();

            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = "SELECT * FROM Teams";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Team team = new Team(
                            Convert.ToInt32(reader["TeamID"]),
                            Convert.ToInt32(reader["TournamentID"]),
                            reader["TeamName"].ToString()!,
                            reader["CaptainName"].ToString()!,
                            reader["GameName"].ToString()!,
                            Convert.ToInt32(reader["TotalPlayers"]),
                            reader["CoachName"].ToString()!
                        );

                        teams.Add(team);
                    }
                }
            }

            return teams;
        }

        // ======================================================
        // Check if a team exists
        // ======================================================
        public bool TeamExists(int teamID)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Teams WHERE TeamID = @TeamID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", teamID);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        // ======================================================
        // Update an existing team
        // ======================================================
        public bool UpdateTeam(Team team)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"UPDATE Teams
                                 SET TournamentID = @TournamentID,
                                     TeamName = @TeamName,
                                     CaptainName = @CaptainName,
                                     GameName = @GameName,
                                     TotalPlayers = @TotalPlayers,
                                     CoachName = @CoachName
                                 WHERE TeamID = @TeamID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", team.TeamID);
                    command.Parameters.AddWithValue("@TournamentID", team.TournamentID);
                    command.Parameters.AddWithValue("@TeamName", team.TeamName);
                    command.Parameters.AddWithValue("@CaptainName", team.CaptainName);
                    command.Parameters.AddWithValue("@GameName", team.GameName);
                    command.Parameters.AddWithValue("@TotalPlayers", team.TotalPlayers);
                    command.Parameters.AddWithValue("@CoachName", team.CoachName);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }


        // ======================================================
        // Delete a team
        // ======================================================
        public bool DeleteTeam(int teamID)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();
        
                string query = "DELETE FROM Teams WHERE TeamID = @TeamID";
        
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", teamID);
        
                    int rowsAffected = command.ExecuteNonQuery();
        
                    return rowsAffected > 0;
                }
            }
        }
    }
}