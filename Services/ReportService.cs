using GamingTournamentSystem.Database;
using GamingTournamentSystem.Models;
using MySql.Data.MySqlClient;

namespace GamingTournamentSystem.Services
{
    public class ReportService
    {
        private readonly DatabaseManager databaseManager;

        public ReportService()
        {
            databaseManager = new DatabaseManager();
        }

        // ======================================================
        // Tournament Report
        // ======================================================
        public List<Tournament> GetTournamentReport()
        {
            List<Tournament> tournaments = new List<Tournament>();

            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"SELECT *
                                 FROM Tournaments
                                 ORDER BY TournamentID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tournament tournament = new Tournament(
                            Convert.ToInt32(reader["TournamentID"]),
                            reader["TournamentName"].ToString()!,
                            reader["GameName"].ToString()!,
                            Convert.ToDateTime(reader["StartDate"]),
                            Convert.ToDateTime(reader["EndDate"]),
                            Convert.ToDecimal(reader["PrizePool"]),
                            reader["Status"].ToString()!
                        );

                        tournaments.Add(tournament);
                    }
                }
            }

            return tournaments;
        }
    }
}