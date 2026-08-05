// ======================================================
// File: Team.cs
// Purpose:
// Represents a team participating in a tournament.
// ======================================================

namespace GamingTournamentSystem.Models
{
    public class Team
    {
        // ======================================================
        // Primary Key
        // ======================================================
        public int TeamID { get; set; }

        // ======================================================
        // Foreign Key
        // ======================================================
        public int TournamentID { get; set; }

        // ======================================================
        // Team Information
        // ======================================================
        public string TeamName { get; set; } = "";

        public string CaptainName { get; set; } = "";

        public string GameName { get; set; } = "";

        public int TotalPlayers { get; set; }

        public string CoachName { get; set; } = "";

        // ======================================================
        // Leaderboard Information
        // ======================================================
        public int MatchesPlayed { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public int Draws { get; set; }

        public int Points { get; set; }

        // ======================================================
        // Empty Constructor
        // ======================================================
        public Team()
        {

        }

        // ======================================================
        // Constructor for Adding a New Team
        // ======================================================
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

            MatchesPlayed = 0;
            Wins = 0;
            Losses = 0;
            Draws = 0;
            Points = 0;
        }

        // ======================================================
        // Constructor for Updating Team
        // ======================================================
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

        // ======================================================
        // Constructor for Loading Team from Database
        // ======================================================
        public Team(
            int teamID,
            int tournamentID,
            string teamName,
            string captainName,
            string gameName,
            int totalPlayers,
            string coachName,
            int matchesPlayed,
            int wins,
            int losses,
            int draws,
            int points)
        {
            TeamID = teamID;
            TournamentID = tournamentID;
            TeamName = teamName;
            CaptainName = captainName;
            GameName = gameName;
            TotalPlayers = totalPlayers;
            CoachName = coachName;

            MatchesPlayed = matchesPlayed;
            Wins = wins;
            Losses = losses;
            Draws = draws;
            Points = points;
        }
    }
}