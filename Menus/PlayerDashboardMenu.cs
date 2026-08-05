using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Menus
{
    public class PlayerDashboardMenu
    {
        private readonly PlayerDashboardService playerService;

        public PlayerDashboardMenu()
        {
            playerService = new PlayerDashboardService();
        }

        public void Show(int userID)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("==========================================");
                Console.WriteLine("         PLAYER DASHBOARD");
                Console.WriteLine("==========================================");
                Console.WriteLine("1. My Profile");
                Console.WriteLine("2. My Team");
                Console.WriteLine("3. My Tournament");
                Console.WriteLine("4. Match Schedule");
                Console.WriteLine("5. Leaderboard");
                Console.WriteLine("6. Logout");
                Console.WriteLine("==========================================");

                Console.Write("Choose Option: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        playerService.ViewProfile(userID);
                        Pause();
                        break;

                    case "2":
                        playerService.ViewMyTeam(userID);
                        Pause();
                        break;

                    case "3":
                        playerService.ViewMyTournament(userID);
                        Pause();
                        break;

                    case "4":
                        playerService.ViewMyMatches(userID);
                        Pause();
                        break;

                    case "5":
                        playerService.ViewLeaderboard(userID);
                        Pause();
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("\nInvalid Option!");
                        Pause();
                        break;
                }
            }
        }

        private void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
        }
    }
}