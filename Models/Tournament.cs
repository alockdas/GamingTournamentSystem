// ======================================================
// File: Tournament.cs
// Purpose:
// Represents a tournament entity and stores
// tournament information.
// ======================================================

namespace GamingTournamentSystem.Models
{
    public class Tournament
    {
        // Unique ID of the tournament
        public int TournamentID { get; set; }

        // Name of the tournament
        public string TournamentName { get; set; } = "";

        // Game name (e.g., PUBG, Valorant, FIFA)
        public string GameName { get; set; } = "";

        // Tournament starting date
        public DateTime StartDate { get; set; }

        // Tournament ending date
        public DateTime EndDate { get; set; }

        // Total prize pool
        public decimal PrizePool { get; set; }

        // Tournament status
        public string Status { get; set; } = "";

        // Default constructor
        public Tournament()
        {

        }

        // Constructor without ID (used while creating a new tournament)
        public Tournament(
            string tournamentName,
            string gameName,
            DateTime startDate,
            DateTime endDate,
            decimal prizePool,
            string status)
        {
            TournamentName = tournamentName;
            GameName = gameName;
            StartDate = startDate;
            EndDate = endDate;
            PrizePool = prizePool;
            Status = status;
        }

        // Constructor with ID (used when retrieving data from the database)
        public Tournament(
            int tournamentID,
            string tournamentName,
            string gameName,
            DateTime startDate,
            DateTime endDate,
            decimal prizePool,
            string status)
        {
            TournamentID = tournamentID;
            TournamentName = tournamentName;
            GameName = gameName;
            StartDate = startDate;
            EndDate = endDate;
            PrizePool = prizePool;
            Status = status;
        }
    }
}