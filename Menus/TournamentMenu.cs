// ======================================================
// File: TournamentMenu.cs
// Purpose:
// Handles all user interactions related to tournaments.
// ======================================================

using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Menus
{
    public class TournamentMenu
    {
        // Service object to communicate with the database
        private readonly TournamentService tournamentService;

        // Constructor
        public TournamentMenu()
        {
            tournamentService = new TournamentService();
        }

        // Display Tournament Management Menu
        public void Show()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("======================================");
                Console.WriteLine("      TOURNAMENT MANAGEMENT");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Add Tournament");
                Console.WriteLine("2. View Tournaments");
                Console.WriteLine("3. Update Tournament");
                Console.WriteLine("4. Delete Tournament");
                Console.WriteLine("5. Back");
                Console.WriteLine("======================================");

                Console.Write("Choose Option: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTournament();
                        break;

                    case "2":
                        ViewTournaments();
                        break;

                    case "3":
                        Console.WriteLine("\nUpdate Tournament - Coming Soon...");
                        Pause();
                        break;

                    case "4":
                        Console.WriteLine("\nDelete Tournament - Coming Soon...");
                        Pause();
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("\nInvalid Option!");
                        Pause();
                        break;
                }
            }
        }

        // Collect tournament information from the user
        private void AddTournament()
        {
            Console.Clear();

            Console.WriteLine("========== ADD TOURNAMENT ==========\n");

            Console.Write("Tournament Name: ");
            string tournamentName = Console.ReadLine()!;

            Console.Write("Game Name: ");
            string gameName = Console.ReadLine()!;

            Console.Write("Start Date (yyyy-mm-dd): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine()!);

            Console.Write("End Date (yyyy-mm-dd): ");
            DateTime endDate = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Prize Pool: ");
            decimal prizePool = decimal.Parse(Console.ReadLine()!);

            Console.Write("Status (Upcoming/Running/Completed): ");
            string status = Console.ReadLine()!;

            Tournament tournament = new Tournament(
                tournamentName,
                gameName,
                startDate,
                endDate,
                prizePool,
                status
            );

            tournamentService.AddTournament(tournament);

            Console.WriteLine();
            Console.WriteLine("Tournament Saved Successfully!");

            Pause();
        }
        // ======================================================
        // Display all tournaments from the database
        // ======================================================
        private void ViewTournaments()
        {
            Console.Clear();
        
            Console.WriteLine("========== TOURNAMENT LIST ==========\n");
        
            // Get all tournaments from the database
            List<Tournament> tournaments = tournamentService.GetAllTournaments();
        
            // Check if the list is empty
            if (tournaments.Count == 0)
            {
                Console.WriteLine("No tournaments found.");
                Pause();
                return;
            }
        
            // Display table header
            Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-12} {4,-12} {5,-12} {6,-12}",
                "ID",
                "Tournament",
                "Game",
                "Start Date",
                "End Date",
                "Prize",
                "Status");
        
            Console.WriteLine(new string('-', 100));
        
            // Display each tournament
            foreach (Tournament tournament in tournaments)
            {
                Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-12:yyyy-MM-dd} {4,-12:yyyy-MM-dd} {5,-12} {6,-12}",
                    tournament.TournamentID,
                    tournament.TournamentName,
                    tournament.GameName,
                    tournament.StartDate,
                    tournament.EndDate,
                    tournament.PrizePool,
                    tournament.Status);
            }
        
    Pause();
}

        // Pause the screen
        private void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
        }
    }
}