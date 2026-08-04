using GamingTournamentSystem.Helpers;
using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Menus
{
    public class MatchMenu
    {
        private readonly MatchService matchService;
        private readonly TournamentService tournamentService;
        private readonly TeamService teamService;

        public MatchMenu()
        {
            matchService = new MatchService();
            tournamentService = new TournamentService();
            teamService = new TeamService();
        }

        // ======================================================
        // Display Match Menu
        // ======================================================
        public void Show()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("======================================");
                Console.WriteLine("        MATCH MANAGEMENT");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Add Match");
                Console.WriteLine("2. View Matches");
                Console.WriteLine("3. Update Match");
                Console.WriteLine("4. Delete Match");
                Console.WriteLine("5. Back");
                Console.WriteLine("======================================");

                Console.Write("Choose Option: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddMatch();
                        break;

                    case "2":
                        ViewMatches();
                        break;

                    case "3":
                        UpdateMatch();
                        break;

                    case "4":
                        DeleteMatch();
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
        // Add Match
        // ======================================================
        private void AddMatch()
        {
            Console.Clear();

            Console.WriteLine("========== ADD MATCH ==========\n");

            // Show tournaments
            List<Tournament> tournaments = tournamentService.GetAllTournaments();

            if (tournaments.Count == 0)
            {
                Console.WriteLine("No tournaments found.");
                Pause();
                return;
            }

            Console.WriteLine("{0,-5} {1,-30}", "ID", "Tournament");

            Console.WriteLine(new string('-', 40));

            foreach (Tournament t in tournaments)
            {
                Console.WriteLine("{0,-5} {1,-30}",
                    t.TournamentID,
                    t.TournamentName);
            }

            Console.WriteLine();

            int tournamentID = InputHelper.ReadInt("Tournament ID: ");

            if (!tournamentService.TournamentExists(tournamentID))
            {
                Console.WriteLine("\nTournament not found.");
                Pause();
                return;
            }

            Console.WriteLine();

            // Show teams
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

            int team1ID = InputHelper.ReadInt("Team 1 ID: ");
            int team2ID = InputHelper.ReadInt("Team 2 ID: ");

            if (team1ID == team2ID)
            {
                Console.WriteLine();
                Console.WriteLine("Team 1 and Team 2 cannot be the same.");
                Pause();
                return;
            }

            if (!teamService.TeamExists(team1ID))
            {
                Console.WriteLine("Team 1 not found.");
                Pause();
                return;
            }

            if (!teamService.TeamExists(team2ID))
            {
                Console.WriteLine("Team 2 not found.");
                Pause();
                return;
            }

            DateTime matchDate =
                InputHelper.ReadDate("Match Date (yyyy-mm-dd): ");

            TimeSpan matchTime =
                InputHelper.ReadTime("Match Time (HH:mm): ");

            string venue =
                InputHelper.ReadString("Venue: ");

            string status =
                InputHelper.ReadString("Status (Scheduled/Ongoing/Completed): ");

            Match match = new Match(
                tournamentID,
                team1ID,
                team2ID,
                matchDate,
                matchTime,
                venue,
                null,
                status
            );

            matchService.AddMatch(match);

            Console.WriteLine();
            Console.WriteLine("Match Added Successfully!");

            Pause();
        }

                // ======================================================
        // View All Matches
        // ======================================================
        private void ViewMatches()
        {
            Console.Clear();

            Console.WriteLine("========== MATCH LIST ==========\n");

            List<Match> matches = matchService.GetAllMatches();

            if (matches.Count == 0)
            {
                Console.WriteLine("No matches found.");
                Pause();
                return;
            }

            Console.WriteLine(
                "{0,-5} {1,-8} {2,-8} {3,-8} {4,-12} {5,-8} {6,-18} {7,-12}",
                "ID",
                "Tour",
                "T1",
                "T2",
                "Date",
                "Time",
                "Venue",
                "Status"
            );

            Console.WriteLine(new string('-', 95));

            foreach (Match match in matches)
            {
                Console.WriteLine(
                    "{0,-5} {1,-8} {2,-8} {3,-8} {4,-12:yyyy-MM-dd} {5,-8} {6,-18} {7,-12}",
                    match.MatchID,
                    match.TournamentID,
                    match.Team1ID,
                    match.Team2ID,
                    match.MatchDate,
                    match.MatchTime,
                    match.Venue,
                    match.Status
                );
            }

            Pause();
        }

        // ======================================================
        // Update Match
        // ======================================================
        private void UpdateMatch()
        {
            Console.Clear();

            Console.WriteLine("========== UPDATE MATCH ==========\n");

            ViewMatchesWithoutPause();

            Console.WriteLine();

            int matchID = InputHelper.ReadInt("Enter Match ID: ");

            if (!matchService.MatchExists(matchID))
            {
                Console.WriteLine();
                Console.WriteLine("Match ID not found.");
                Pause();
                return;
            }

            int tournamentID = InputHelper.ReadInt("Tournament ID: ");

            if (!tournamentService.TournamentExists(tournamentID))
            {
                Console.WriteLine();
                Console.WriteLine("Tournament ID not found.");
                Pause();
                return;
            }

            int team1ID = InputHelper.ReadInt("Team 1 ID: ");
            int team2ID = InputHelper.ReadInt("Team 2 ID: ");

            if (team1ID == team2ID)
            {
                Console.WriteLine();
                Console.WriteLine("Team 1 and Team 2 cannot be the same.");
                Pause();
                return;
            }

            if (!teamService.TeamExists(team1ID) ||
                !teamService.TeamExists(team2ID))
            {
                Console.WriteLine();
                Console.WriteLine("One or both Team IDs are invalid.");
                Pause();
                return;
            }

            DateTime matchDate =
                InputHelper.ReadDate("Match Date (yyyy-mm-dd): ");

            TimeSpan matchTime =
                InputHelper.ReadTime("Match Time (HH:mm): ");

            string venue =
                InputHelper.ReadString("Venue: ");

            Console.Write("Winner Team ID (Leave blank if none): ");
            string? winnerInput = Console.ReadLine();

            int? winnerID = null;

            if (!string.IsNullOrWhiteSpace(winnerInput))
            {
                if (int.TryParse(winnerInput, out int id))
                {
                    winnerID = id;
                }
            }

            string status =
                InputHelper.ReadString("Status (Scheduled/Ongoing/Completed): ");

            Match match = new Match(
                matchID,
                tournamentID,
                team1ID,
                team2ID,
                matchDate,
                matchTime,
                venue,
                winnerID,
                status
            );

            bool updated = matchService.UpdateMatch(match);

            Console.WriteLine();

            if (updated)
                Console.WriteLine("Match Updated Successfully!");
            else
                Console.WriteLine("Update Failed.");

            Pause();
        }

        // ======================================================
        // Delete Match
        // ======================================================
        private void DeleteMatch()
        {
            Console.Clear();

            Console.WriteLine("========== DELETE MATCH ==========\n");

            ViewMatchesWithoutPause();

            Console.WriteLine();

            int matchID = InputHelper.ReadInt("Enter Match ID: ");

            if (!matchService.MatchExists(matchID))
            {
                Console.WriteLine();
                Console.WriteLine("Match ID not found.");
                Pause();
                return;
            }

            Console.Write("\nAre you sure? (Y/N): ");
            string? choice = Console.ReadLine();

            if (choice != null &&
                choice.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                bool deleted = matchService.DeleteMatch(matchID);

                Console.WriteLine();

                if (deleted)
                    Console.WriteLine("Match Deleted Successfully!");
                else
                    Console.WriteLine("Delete Failed.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Delete Cancelled.");
            }

            Pause();
        }

        // ======================================================
        // View Matches (Without Pause)
        // ======================================================
        private void ViewMatchesWithoutPause()
        {
            List<Match> matches = matchService.GetAllMatches();

            if (matches.Count == 0)
            {
                Console.WriteLine("No matches found.");
                return;
            }

            Console.WriteLine(
                "{0,-5} {1,-8} {2,-8} {3,-8} {4,-12}",
                "ID",
                "Tour",
                "T1",
                "T2",
                "Date"
            );

            Console.WriteLine(new string('-', 55));

            foreach (Match match in matches)
            {
                Console.WriteLine(
                    "{0,-5} {1,-8} {2,-8} {3,-8} {4,-12:yyyy-MM-dd}",
                    match.MatchID,
                    match.TournamentID,
                    match.Team1ID,
                    match.Team2ID,
                    match.MatchDate
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