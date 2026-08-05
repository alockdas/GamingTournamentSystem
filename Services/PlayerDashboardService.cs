using MySql.Data.MySqlClient;
using GamingTournamentSystem.Database;

namespace GamingTournamentSystem.Services
{
    public class PlayerDashboardService
    {
        private readonly DatabaseManager databaseManager;

        public PlayerDashboardService()
        {
            databaseManager = new DatabaseManager();
        }

        // ======================================================
        // View My Profile
        // ======================================================
        public void ViewProfile(int userID)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"
                SELECT
                    p.PlayerID,
                    p.FullName,
                    p.InGameName,
                    p.Email,
                    p.Phone,
                    p.Age,
                    p.Role,
                    t.TeamName,
                    tr.TournamentName
                FROM Players p
                INNER JOIN Teams t
                    ON p.TeamID = t.TeamID
                INNER JOIN Tournaments tr
                    ON t.TournamentID = tr.TournamentID
                WHERE p.UserID = @UserID";

                using (MySqlCommand command =
                    new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (MySqlDataReader reader =
                        command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.Clear();

                            Console.WriteLine("======================================");
                            Console.WriteLine("          MY PROFILE");
                            Console.WriteLine("======================================");

                            Console.WriteLine($"Player ID      : {reader["PlayerID"]}");
                            Console.WriteLine($"Full Name      : {reader["FullName"]}");
                            Console.WriteLine($"In Game Name   : {reader["InGameName"]}");
                            Console.WriteLine($"Email          : {reader["Email"]}");
                            Console.WriteLine($"Phone          : {reader["Phone"]}");
                            Console.WriteLine($"Age            : {reader["Age"]}");
                            Console.WriteLine($"Role           : {reader["Role"]}");
                            Console.WriteLine($"Team           : {reader["TeamName"]}");
                            Console.WriteLine($"Tournament     : {reader["TournamentName"]}");

                            Console.WriteLine("======================================");
                        }
                        else
                        {
                            Console.WriteLine("Player profile not found.");
                        }
                    }
                }
            }
        }


        // ======================================================
        // View My Team
        // ======================================================
        public void ViewMyTeam(int userID)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"
                SELECT
                    t.TeamName,
                    t.CaptainName,
                    t.CoachName,
                    t.GameName,
                    t.TotalPlayers,
                    tr.TournamentName
                FROM Players p
                INNER JOIN Teams t
                    ON p.TeamID = t.TeamID
                INNER JOIN Tournaments tr
                    ON t.TournamentID = tr.TournamentID
                WHERE p.UserID=@UserID";

                using (MySqlCommand command =
                    new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.Clear();

                            Console.WriteLine("======================================");
                            Console.WriteLine("            MY TEAM");
                            Console.WriteLine("======================================");

                            Console.WriteLine($"Team Name      : {reader["TeamName"]}");
                            Console.WriteLine($"Tournament     : {reader["TournamentName"]}");
                            Console.WriteLine($"Game           : {reader["GameName"]}");
                            Console.WriteLine($"Captain        : {reader["CaptainName"]}");
                            Console.WriteLine($"Coach          : {reader["CoachName"]}");
                            Console.WriteLine($"Total Players  : {reader["TotalPlayers"]}");
                            Console.WriteLine();
                            Console.WriteLine("----------- TEAM MEMBERS -----------");

                            Console.WriteLine("======================================");
                        }
                        else
                        {
                            Console.WriteLine("Team not found.");
                        }
                        reader.Close();
                        string memberQuery = @"
                        SELECT
                            FullName,
                            InGameName,
                            Role
                        FROM Players
                        WHERE TeamID = (
                            SELECT TeamID
                            FROM Players
                            WHERE UserID=@UserID
                        )
                        ORDER BY
                        CASE
                            WHEN Role='Captain' THEN 1
                            WHEN Role='Player' THEN 2
                            ELSE 3
                        END,
                        FullName";

                        using (MySqlCommand memberCommand =
                            new MySqlCommand(memberQuery, connection))
                        {
                            memberCommand.Parameters.AddWithValue("@UserID", userID);

                            using (MySqlDataReader memberReader =
                                memberCommand.ExecuteReader())
                            {
                                int i = 1;

                                while (memberReader.Read())
                                {
                                    Console.WriteLine(
                                        $"{i}. {memberReader["FullName"]} ({memberReader["InGameName"]}) - {memberReader["Role"]}"
                                    );

                                    i++;
                                }
                            }
                        }

                    Console.WriteLine("======================================");
                    }
                }
            }
        }


        // ======================================================
        // View My Tournament
        // ======================================================
        public void ViewMyTournament(int userID)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"
                SELECT
                    tr.TournamentName,
                    tr.GameName,
                    tr.StartDate,
                    tr.EndDate,
                    tr.PrizePool,
                    tr.Status
                FROM Players p
                INNER JOIN Teams t
                    ON p.TeamID = t.TeamID
                INNER JOIN Tournaments tr
                    ON t.TournamentID = tr.TournamentID
                WHERE p.UserID = @UserID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.Clear();

                            Console.WriteLine("======================================");
                            Console.WriteLine("         MY TOURNAMENT");
                            Console.WriteLine("======================================");

                            Console.WriteLine($"Tournament : {reader["TournamentName"]}");
                            Console.WriteLine($"Game       : {reader["GameName"]}");
                            Console.WriteLine($"Start Date : {Convert.ToDateTime(reader["StartDate"]).ToShortDateString()}");
                            Console.WriteLine($"End Date   : {Convert.ToDateTime(reader["EndDate"]).ToShortDateString()}");
                            Console.WriteLine($"Prize Pool : {reader["PrizePool"]}");
                            Console.WriteLine($"Status     : {reader["Status"]}");

                            Console.WriteLine("======================================");
                        }
                        else
                        {
                            Console.WriteLine("Tournament not found.");
                        }
                    }
                }
            }
        }


        // ======================================================
        // View My Match Schedule
        // ======================================================
        public void ViewMyMatches(int userID)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();

                string query = @"
                SELECT
                    m.MatchID,
                    t1.TeamName AS Team1,
                    t2.TeamName AS Team2,
                    m.MatchDate,
                    m.MatchTime,
                    m.Venue,
                    m.Status
                FROM Players p
                INNER JOIN Teams myTeam
                    ON p.TeamID = myTeam.TeamID
                INNER JOIN Matches m
                    ON (m.Team1ID = myTeam.TeamID OR m.Team2ID = myTeam.TeamID)
                INNER JOIN Teams t1
                    ON m.Team1ID = t1.TeamID
                INNER JOIN Teams t2
                    ON m.Team2ID = t2.TeamID
                WHERE p.UserID = @UserID
                ORDER BY m.MatchDate, m.MatchTime;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        Console.Clear();

                        Console.WriteLine("===============================================================");
                        Console.WriteLine("                    MY MATCH SCHEDULE");
                        Console.WriteLine("===============================================================");

                        if (!reader.HasRows)
                        {
                            Console.WriteLine("No matches found.");
                            return;
                        }

                        Console.WriteLine(
                            "{0,-5} {1,-18} {2,-18} {3,-12} {4,-8} {5,-15}",
                            "ID",
                            "Team 1",
                            "Team 2",
                            "Date",
                            "Time",
                            "Status"
                        );

                        Console.WriteLine(new string('-', 85));

                        while (reader.Read())
                        {
                            Console.WriteLine(
                                "{0,-5} {1,-18} {2,-18} {3,-12} {4,-8} {5,-15}",
                                reader["MatchID"],
                                reader["Team1"],
                                reader["Team2"],
                                Convert.ToDateTime(reader["MatchDate"]).ToString("dd-MM-yyyy"),
                                reader["MatchTime"].ToString(),
                                reader["Status"]
                            );
                        }

                        Console.WriteLine("===============================================================");
                    }
                }
            }
        }

        // ======================================================
        // View Tournament Leaderboard
        // ======================================================
        public void ViewLeaderboard(int userID)
        {
            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                connection.Open();
        
                string query = @"
                SELECT
                    t.TeamName,
                    t.MatchesPlayed,
                    t.Wins,
                    t.Draws,
                    t.Losses,
                    t.Points
                FROM Players p
                INNER JOIN Teams myTeam
                    ON p.TeamID = myTeam.TeamID
                INNER JOIN Teams t
                    ON t.TournamentID = myTeam.TournamentID
                WHERE p.UserID = @UserID
                ORDER BY
                    t.Points DESC,
                    t.Wins DESC,
                    t.TeamName ASC;";
        
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
        
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        Console.Clear();
        
                        Console.WriteLine("==========================================================================");
                        Console.WriteLine("                         TOURNAMENT LEADERBOARD");
                        Console.WriteLine("==========================================================================");
        
                        if (!reader.HasRows)
                        {
                            Console.WriteLine("Leaderboard not available.");
                            return;
                        }
        
                        Console.WriteLine(
                            "{0,-5} {1,-22} {2,-5} {3,-5} {4,-5} {5,-5} {6,-6}",
                            "Rank",
                            "Team",
                            "MP",
                            "W",
                            "D",
                            "L",
                            "Pts"
                        );
        
                        Console.WriteLine(new string('-', 70));
        
                        int rank = 1;
        
                        while (reader.Read())
                        {
                            Console.WriteLine(
                                "{0,-5} {1,-22} {2,-5} {3,-5} {4,-5} {5,-5} {6,-6}",
                                rank++,
                                reader["TeamName"],
                                reader["MatchesPlayed"],
                                reader["Wins"],
                                reader["Draws"],
                                reader["Losses"],
                                reader["Points"]
                            );
                        }
        
                        Console.WriteLine("==========================================================================");
                    }
                }
            }
        }
    }
}