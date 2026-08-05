using MySql.Data.MySqlClient;
using GamingTournamentSystem.Database;
using GamingTournamentSystem.Models;

namespace GamingTournamentSystem.Services
{
    public class LeaderboardService
    {
        private readonly DatabaseManager databaseManager;

        public LeaderboardService()
        {
            databaseManager = new DatabaseManager();
        }

        // ======================================================
        // Get Leaderboard
        // ======================================================
        public List<Team> GetLeaderboard()
        {
            List<Team> teams = new List<Team>();

            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT *
                    FROM Teams
                    ORDER BY
                        Points DESC,
                        Wins DESC,
                        MatchesPlayed ASC,
                        TeamName ASC";

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
                            reader["CoachName"].ToString()!,
                            Convert.ToInt32(reader["MatchesPlayed"]),
                            Convert.ToInt32(reader["Wins"]),
                            Convert.ToInt32(reader["Losses"]),
                            Convert.ToInt32(reader["Draws"]),
                            Convert.ToInt32(reader["Points"])
                        );

                        teams.Add(team);
                    }
                }
            }

            return teams;
        }
    }
}