using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Menus
{
    public class ReportsMenu
    {
        private readonly TournamentService tournamentService;
        private readonly TeamService teamService;
        private readonly PlayerService playerService;
        private readonly MatchService matchService;
        private readonly LeaderboardService leaderboardService;

        public ReportsMenu()
        {
            tournamentService = new TournamentService();
            teamService = new TeamService();
            playerService = new PlayerService();
            matchService = new MatchService();
            leaderboardService = new LeaderboardService();
        }

        public void Show()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("====================================");
                Console.WriteLine("            REPORTS");
                Console.WriteLine("====================================");
                Console.WriteLine("1. Tournament Report");
                Console.WriteLine("2. Team Report");
                Console.WriteLine("3. Player Report");
                Console.WriteLine("4. Match Report");
                Console.WriteLine("5. Leaderboard Report");
                Console.WriteLine("6. Back");
                Console.WriteLine("====================================");

                Console.Write("Choose Option: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        TournamentReport();
                        break;

                    case "2":
                        TeamReport();
                        break;

                    case "3":
                        PlayerReport();
                        break;

                    case "4":
                        MatchReport();
                        break;

                    case "5":
                        LeaderboardReport();
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

        private void TournamentReport()
        {
            Console.Clear();

            Console.WriteLine("============== TOURNAMENT REPORT ==============\n");

            List<Tournament> tournaments = tournamentService.GetAllTournaments();

            if (tournaments.Count == 0)
            {
                Console.WriteLine("No tournaments found.");
                Pause();
                return;
            }

            Console.WriteLine(
                "{0,-5} {1,-25} {2,-15} {3,-12} {4,-12} {5,-12} {6,-12}",
                "ID",
                "Tournament",
                "Game",
                "Start",
                "End",
                "Prize",
                "Status");

            Console.WriteLine(new string('-', 100));

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

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Total Tournaments : {tournaments.Count}");
            Console.WriteLine("----------------------------------------------");

            Pause();
        }

        private void TeamReport()
        {
            Console.Clear();

            Console.WriteLine("================== TEAM REPORT ==================\n");

            List<Team> teams = teamService.GetAllTeams();

            if (teams.Count == 0)
            {
                Console.WriteLine("No teams found.");
                Pause();
                return;
            }

            Console.WriteLine(
                "{0,-4} {1,-18} {2,-15} {3,-8} {4,-5} {5,-5} {6,-5} {7,-5} {8,-6}",
                "ID",
                "Team",
                "Captain",
                "Players",
                "MP",
                "W",
                "L",
                "D",
                "Pts");

            Console.WriteLine(new string('-', 90));

            foreach (Team team in teams)
            {
                Console.WriteLine(
                    "{0,-4} {1,-18} {2,-15} {3,-8} {4,-5} {5,-5} {6,-5} {7,-5} {8,-6}",
                    team.TeamID,
                    team.TeamName,
                    team.CaptainName,
                    team.TotalPlayers,
                    team.MatchesPlayed,
                    team.Wins,
                    team.Losses,
                    team.Draws,
                    team.Points
                );
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Total Teams : {teams.Count}");
            Console.WriteLine("------------------------------------------");

            Pause();
        }

        private void PlayerReport()
        {
            Console.Clear();

            Console.WriteLine("================== PLAYER REPORT ==================\n");

            List<Player> players = playerService.GetAllPlayers();

            if (players.Count == 0)
            {
                Console.WriteLine("No players found.");
                Pause();
                return;
            }

            Console.WriteLine(
                "{0,-4} {1,-20} {2,-15} {3,-25} {4,-12} {5,-5}",
                "ID",
                "Player Name",
                "IGN",
                "Email",
                "Age",
                "Role");

            Console.WriteLine(new string('-', 95));

            foreach (Player player in players)
            {
                Console.WriteLine(
                    "{0,-4} {1,-20} {2,-15} {3,-25} {4,-12} {5,-5}",
                    player.PlayerID,
                    player.FullName,
                    player.InGameName,
                    player.Email,
                    player.Age,
                    player.Role
                );
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Total Players : {players.Count}");
            Console.WriteLine("------------------------------------------");

            Pause();
        }

        private void MatchReport()
        {
            Console.Clear();

            Console.WriteLine("================== MATCH REPORT ==================\n");

            List<Match> matches = matchService.GetAllMatches();

            if (matches.Count == 0)
            {
                Console.WriteLine("No matches found.");
                Pause();
                return;
            }

            Console.WriteLine(
                "{0,-4} {1,-5} {2,-6} {3,-6} {4,-12} {5,-8} {6,-18} {7,-10} {8,-10}",
                "ID",
                "Tour",
                "T1",
                "T2",
                "Date",
                "Time",
                "Venue",
                "Winner",
                "Status"
            );

            Console.WriteLine(new string('-', 110));

            foreach (Match match in matches)
            {
                string winner = match.WinnerTeamID.HasValue
                    ? match.WinnerTeamID.Value.ToString()
                    : "-";

                Console.WriteLine(
                    "{0,-4} {1,-5} {2,-6} {3,-6} {4,-12:yyyy-MM-dd} {5,-8} {6,-18} {7,-10} {8,-10}",
                    match.MatchID,
                    match.TournamentID,
                    match.Team1ID,
                    match.Team2ID,
                    match.MatchDate,
                    match.MatchTime.ToString(@"hh\:mm"),
                    match.Venue,
                    winner,
                    match.Status
                );
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Total Matches : {matches.Count}");
            Console.WriteLine("------------------------------------------");

            Pause();
        }

        private void LeaderboardReport()
        {
            Console.Clear();
        
            Console.WriteLine("================ LEADERBOARD REPORT ================\n");
        
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
        
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Total Teams : {teams.Count}");
            Console.WriteLine("------------------------------------------");
        
            Pause();
        }
        
        private void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
        }
    }
}   