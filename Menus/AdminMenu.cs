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
                        TournamentMenu();
                        break;

                    case "2":
                        TeamMenu();
                        break;

                    case "3":
                        PlayerMenu();
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

        // Tournament Management Placeholder
        // Open Tournament Management Menu
        private void TournamentMenu()
        {
            TournamentMenu tournamentMenu = new TournamentMenu();
            tournamentMenu.Show();
        }

        // Team Management Placeholder
        private void TeamMenu()
        {
            Console.Clear();

            Console.WriteLine("===== Team Management =====");
            Console.WriteLine();
            Console.WriteLine("Coming Soon...");
            Pause();
        }

        // Player Management Placeholder
        private void PlayerMenu()
        {
            Console.Clear();

            Console.WriteLine("===== Player Management =====");
            Console.WriteLine();
            Console.WriteLine("Coming Soon...");
            Pause();
        }

        // Match Management Placeholder
        private void MatchMenu()
        {
            Console.Clear();

            Console.WriteLine("===== Match Management =====");
            Console.WriteLine();
            Console.WriteLine("Coming Soon...");
            Pause();
        }

        // Leaderboard Placeholder
        private void LeaderboardMenu()
        {
            Console.Clear();

            Console.WriteLine("===== Leaderboard =====");
            Console.WriteLine();
            Console.WriteLine("Coming Soon...");
            Pause();
        }

        // Reports Placeholder
        private void ReportsMenu()
        {
            Console.Clear();

            Console.WriteLine("===== Reports =====");
            Console.WriteLine();
            Console.WriteLine("Coming Soon...");
            Pause();
        }

        // Pause before returning to dashboard
        private void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
        }
    }
}