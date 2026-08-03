// ======================================================
// File: TournamentService.cs
// Purpose:
// Handles all database operations related to tournaments.
// ======================================================

using MySql.Data.MySqlClient;
using GamingTournamentSystem.Database;
using GamingTournamentSystem.Models;

namespace GamingTournamentSystem.Services
{
    public class TournamentService
    {
        // Database manager object
        private readonly DatabaseManager databaseManager;

        // Constructor
        public TournamentService()
        {
            databaseManager = new DatabaseManager();
        }


        // ======================================================
        // Add a new tournament into the database
        // ======================================================
        public void AddTournament(Tournament tournament)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"INSERT INTO Tournaments
                                (
                                    TournamentName,
                                    GameName,
                                    StartDate,
                                    EndDate,
                                    PrizePool,
                                    Status
                                )
                                VALUES
                                (
                                    @TournamentName,
                                    @GameName,
                                    @StartDate,
                                    @EndDate,
                                    @PrizePool,
                                    @Status
                                );";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentName", tournament.TournamentName);
                    command.Parameters.AddWithValue("@GameName", tournament.GameName);
                    command.Parameters.AddWithValue("@StartDate", tournament.StartDate);
                    command.Parameters.AddWithValue("@EndDate", tournament.EndDate);
                    command.Parameters.AddWithValue("@PrizePool", tournament.PrizePool);
                    command.Parameters.AddWithValue("@Status", tournament.Status);

                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Tournament Added Successfully!");
        }


        // ======================================================
        // Retrieve all tournaments from the database
        // ======================================================
        public List<Tournament> GetAllTournaments()
        {
            // List to store all tournaments
            List<Tournament> tournaments = new List<Tournament>();

            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = "SELECT * FROM Tournaments";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Read each row from the database
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

                            // Add tournament to the list
                            tournaments.Add(tournament);
                        }
                    }
                }
            }

            return tournaments;
        }



        // ======================================================
        // Update an existing tournament
        // ======================================================
        public void UpdateTournament(Tournament tournament)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"UPDATE Tournaments
                                 SET TournamentName = @TournamentName,
                                     GameName = @GameName,
                                     StartDate = @StartDate,
                                     EndDate = @EndDate,
                                     PrizePool = @PrizePool,
                                     Status = @Status
                                 WHERE TournamentID = @TournamentID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", tournament.TournamentID);
                    command.Parameters.AddWithValue("@TournamentName", tournament.TournamentName);
                    command.Parameters.AddWithValue("@GameName", tournament.GameName);
                    command.Parameters.AddWithValue("@StartDate", tournament.StartDate);
                    command.Parameters.AddWithValue("@EndDate", tournament.EndDate);
                    command.Parameters.AddWithValue("@PrizePool", tournament.PrizePool);
                    command.Parameters.AddWithValue("@Status", tournament.Status);

                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Tournament Updated Successfully!");
        }



        // ======================================================
        // Delete a tournament from the database
        // ======================================================
        public void DeleteTournament(int tournamentID)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"DELETE FROM Tournaments
                                 WHERE TournamentID = @TournamentID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", tournamentID);

                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Tournament Deleted Successfully!");
        }
    }
}