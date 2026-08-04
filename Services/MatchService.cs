using MySql.Data.MySqlClient;
using GamingTournamentSystem.Database;
using GamingTournamentSystem.Models;

namespace GamingTournamentSystem.Services
{
    public class MatchService
    {
        private readonly DatabaseManager databaseManager;

        // Constructor
        public MatchService()
        {
            databaseManager = new DatabaseManager();
        }

        // ======================================================
        // Add Match
        // ======================================================
        public void AddMatch(Match match)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"INSERT INTO Matches
                                (TournamentID, Team1ID, Team2ID, MatchDate,
                                 MatchTime, Venue, WinnerTeamID, Status)
                                VALUES
                                (@TournamentID, @Team1ID, @Team2ID, @MatchDate,
                                 @MatchTime, @Venue, @WinnerTeamID, @Status)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", match.TournamentID);
                    command.Parameters.AddWithValue("@Team1ID", match.Team1ID);
                    command.Parameters.AddWithValue("@Team2ID", match.Team2ID);
                    command.Parameters.AddWithValue("@MatchDate", match.MatchDate);
                    command.Parameters.AddWithValue("@MatchTime", match.MatchTime);
                    command.Parameters.AddWithValue("@Venue", match.Venue);

                    if (match.WinnerTeamID.HasValue)
                        command.Parameters.AddWithValue("@WinnerTeamID", match.WinnerTeamID.Value);
                    else
                        command.Parameters.AddWithValue("@WinnerTeamID", DBNull.Value);

                    command.Parameters.AddWithValue("@Status", match.Status);

                    command.ExecuteNonQuery();
                }
            }
        }

        // ======================================================
        // View All Matches
        // ======================================================
        public List<Match> GetAllMatches()
        {
            List<Match> matches = new List<Match>();

            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = "SELECT * FROM Matches";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int? winnerID = null;

                        if (reader["WinnerTeamID"] != DBNull.Value)
                            winnerID = Convert.ToInt32(reader["WinnerTeamID"]);

                        Match match = new Match(
                            Convert.ToInt32(reader["MatchID"]),
                            Convert.ToInt32(reader["TournamentID"]),
                            Convert.ToInt32(reader["Team1ID"]),
                            Convert.ToInt32(reader["Team2ID"]),
                            Convert.ToDateTime(reader["MatchDate"]),
                            (TimeSpan)reader["MatchTime"],
                            reader["Venue"].ToString()!,
                            winnerID,
                            reader["Status"].ToString()!
                        );

                        matches.Add(match);
                    }
                }
            }

            return matches;
        }

        // ======================================================
        // Check Match Exists
        // ======================================================
        public bool MatchExists(int matchID)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Matches WHERE MatchID=@MatchID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MatchID", matchID);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        // ======================================================
        // Update Match
        // ======================================================
        public bool UpdateMatch(Match match)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"UPDATE Matches
                                SET TournamentID=@TournamentID,
                                    Team1ID=@Team1ID,
                                    Team2ID=@Team2ID,
                                    MatchDate=@MatchDate,
                                    MatchTime=@MatchTime,
                                    Venue=@Venue,
                                    WinnerTeamID=@WinnerTeamID,
                                    Status=@Status
                                WHERE MatchID=@MatchID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MatchID", match.MatchID);
                    command.Parameters.AddWithValue("@TournamentID", match.TournamentID);
                    command.Parameters.AddWithValue("@Team1ID", match.Team1ID);
                    command.Parameters.AddWithValue("@Team2ID", match.Team2ID);
                    command.Parameters.AddWithValue("@MatchDate", match.MatchDate);
                    command.Parameters.AddWithValue("@MatchTime", match.MatchTime);
                    command.Parameters.AddWithValue("@Venue", match.Venue);

                    if (match.WinnerTeamID.HasValue)
                        command.Parameters.AddWithValue("@WinnerTeamID", match.WinnerTeamID.Value);
                    else
                        command.Parameters.AddWithValue("@WinnerTeamID", DBNull.Value);

                    command.Parameters.AddWithValue("@Status", match.Status);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        // ======================================================
        // Delete Match
        // ======================================================
        public bool DeleteMatch(int matchID)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = "DELETE FROM Matches WHERE MatchID=@MatchID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MatchID", matchID);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
    }
}