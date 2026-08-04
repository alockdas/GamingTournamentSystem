// ======================================================
// File: TeamMenu.cs
// Purpose:
// Handles all user interactions related to teams.
// ======================================================

using GamingTournamentSystem.Helpers;
using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Menus
{
    public class TeamMenu
    {
        // Service objects
        private readonly TeamService teamService;
        private readonly TournamentService tournamentService;

        // Constructor
        public TeamMenu()
        {
            teamService = new TeamService();
            tournamentService = new TournamentService();
        }

        // ======================================================
        // Display Team Management Menu
        // ======================================================
        public void Show()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("======================================");
                Console.WriteLine("         TEAM MANAGEMENT");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Add Team");
                Console.WriteLine("2. View Teams");
                Console.WriteLine("3. Update Team");
                Console.WriteLine("4. Delete Team");
                Console.WriteLine("5. Back");
                Console.WriteLine("======================================");

                Console.Write("Choose Option: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTeam();
                        break;

                    case "2":
                        ViewTeams();
                        break;

                    case "3":
                        UpdateTeam();
                        break;

                    case "4":
                        DeleteTeam();
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
        // Add a new team
        // ======================================================
        private void AddTeam()
        {
            Console.Clear();

            Console.WriteLine("========== ADD TEAM ==========\n");
            // Display available tournaments
            Console.WriteLine("Available Tournaments");
            Console.WriteLine("------------------------------");

            List<Tournament> tournaments = tournamentService.GetAllTournaments();

            if (tournaments.Count == 0)
            {
                Console.WriteLine("No tournaments available.");
                Pause();
                return;
            }

            Console.WriteLine("{0,-5} {1,-30}", "ID", "Tournament Name");
            Console.WriteLine(new string('-', 40));

            foreach (Tournament tournament in tournaments)
            {
                Console.WriteLine("{0,-5} {1,-30}",
                    tournament.TournamentID,
                    tournament.TournamentName);
            }

            Console.WriteLine();

            // Read Tournament ID
            int tournamentID = InputHelper.ReadInt("Tournament ID: ");

            // Check if Tournament exists
            if (!tournamentService.TournamentExists(tournamentID))
            {
                Console.WriteLine();
                Console.WriteLine("Tournament ID not found.");
                Pause();
                return;
            }

            // Read team information
            string teamName = InputHelper.ReadString("Team Name: ");

            string captainName = InputHelper.ReadString("Captain Name: ");

            string gameName = InputHelper.ReadString("Game Name: ");

            int totalPlayers = InputHelper.ReadInt("Total Players: ");

            string coachName = InputHelper.ReadString("Coach Name: ");

            // Create Team object
            Team team = new Team(
                tournamentID,
                teamName,
                captainName,
                gameName,
                totalPlayers,
                coachName
            );

            // Save to database
            teamService.AddTeam(team);

            Console.WriteLine();
            Console.WriteLine("Team Added Successfully!");

            Pause();
        }

                // ======================================================
        // Display all teams
        // ======================================================
        private void ViewTeams()
        {
            Console.Clear();

            Console.WriteLine("========== TEAM LIST ==========\n");

            // Get all teams from the database
            List<Team> teams = teamService.GetAllTeams();

            // Check if the list is empty
            if (teams.Count == 0)
            {
                Console.WriteLine("No teams found.");
                Pause();
                return;
            }

            // Display table header
            Console.WriteLine(
                "{0,-5} {1,-8} {2,-20} {3,-20} {4,-15} {5,-10} {6,-20}",
                "ID",
                "Tour ID",
                "Team",
                "Captain",
                "Game",
                "Players",
                "Coach"
            );

            Console.WriteLine(new string('-', 110));

            // Display each team
            foreach (Team team in teams)
            {
                Console.WriteLine(
                    "{0,-5} {1,-8} {2,-20} {3,-20} {4,-15} {5,-10} {6,-20}",
                    team.TeamID,
                    team.TournamentID,
                    team.TeamName,
                    team.CaptainName,
                    team.GameName,
                    team.TotalPlayers,
                    team.CoachName
                );
            }

            Pause();
        }

        // ======================================================
        // Update an existing team
        // ======================================================
        private void UpdateTeam()
        {
            Console.Clear();

            Console.WriteLine("========== UPDATE TEAM ==========\n");
            Console.WriteLine("Available Teams\n");

            List<Team> teams = teamService.GetAllTeams();

            Console.WriteLine("{0,-5} {1,-25}", "ID", "Team Name");
            Console.WriteLine(new string('-', 35));

            foreach (Team t in teams)
            {
                Console.WriteLine("{0,-5} {1,-25}",
                    t.TeamID,
                    t.TeamName);
            }

            Console.WriteLine();

            // Read Team ID
            int teamID = InputHelper.ReadInt("Enter Team ID: ");

            // Check if Team exists
            if (!teamService.TeamExists(teamID))
            {
                Console.WriteLine();
                Console.WriteLine("Team ID not found.");
                Pause();
                return;
            }

            // Read Tournament ID
            int tournamentID = InputHelper.ReadInt("Tournament ID: ");

            // Check if Tournament exists
            if (!tournamentService.TournamentExists(tournamentID))
            {
                Console.WriteLine();
                Console.WriteLine("Tournament ID not found.");
                Pause();
                return;
            }

            // Read updated information
            string teamName = InputHelper.ReadString("Team Name: ");

            string captainName = InputHelper.ReadString("Captain Name: ");

            string gameName = InputHelper.ReadString("Game Name: ");

            int totalPlayers = InputHelper.ReadInt("Total Players: ");

            string coachName = InputHelper.ReadString("Coach Name: ");

            // Create Team object
            Team team = new Team(
                teamID,
                tournamentID,
                teamName,
                captainName,
                gameName,
                totalPlayers,
                coachName
            );

            // Update the database
            bool updated = teamService.UpdateTeam(team);

            Console.WriteLine();

            if (updated)
            {
                Console.WriteLine("Team Updated Successfully!");
            }
            else
            {
                Console.WriteLine("Update Failed.");
            }

            Pause();
        }

        // ======================================================
        // Delete a team
        // ======================================================
        private void DeleteTeam()
        {
            Console.Clear();

            Console.WriteLine("========== DELETE TEAM ==========\n");
            Console.WriteLine("Available Teams\n");

            List<Team> teams = teamService.GetAllTeams();

            Console.WriteLine("{0,-5} {1,-25}", "ID", "Team Name");
            Console.WriteLine(new string('-', 35));

            foreach (Team t in teams)
            {
                Console.WriteLine("{0,-5} {1,-25}",
                    t.TeamID,
                    t.TeamName);
            }

            // Read Team ID
            int teamID = InputHelper.ReadInt("Enter Team ID: ");

            // Check if Team exists
            if (!teamService.TeamExists(teamID))
            {
                Console.WriteLine();
                Console.WriteLine("Team ID not found.");
                Pause();
                return;
            }

            Console.Write("\nAre you sure you want to delete this team? (Y/N): ");
            string? choice = Console.ReadLine();

            if (choice != null && choice.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                bool deleted = teamService.DeleteTeam(teamID);

                Console.WriteLine();

                if (deleted)
                {
                    Console.WriteLine("Team Deleted Successfully!");
                }
                else
                {
                    Console.WriteLine("Delete Failed.");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Delete Operation Cancelled.");
            }

            Pause();
        }

        // ======================================================
        // Pause the screen
        // ======================================================
        private void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
        }
    }
}