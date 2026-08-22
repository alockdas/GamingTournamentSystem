using System;

namespace GamingTournamentSystem.Models
{
    // =========================================================
    // TEAM INFO
    // =========================================================

    public class TeamInfo
    {
        public int TeamID { get; set; }

        public string TeamName { get; set; } = "";

        public string CaptainName { get; set; } = "";

        public string GameName { get; set; } = "";

        public int TotalPlayers { get; set; }

        public string CoachName { get; set; } = "";

        public int MatchesPlayed { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public int Draws { get; set; }

        public int Points { get; set; }

        public string TournamentName { get; set; } = "";
    }


    // =========================================================
    // TOURNAMENT INFO
    // =========================================================

    public class TournamentInfo
    {
        public int TournamentID { get; set; }

        public string TournamentName { get; set; } = "";

        public string GameName { get; set; } = "";

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal PrizePool { get; set; }

        public string Status { get; set; } = "";
    }


    // =========================================================
    // MATCH INFO
    // =========================================================

    public class MatchInfo
    {
        public int MatchID { get; set; }

        public string TournamentName { get; set; } = "";

        public string Team1Name { get; set; } = "";

        public string Team2Name { get; set; } = "";

        public DateTime MatchDate { get; set; }

        public string MatchTime { get; set; } = "";

        public string Venue { get; set; } = "";

        public string WinnerName { get; set; } = "";

        public string Status { get; set; } = "";
    }


    // =========================================================
    // LEADERBOARD INFO
    // =========================================================

    public class LeaderboardInfo
    {
        public int Position { get; set; }

        public string TeamName { get; set; } = "";

        public string GameName { get; set; } = "";

        public int MatchesPlayed { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public int Draws { get; set; }

        public int Points { get; set; }
    }
}