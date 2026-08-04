// ======================================================
// File: Team.cs
// Purpose:
// Represents a team participating in a tournament.
// ======================================================

namespace GamingTournamentSystem.Models
{
    public class Team
    {
        // Primary Key
        public int TeamID { get; set; }

        // Foreign Key (References Tournament)
        public int TournamentID { get; set; }

        // Team Information
        public string TeamName { get; set; } = "";

        public string CaptainName { get; set; } = "";

        public string GameName { get; set; } = "";

        public int TotalPlayers { get; set; }

        public string CoachName { get; set; } = "";

        // Empty Constructor
        public Team()
        {

        }

        // Constructor for Adding a New Team
        public Team(
            int tournamentID,
            string teamName,
            string captainName,
            string gameName,
            int totalPlayers,
            string coachName)
        {
            TournamentID = tournamentID;
            TeamName = teamName;
            CaptainName = captainName;
            GameName = gameName;
            TotalPlayers = totalPlayers;
            CoachName = coachName;
        }

        // Constructor for Updating an Existing Team
        public Team(
            int teamID,
            int tournamentID,
            string teamName,
            string captainName,
            string gameName,
            int totalPlayers,
            string coachName)
        {
            TeamID = teamID;
            TournamentID = tournamentID;
            TeamName = teamName;
            CaptainName = captainName;
            GameName = gameName;
            TotalPlayers = totalPlayers;
            CoachName = coachName;
        }
    }
}