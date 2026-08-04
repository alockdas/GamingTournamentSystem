// ======================================================
// File: TournamentMenu.cs
// Purpose:
// Handles all user interactions related to tournaments.
// ======================================================

using GamingTournamentSystem.Helpers;
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
                        UpdateTournament();
                        break;

                    case "4":
                        DeleteTournament();
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
            // Read validated input from the user
            string tournamentName = InputHelper.ReadString("Tournament Name: ");

            string gameName = InputHelper.ReadString("Game Name: ");

            DateTime startDate = InputHelper.ReadDate("Start Date (yyyy-mm-dd): ");

            DateTime endDate = InputHelper.ReadDate("End Date (yyyy-mm-dd): ");

            decimal prizePool = InputHelper.ReadDecimal("Prize Pool: ");

            string status = InputHelper.ReadStatus();

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
                Console.WriteLine(
                    "{0,-5} {1,-25} {2,-15} {3,-12:yyyy-MM-dd} {4,-12:yyyy-MM-dd} {5,-12} {6,-12}",
                    tournament.TournamentID,
                    tournament.TournamentName,
                    tournament.GameName,
                    tournament.StartDate,
                    tournament.EndDate,
                    tournament.PrizePool,
                    tournament.Status
                );
            }

            Pause();
            }  



        // ======================================================
        // Update an existing tournament
        // ======================================================
        private void UpdateTournament()
        {
            Console.Clear();

            Console.WriteLine("========== UPDATE TOURNAMENT ==========\n");

            // Read Tournament ID
            int tournamentID = InputHelper.ReadInt("Enter Tournament ID: ");

            // Check if the tournament exists
            if (!tournamentService.TournamentExists(tournamentID))
            {
                Console.WriteLine();
                Console.WriteLine("Tournament ID not found!");
                Pause();
                return;
            }

            // Read updated information
            string tournamentName = InputHelper.ReadString("New Tournament Name: ");

            string gameName = InputHelper.ReadString("New Game Name: ");

            DateTime startDate = InputHelper.ReadDate("New Start Date (yyyy-MM-dd): ");

            DateTime endDate = InputHelper.ReadDate("New End Date (yyyy-MM-dd): ");

            decimal prizePool = InputHelper.ReadDecimal("New Prize Pool: ");

            string status = InputHelper.ReadStatus();

            // Create updated tournament object
            Tournament tournament = new Tournament(
                tournamentID,
                tournamentName,
                gameName,
                startDate,
                endDate,
                prizePool,
                status
            );

            // Update tournament
            bool updated = tournamentService.UpdateTournament(tournament);

            Console.WriteLine();

            if (updated)
            {
                Console.WriteLine("Tournament Updated Successfully!");
            }
            else
            {
                Console.WriteLine("Update Failed!");
            }

            Pause();
        }


        // ======================================================
        // Delete a tournament
        // ======================================================
        private void DeleteTournament()
        {
            Console.Clear();
        
            Console.WriteLine("========== DELETE TOURNAMENT ==========\n");
        
            // Ask the user which tournament to delete
            int tournamentID = InputHelper.ReadInt("Enter Tournament ID: ");
            if (!tournamentService.TournamentExists(tournamentID))
            {
                Console.WriteLine();
                Console.WriteLine("Tournament ID not found!");
                Pause();
                return;
            }
        
            Console.Write("\nAre you sure you want to delete this tournament? (Y/N): ");
            string? choice = Console.ReadLine();
        
            // Confirm before deleting
            if (choice != null && choice.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                bool deleted = tournamentService.DeleteTournament(tournamentID);

                Console.WriteLine();

                if (deleted)
                {
                    Console.WriteLine("Tournament Deleted Successfully!");
                }
                else
                {
                    Console.WriteLine("Tournament ID not found.");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Delete Operation Cancelled.");
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