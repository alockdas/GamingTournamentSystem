using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Menus
{
    public class LeaderboardMenu
    {
        private readonly LeaderboardService leaderboardService;

        public LeaderboardMenu()
        {
            leaderboardService = new LeaderboardService();
        }

        // ======================================================
        // Leaderboard Menu
        // ======================================================
        public void Show()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("==============================================");
                Console.WriteLine("              LEADERBOARD");
                Console.WriteLine("==============================================");
                Console.WriteLine("1. View Leaderboard");
                Console.WriteLine("2. Back");
                Console.WriteLine("==============================================");

                Console.Write("Choose Option: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewLeaderboard();
                        break;

                    case "2":
                        return;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid Option!");
                        Pause();
                        break;
                }
            }
        }

        // ======================================================
        // View Leaderboard
        // ======================================================
        private void ViewLeaderboard()
        {
            Console.Clear();

            Console.WriteLine("=============== LEADERBOARD ===============\n");

            List<Team> teams = leaderboardService.GetLeaderboard();

            if (teams.Count == 0)
            {
                Console.WriteLine("No leaderboard data found.");
                Pause();
                return;
            }

            Console.WriteLine(
                "{0,-5} {1,-20} {2,-8} {3,-6} {4,-6} {5,-6} {6,-6}",
                "Rank",
                "Team",
                "Played",
                "Win",
                "Loss",
                "Draw",
                "Pts"
            );

            Console.WriteLine(new string('-', 70));

            int rank = 1;

            foreach (Team team in teams)
            {
                Console.WriteLine(
                    "{0,-5} {1,-20} {2,-8} {3,-6} {4,-6} {5,-6} {6,-6}",
                    rank,
                    team.TeamName,
                    team.MatchesPlayed,
                    team.Wins,
                    team.Losses,
                    team.Draws,
                    team.Points
                );

                rank++;
            }

            Pause();
        }

        // ======================================================
        // Pause
        // ======================================================
        private void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
        }
    }
}