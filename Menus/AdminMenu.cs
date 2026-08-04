// ======================================================
// File: AdminMenu.cs
// Purpose:
// Displays the Admin Dashboard and handles
// all admin navigation options.
// ======================================================

using GamingTournamentSystem.Menus;

namespace GamingTournamentSystem.Menus
{
    public class AdminMenu
    {
        // Display the Admin Dashboard
        public void Show()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("======================================");
                Console.WriteLine("         ADMIN DASHBOARD");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Tournament Management");
                Console.WriteLine("2. Team Management");
                Console.WriteLine("3. Player Management");
                Console.WriteLine("4. Match Management");
                Console.WriteLine("5. Leaderboard");
                Console.WriteLine("6. Reports");
                Console.WriteLine("7. Logout");
                Console.WriteLine("======================================");

                Console.Write("Choose Option: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        OpenTournamentMenu();
                        break;

                    case "2":
                        OpenTeamMenu();
                        break;

                    case "3":
                        OpenPlayerMenu();
                        break;

                    case "4":
                        MatchMenu();
                        break;

                    case "5":
                        LeaderboardMenu();
                        break;

                    case "6":
                        ReportsMenu();
                        break;

                    case "7":
                        return;

                    default:
                        Console.WriteLine("\nInvalid Option!");
                        Pause();
                        break;
                }
            }
        }

        // ======================================================
        // Open Tournament Management Menu
        // ======================================================
        private void OpenTournamentMenu()
        {
            TournamentMenu tournamentMenu = new TournamentMenu();
            tournamentMenu.Show();
        }

        // ======================================================
        // Open Team Management Menu
        // ======================================================
        private void OpenTeamMenu()
        {
            TeamMenu teamMenu = new TeamMenu();
            teamMenu.Show();
        }

        // ======================================================
        // Player Management Placeholder
        // ======================================================
        private void OpenPlayerMenu()
        {
            PlayerMenu playerMenu = new PlayerMenu();
            playerMenu.Show();
        }

        // ======================================================
        // Match Management Placeholder
        // ======================================================
        private void MatchMenu()
        {
            MatchMenu matchMenu = new MatchMenu();
            matchMenu.Show();
        }

        // ======================================================
        // Leaderboard Placeholder
        // ======================================================
        private void LeaderboardMenu()
        {
            Console.Clear();

            Console.WriteLine("===== Leaderboard =====");
            Console.WriteLine();
            Console.WriteLine("Coming Soon...");
            Pause();
        }

        // ======================================================
        // Reports Placeholder
        // ======================================================
        private void ReportsMenu()
        {
            Console.Clear();

            Console.WriteLine("===== Reports =====");
            Console.WriteLine();
            Console.WriteLine("Coming Soon...");
            Pause();
        }

        // ======================================================
        // Pause before returning to dashboard
        // ======================================================
        private void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
        }
    }
}