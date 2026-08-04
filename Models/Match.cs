namespace GamingTournamentSystem.Models
{
    public class Match
    {
        public int MatchID { get; set; }
        public int TournamentID { get; set; }
        public int Team1ID { get; set; }
        public int Team2ID { get; set; }
        public DateTime MatchDate { get; set; }
        public TimeSpan MatchTime { get; set; }
        public string Venue { get; set; }
        public int? WinnerTeamID { get; set; }
        public string Status { get; set; }

        // Constructor for Add
        public Match(
            int tournamentID,
            int team1ID,
            int team2ID,
            DateTime matchDate,
            TimeSpan matchTime,
            string venue,
            int? winnerTeamID,
            string status)
        {
            TournamentID = tournamentID;
            Team1ID = team1ID;
            Team2ID = team2ID;
            MatchDate = matchDate;
            MatchTime = matchTime;
            Venue = venue;
            WinnerTeamID = winnerTeamID;
            Status = status;
        }

        // Constructor for Update
        public Match(
            int matchID,
            int tournamentID,
            int team1ID,
            int team2ID,
            DateTime matchDate,
            TimeSpan matchTime,
            string venue,
            int? winnerTeamID,
            string status)
        {
            MatchID = matchID;
            TournamentID = tournamentID;
            Team1ID = team1ID;
            Team2ID = team2ID;
            MatchDate = matchDate;
            MatchTime = matchTime;
            Venue = venue;
            WinnerTeamID = winnerTeamID;
            Status = status;
        }
    }
}