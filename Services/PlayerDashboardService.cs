using GamingTournamentSystem.Database;
using GamingTournamentSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace GamingTournamentSystem.Services
{
    public class PlayerDashboardService
    {
        private readonly DatabaseManager databaseManager;

        public PlayerDashboardService()
        {
            databaseManager = new DatabaseManager();
        }

        // =========================================================
        // GET TOTAL TOURNAMENT COUNT
        // =========================================================

        public int GetTournamentCount()
        {
            using MySqlConnection connection =
                databaseManager.GetConnection();

            connection.Open();

            string query =
                "SELECT COUNT(*) FROM Tournaments";

            using MySqlCommand command =
                new MySqlCommand(query, connection);

            return Convert.ToInt32(command.ExecuteScalar());
        }

        // =========================================================
        // GET PLAYER MATCH COUNT
        // =========================================================

        public int GetPlayerMatchCount(int userId)
        {
            using MySqlConnection connection =
                databaseManager.GetConnection();

            connection.Open();

            string query = @"
                SELECT COUNT(*)
                FROM Matches m
                INNER JOIN Teams t1
                    ON m.Team1ID = t1.TeamID
                INNER JOIN Teams t2
                    ON m.Team2ID = t2.TeamID
                INNER JOIN Players p
                    ON p.TeamID = t1.TeamID
                    OR p.TeamID = t2.TeamID
                WHERE p.UserID = @userId";

            using MySqlCommand command =
                new MySqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@userId",
                userId);

            return Convert.ToInt32(
                command.ExecuteScalar());
        }

        // =========================================================
        // GET TEAM POINTS
        // =========================================================

        public int GetTeamPoints(int userId)
        {
            using MySqlConnection connection =
                databaseManager.GetConnection();

            connection.Open();

            string query = @"
                SELECT COALESCE(t.Points, 0)
                FROM Players p
                INNER JOIN Teams t
                    ON p.TeamID = t.TeamID
                WHERE p.UserID = @userId
                LIMIT 1";

            using MySqlCommand command =
                new MySqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@userId",
                userId);

            object? result =
                command.ExecuteScalar();

            if (result == null ||
                result == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToInt32(result);
        }

        // =========================================================
        // GET MY TEAM
        // =========================================================

        public TeamInfo? GetMyTeam(int userId)
        {
            using MySqlConnection connection =
                databaseManager.GetConnection();

            connection.Open();

            string query = @"
                SELECT
                    t.TeamID,
                    t.TeamName,
                    t.CaptainName,
                    t.GameName,
                    t.TotalPlayers,
                    t.CoachName,
                    t.MatchesPlayed,
                    t.Wins,
                    t.Losses,
                    t.Draws,
                    t.Points,
                    tr.TournamentName

                FROM Players p

                INNER JOIN Teams t
                    ON p.TeamID = t.TeamID

                INNER JOIN Tournaments tr
                    ON t.TournamentID = tr.TournamentID

                WHERE p.UserID = @userId

                LIMIT 1";

            using MySqlCommand command =
                new MySqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@userId",
                userId);

            using MySqlDataReader reader =
                command.ExecuteReader();

            if (reader.Read())
            {
                return new TeamInfo
                {
                    TeamID =
                        Convert.ToInt32(
                            reader["TeamID"]),

                    TeamName =
                        reader["TeamName"].ToString() ?? "",

                    CaptainName =
                        reader["CaptainName"].ToString() ?? "",

                    GameName =
                        reader["GameName"].ToString() ?? "",

                    TotalPlayers =
                        Convert.ToInt32(
                            reader["TotalPlayers"]),

                    CoachName =
                        reader["CoachName"] == DBNull.Value
                            ? "Not Assigned"
                            : reader["CoachName"].ToString() ?? "",

                    MatchesPlayed =
                        Convert.ToInt32(
                            reader["MatchesPlayed"]),

                    Wins =
                        Convert.ToInt32(
                            reader["Wins"]),

                    Losses =
                        Convert.ToInt32(
                            reader["Losses"]),

                    Draws =
                        Convert.ToInt32(
                            reader["Draws"]),

                    Points =
                        Convert.ToInt32(
                            reader["Points"]),

                    TournamentName =
                        reader["TournamentName"].ToString() ?? ""
                };
            }

            return null;
        }

        // =========================================================
        // GET ALL TOURNAMENTS
        // =========================================================

        public List<TournamentInfo> GetTournaments()
        {
            List<TournamentInfo> tournaments =
                new List<TournamentInfo>();

            using MySqlConnection connection =
                databaseManager.GetConnection();

            connection.Open();

            string query = @"
                SELECT
                    TournamentID,
                    TournamentName,
                    GameName,
                    StartDate,
                    EndDate,
                    PrizePool,
                    Status

                FROM Tournaments

                ORDER BY StartDate ASC";

            using MySqlCommand command =
                new MySqlCommand(query, connection);

            using MySqlDataReader reader =
                command.ExecuteReader();

            while (reader.Read())
            {
                tournaments.Add(
                    new TournamentInfo
                    {
                        TournamentID =
                            Convert.ToInt32(
                                reader["TournamentID"]),

                        TournamentName =
                            reader["TournamentName"]
                                .ToString() ?? "",

                        GameName =
                            reader["GameName"]
                                .ToString() ?? "",

                        StartDate =
                            Convert.ToDateTime(
                                reader["StartDate"]),

                        EndDate =
                            Convert.ToDateTime(
                                reader["EndDate"]),

                        PrizePool =
                            Convert.ToDecimal(
                                reader["PrizePool"]),

                        Status =
                            reader["Status"]
                                .ToString() ?? ""
                    });
            }

            return tournaments;
        }

        // =========================================================
        // GET PLAYER MATCHES
        // =========================================================

        public List<MatchInfo> GetMyMatches(int userId)
        {
            List<MatchInfo> matches =
                new List<MatchInfo>();

            using MySqlConnection connection =
                databaseManager.GetConnection();

            connection.Open();

            string query = @"
                SELECT DISTINCT
                    m.MatchID,
                    m.MatchDate,
                    m.MatchTime,
                    m.Venue,
                    m.Status,

                    tr.TournamentName,

                    t1.TeamName AS Team1Name,
                    t2.TeamName AS Team2Name,

                    CASE
                        WHEN m.WinnerTeamID IS NULL
                            THEN 'Not Decided'
                        WHEN m.WinnerTeamID = t1.TeamID
                            THEN t1.TeamName
                        WHEN m.WinnerTeamID = t2.TeamID
                            THEN t2.TeamName
                        ELSE 'Not Decided'
                    END AS WinnerName

                FROM Matches m

                INNER JOIN Tournaments tr
                    ON m.TournamentID =
                       tr.TournamentID

                INNER JOIN Teams t1
                    ON m.Team1ID =
                       t1.TeamID

                INNER JOIN Teams t2
                    ON m.Team2ID =
                       t2.TeamID

                INNER JOIN Players p
                    ON p.TeamID = t1.TeamID
                    OR p.TeamID = t2.TeamID

                WHERE p.UserID = @userId

                ORDER BY
                    m.MatchDate ASC,
                    m.MatchTime ASC";

            using MySqlCommand command =
                new MySqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@userId",
                userId);

            using MySqlDataReader reader =
                command.ExecuteReader();

            while (reader.Read())
            {
                matches.Add(
                    new MatchInfo
                    {
                        MatchID =
                            Convert.ToInt32(
                                reader["MatchID"]),

                        TournamentName =
                            reader["TournamentName"]
                                .ToString() ?? "",

                        Team1Name =
                            reader["Team1Name"]
                                .ToString() ?? "",

                        Team2Name =
                            reader["Team2Name"]
                                .ToString() ?? "",

                        MatchDate =
                            Convert.ToDateTime(
                                reader["MatchDate"]),

                        MatchTime =
                            reader["MatchTime"]
                                .ToString() ?? "",

                        Venue =
                            reader["Venue"]
                                .ToString() ?? "",

                        Status =
                            reader["Status"]
                                .ToString() ?? "",

                        WinnerName =
                            reader["WinnerName"]
                                .ToString() ?? "Not Decided"
                    });
            }

            return matches;
        }

        // =========================================================
        // GET LEADERBOARD
        // =========================================================

        public List<LeaderboardInfo> GetLeaderboard()
        {
            List<LeaderboardInfo> leaderboard =
                new List<LeaderboardInfo>();

            using MySqlConnection connection =
                databaseManager.GetConnection();

            connection.Open();

            string query = @"
                SELECT
                    TeamName,
                    GameName,
                    MatchesPlayed,
                    Wins,
                    Losses,
                    Draws,
                    Points

                FROM Teams

                ORDER BY
                    Points DESC,
                    Wins DESC,
                    Losses ASC,
                    TeamName ASC";

            using MySqlCommand command =
                new MySqlCommand(query, connection);

            using MySqlDataReader reader =
                command.ExecuteReader();

            int position = 1;

            while (reader.Read())
            {
                leaderboard.Add(
                    new LeaderboardInfo
                    {
                        Position = position,

                        TeamName =
                            reader["TeamName"]
                                .ToString() ?? "",

                        GameName =
                            reader["GameName"]
                                .ToString() ?? "",

                        MatchesPlayed =
                            Convert.ToInt32(
                                reader["MatchesPlayed"]),

                        Wins =
                            Convert.ToInt32(
                                reader["Wins"]),

                        Losses =
                            Convert.ToInt32(
                                reader["Losses"]),

                        Draws =
                            Convert.ToInt32(
                                reader["Draws"]),

                        Points =
                            Convert.ToInt32(
                                reader["Points"])
                    });

                position++;
            }

            return leaderboard;
        }

        // =========================================================
        // PROFILE
        // =========================================================

        public User? ViewProfile(int userId)
        {
            using MySqlConnection connection =
                databaseManager.GetConnection();

            connection.Open();

            string query = @"
                SELECT
                    UserID,
                    FullName,
                    Username,
                    Email,
                    Password,
                    Role

                FROM Users

                WHERE UserID = @userId

                LIMIT 1";

            using MySqlCommand command =
                new MySqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@userId",
                userId);

            using MySqlDataReader reader =
                command.ExecuteReader();

            if (reader.Read())
            {
                return new User(
                    Convert.ToInt32(
                        reader["UserID"]),

                    reader["FullName"]
                        .ToString() ?? "",

                    reader["Username"]
                        .ToString() ?? "",

                    reader["Email"]
                        .ToString() ?? "",

                    reader["Password"]
                        .ToString() ?? "",

                    reader["Role"]
                        .ToString() ?? ""
                );
            }

            return null;
        }

        // =========================================================
        // MENU COMPATIBILITY METHODS
        // =========================================================

        public void ViewMyTeam(int userId)
        {
            TeamInfo? team =
                GetMyTeam(userId);

            if (team == null)
            {
                Console.WriteLine(
                    "You are not assigned to any team.");

                return;
            }

            Console.WriteLine();
            Console.WriteLine("===== MY TEAM =====");
            Console.WriteLine(
                $"Team: {team.TeamName}");
            Console.WriteLine(
                $"Game: {team.GameName}");
            Console.WriteLine(
                $"Tournament: {team.TournamentName}");
            Console.WriteLine(
                $"Captain: {team.CaptainName}");
            Console.WriteLine(
                $"Coach: {team.CoachName}");
            Console.WriteLine(
                $"Players: {team.TotalPlayers}");
            Console.WriteLine(
                $"Matches: {team.MatchesPlayed}");
            Console.WriteLine(
                $"Wins: {team.Wins}");
            Console.WriteLine(
                $"Losses: {team.Losses}");
            Console.WriteLine(
                $"Draws: {team.Draws}");
            Console.WriteLine(
                $"Points: {team.Points}");
        }

        public void ViewMyTournament(int userId)
        {
            TeamInfo? team =
                GetMyTeam(userId);

            if (team == null)
            {
                Console.WriteLine(
                    "You are not assigned to a tournament.");

                return;
            }

            Console.WriteLine();
            Console.WriteLine("===== MY TOURNAMENT =====");
            Console.WriteLine(
                $"Tournament: {team.TournamentName}");
            Console.WriteLine(
                $"Team: {team.TeamName}");
            Console.WriteLine(
                $"Game: {team.GameName}");
        }

        public void ViewMyMatches(int userId)
        {
            List<MatchInfo> matches =
                GetMyMatches(userId);

            Console.WriteLine();
            Console.WriteLine("===== MY MATCHES =====");

            if (matches.Count == 0)
            {
                Console.WriteLine(
                    "No matches assigned.");

                return;
            }

            foreach (MatchInfo match in matches)
            {
                Console.WriteLine();
                Console.WriteLine(
                    $"Tournament: {match.TournamentName}");

                Console.WriteLine(
                    $"{match.Team1Name} VS {match.Team2Name}");

                Console.WriteLine(
                    $"Date: {match.MatchDate:dd MMM yyyy}");

                Console.WriteLine(
                    $"Time: {match.MatchTime}");

                Console.WriteLine(
                    $"Venue: {match.Venue}");

                Console.WriteLine(
                    $"Status: {match.Status}");

                Console.WriteLine(
                    $"Winner: {match.WinnerName}");
            }
        }

        public void ViewLeaderboard(int userId)
        {
            List<LeaderboardInfo> leaderboard =
                GetLeaderboard();

            Console.WriteLine();
            Console.WriteLine("===== LEADERBOARD =====");

            if (leaderboard.Count == 0)
            {
                Console.WriteLine(
                    "No leaderboard data available.");

                return;
            }

            foreach (LeaderboardInfo item in leaderboard)
            {
                Console.WriteLine(
                    $"{item.Position}. " +
                    $"{item.TeamName} | " +
                    $"Points: {item.Points} | " +
                    $"Wins: {item.Wins} | " +
                    $"Losses: {item.Losses}");
            }
        }
    }
}