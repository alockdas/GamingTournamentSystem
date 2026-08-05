using GamingTournamentSystem.Helpers;
using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Menus
{
    public class PlayerMenu
    {
        private readonly PlayerService playerService;
        private readonly TeamService teamService;

        public PlayerMenu()
        {
            playerService = new PlayerService();
            teamService = new TeamService();
        }

        public void Show()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("======================================");
                Console.WriteLine("       PLAYER MANAGEMENT");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Add Player");
                Console.WriteLine("2. View Players");
                Console.WriteLine("3. Update Player");
                Console.WriteLine("4. Delete Player");
                Console.WriteLine("5. Back");
                Console.WriteLine("======================================");

                Console.Write("Choose Option: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddPlayer();
                        break;

                    case "2":
                        ViewPlayers();
                        break;

                    case "3":
                        UpdatePlayer();
                        break;

                    case "4":
                        DeletePlayer();
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

         // ======================================================
        // Add Player
        // ======================================================
        private void AddPlayer()
        {
            Console.Clear();

            Console.WriteLine("========== ADD PLAYER ==========\n");

            // Show Available Teams
            List<Team> teams = teamService.GetAllTeams();

            if (teams.Count == 0)
            {
                Console.WriteLine("No teams available.");
                Pause();
                return;
            }

            Console.WriteLine("{0,-5} {1,-25}", "ID", "Team Name");
            Console.WriteLine(new string('-', 35));

            foreach (Team t in teams)
            {
                Console.WriteLine("{0,-5} {1,-25}",
                    t.TeamID,
                    t.TeamName);
            }

            Console.WriteLine();

            int teamID = InputHelper.ReadInt("Team ID: ");

            if (!teamService.TeamExists(teamID))
            {
                Console.WriteLine();
                Console.WriteLine("Team ID not found.");
                Pause();
                return;
            }

            string fullName = InputHelper.ReadString("Full Name: ");

            string username = InputHelper.ReadString("Username: ");

            string email = InputHelper.ReadEmail("Email: ");

            if (playerService.EmailExists(email))
            {
                Console.WriteLine();
                Console.WriteLine("Email already exists.");
                Pause();
                return;
            }

            string password = InputHelper.ReadString("Password: ");

            string inGameName = InputHelper.ReadString("In Game Name: ");

            string phone = InputHelper.ReadString("Phone: ");

            int age = InputHelper.ReadInt("Age: ");

            string role = InputHelper.ReadString("Role (Captain/Player/Substitute): ");

            Player player = new Player(
                teamID,
                fullName,
                username,
                email,
                password,
                inGameName,
                phone,
                age,
                role
            );

            playerService.AddPlayer(player);

            Console.WriteLine();
            Console.WriteLine("Player Added Successfully!");

            Pause();
        }
        // ======================================================
        // View Players
        // ======================================================
        private void ViewPlayers()
        {
            Console.Clear();

            Console.WriteLine("========== PLAYER LIST ==========\n");

            List<Player> players = playerService.GetAllPlayers();

            if (players.Count == 0)
            {
                Console.WriteLine("No players found.");
                Pause();
                return;
            }

            Console.WriteLine(
                "{0,-5} {1,-8} {2,-20} {3,-18} {4,-28} {5,-15} {6,-5} {7,-12}",
                "ID",
                "Team",
                "Full Name",
                "IGN",
                "Email",
                "Phone",
                "Age",
                "Role"
            );

            Console.WriteLine(new string('-', 130));

            foreach (Player p in players)
            {
                Console.WriteLine(
                    "{0,-5} {1,-8} {2,-20} {3,-18} {4,-28} {5,-15} {6,-5} {7,-12}",
                    p.PlayerID,
                    p.TeamID,
                    p.FullName,
                    p.InGameName,
                    p.Email,
                    p.Phone,
                    p.Age,
                    p.Role
                );
            }

            Pause();
        }

        // ======================================================
        // Update Player
        // ======================================================
        private void UpdatePlayer()
        {
            Console.Clear();
        
            Console.WriteLine("========== UPDATE PLAYER ==========\n");
        
            List<Player> players = playerService.GetAllPlayers();
        
            if (players.Count == 0)
            {
                Console.WriteLine("No players found.");
                Pause();
                return;
            }
        
            Console.WriteLine("{0,-5} {1,-20}", "ID", "Player Name");
            Console.WriteLine(new string('-', 30));
        
            foreach (Player p in players)
            {
                Console.WriteLine("{0,-5} {1,-20}", p.PlayerID, p.FullName);
            }
        
            Console.WriteLine();
        
            int playerID = InputHelper.ReadInt("Enter Player ID: ");
        
            if (!playerService.PlayerExists(playerID))
            {
                Console.WriteLine();
                Console.WriteLine("Player ID not found.");
                Pause();
                return;
            }
        
            // Automatically get UserID
            int userID = playerService.GetUserIDByPlayerID(playerID);
        
            int teamID = InputHelper.ReadInt("Team ID: ");
        
            if (!teamService.TeamExists(teamID))
            {
                Console.WriteLine();
                Console.WriteLine("Team ID not found.");
                Pause();
                return;
            }
        
            string fullName = InputHelper.ReadString("Full Name: ");
            string username = InputHelper.ReadString("Username: ");
            string email = InputHelper.ReadEmail("Email: ");
            string password = InputHelper.ReadString("Password: ");
            string inGameName = InputHelper.ReadString("In Game Name: ");
            string phone = InputHelper.ReadString("Phone: ");
            int age = InputHelper.ReadInt("Age: ");
            string role = InputHelper.ReadString("Role (Captain/Player/Substitute): ");
        
            Player player = new Player(
                playerID,
                userID,
                teamID,
                fullName,
                username,
                email,
                password,
                inGameName,
                phone,
                age,
                role
            );
        
            bool updated = playerService.UpdatePlayer(player);
        
            Console.WriteLine();
        
            if (updated)
                Console.WriteLine("Player Updated Successfully!");
            else
                Console.WriteLine("Update Failed.");
        
            Pause();
        }


        // ======================================================
        // Delete Player
        // ======================================================
        private void DeletePlayer()
        {
            Console.Clear();

            Console.WriteLine("========== DELETE PLAYER ==========\n");

            ViewPlayersWithoutPause();

            Console.WriteLine();

            int playerID = InputHelper.ReadInt("Enter Player ID: ");

            if (!playerService.PlayerExists(playerID))
            {
                Console.WriteLine();
                Console.WriteLine("Player ID not found.");
                Pause();
                return;
            }

            Console.Write("Are you sure? (Y/N): ");
            string? choice = Console.ReadLine();

            if (choice?.ToUpper() != "Y")
            {
                Console.WriteLine("Delete Cancelled.");
                Pause();
                return;
            }

            bool deleted = playerService.DeletePlayer(playerID);

            Console.WriteLine();

            if (deleted)
                Console.WriteLine("Player Deleted Successfully!");
            else
                Console.WriteLine("Delete Failed.");

            Pause();
        }

        // ======================================================
        // View Players Without Pause
        // ======================================================
        private void ViewPlayersWithoutPause()
        {
            List<Player> players = playerService.GetAllPlayers();
        
            if (players.Count == 0)
            {
                Console.WriteLine("No players found.");
                return;
            }
        
            Console.WriteLine(
                "{0,-5} {1,-8} {2,-20}",
                "ID",
                "Team",
                "Player Name"
            );
        
            Console.WriteLine(new string('-', 40));
        
            foreach (Player p in players)
            {
                Console.WriteLine(
                    "{0,-5} {1,-8} {2,-20}",
                    p.PlayerID,
                    p.TeamID,
                    p.FullName
                );
            }
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