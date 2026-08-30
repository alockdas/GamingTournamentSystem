using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Forms
{
    public partial class ReportsForm : Form
    {
        private readonly AdminDashboard adminDashboard;

        private readonly TournamentService tournamentService;
        private readonly TeamService teamService;
        private readonly PlayerService playerService;
        private readonly MatchService matchService;
        private readonly LeaderboardService leaderboardService;

        
        // Constructor
        
        public ReportsForm(AdminDashboard dashboard)
        {
            InitializeComponent();

            adminDashboard = dashboard;

            tournamentService = new TournamentService();
            teamService = new TeamService();
            playerService = new PlayerService();
            matchService = new MatchService();
            leaderboardService = new LeaderboardService();

            LoadReportsPage();
        }

        
        // Form Load
        
        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadReportsPage();
        }

        
        // Main Reports Page
        
        private void LoadReportsPage()
        {
            lblPageTitle.Text = "Reports";

            lblPageSubtitle.Text =
                "Generate and view tournament management reports.";

            ClearReportArea();

            Label message = CreateMessageLabel(
                "📄 Reports",
                "Select a report from the options above."
            );

            pnlReportContent.Controls.Add(message);
        }

        
        // Tournament Report
        
        private void btnTournamentReport_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                SetSelectedButton(btnTournamentReport);

                var tournaments =
                    tournamentService.GetAllTournaments();

                StringBuilder report =
                    new StringBuilder();

                report.AppendLine(
                    "================ TOURNAMENT REPORT ================\n");

                report.AppendLine(
                    "ID    Tournament Name        Game              Status");

                report.AppendLine(
                    "--------------------------------------------------------------");

                foreach (var tournament in tournaments)
                {
                    report.AppendLine(
                        $"{tournament.TournamentID,-5}" +
                        $"{LimitText(tournament.TournamentName, 23),-24}" +
                        $"{LimitText(tournament.GameName, 17),-18}" +
                        $"{tournament.Status,-15}");
                }

                report.AppendLine();

                report.AppendLine(
                    "------------------------------------------");

                report.AppendLine(
                    $"Total Tournaments : {tournaments.Count}");

                report.AppendLine(
                    "------------------------------------------");

                ShowReport(
                    "🏆 Tournament Report",
                    report.ToString());
            }
            catch (Exception ex)
            {
                ShowError(
                    "Failed to generate tournament report.",
                    ex);
            }
        }

        
        // Team Report
        
        private void btnTeamReport_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                SetSelectedButton(btnTeamReport);

                var teams =
                    teamService.GetAllTeams();

                StringBuilder report =
                    new StringBuilder();

                report.AppendLine(
                    "================== TEAM REPORT ==================\n");

                report.AppendLine(
                    "ID   Team               Captain         Players  MP    W     L     D     Pts");

                report.AppendLine(
                    "------------------------------------------------------------------------------------------");

                foreach (Team team in teams)
                {
                    report.AppendLine(
                        $"{team.TeamID,-5}" +
                        $"{LimitText(team.TeamName, 19),-19}" +
                        $"{LimitText(team.CaptainName, 15),-15}" +
                        $"{team.TotalPlayers,-9}" +
                        $"{team.MatchesPlayed,-6}" +
                        $"{team.Wins,-6}" +
                        $"{team.Losses,-6}" +
                        $"{team.Draws,-6}" +
                        $"{team.Points,-6}");
                }

                report.AppendLine();

                report.AppendLine(
                    "------------------------------------------");

                report.AppendLine(
                    $"Total Teams : {teams.Count}");

                report.AppendLine(
                    "------------------------------------------");

                ShowReport(
                    "👥 Team Report",
                    report.ToString());
            }
            catch (Exception ex)
            {
                ShowError(
                    "Failed to generate team report.",
                    ex);
            }
        }

        
        // Player Report
        
        private void btnPlayerReport_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                SetSelectedButton(btnPlayerReport);

                var players =
                    playerService.GetAllPlayers();

                StringBuilder report =
                    new StringBuilder();

                report.AppendLine(
                    "================== PLAYER REPORT ==================\n");

                report.AppendLine(
                    "ID   Player Name          IGN             Email                     Age          Role");

                report.AppendLine(
                    "-----------------------------------------------------------------------------------------------");

                foreach (Player player in players)
                {
                    report.AppendLine(
                        $"{player.PlayerID,-5}" +
                        $"{LimitText(player.FullName, 21),-21}" +
                        $"{LimitText(player.InGameName, 16),-16}" +
                        $"{LimitText(player.Email, 25),-25}" +
                        $"{player.Age,-13}" +
                        $"{player.Role}");
                }

                report.AppendLine();

                report.AppendLine(
                    "------------------------------------------");

                report.AppendLine(
                    $"Total Players : {players.Count}");

                report.AppendLine(
                    "------------------------------------------");

                ShowReport(
                    "🎮 Player Report",
                    report.ToString());
            }
            catch (Exception ex)
            {
                ShowError(
                    "Failed to generate player report.",
                    ex);
            }
        }

        
        // Match Report
        
        private void btnMatchReport_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                SetSelectedButton(btnMatchReport);

                var matches =
                    matchService.GetAllMatches();

                StringBuilder report =
                    new StringBuilder();

                report.AppendLine(
                    "================== MATCH REPORT ==================\n");

                report.AppendLine(
                    "ID   Tour  T1     T2     Date         Time     Venue              Winner     Status");

                report.AppendLine(
                    "--------------------------------------------------------------------------------------------------------------");

                foreach (Match match in matches)
                {
                    
                    // Winner
                    
                    string winner = "-";

                    if (match.WinnerTeamID.HasValue)
                    {
                        winner =
                            match.WinnerTeamID.Value.ToString();
                    }

                    
                    // Date
                    // Do NOT use :yyyy-MM-dd formatting here.
                    // This prevents runtime format errors when
                    // MatchDate is stored/returned as string.
                    string matchDate =
                        Convert.ToString(match.MatchDate) ?? "";

                    
                    // Time
                    // Do NOT use :hh\:mm formatting here either.
                    string matchTime =
                        Convert.ToString(match.MatchTime) ?? "";

                    
                    // Match Report Row
                    
                    report.AppendLine(
                        $"{match.MatchID,-5}" +
                        $"{match.TournamentID,-6}" +
                        $"{match.Team1ID,-7}" +
                        $"{match.Team2ID,-7}" +
                        $"{LimitText(matchDate, 11),-13}" +
                        $"{LimitText(matchTime, 8),-9}" +
                        $"{LimitText(match.Venue, 19),-19}" +
                        $"{winner,-11}" +
                        $"{match.Status}");
                }

                report.AppendLine();

                report.AppendLine(
                    "------------------------------------------");

                report.AppendLine(
                    $"Total Matches : {matches.Count}");

                report.AppendLine(
                    "------------------------------------------");

                ShowReport(
                    "⚔️ Match Report",
                    report.ToString());
            }
            catch (Exception ex)
            {
                ShowError(
                    "Failed to generate match report.",
                    ex);
            }
        }

        
        // Leaderboard Report
        
        private void btnLeaderboardReport_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                SetSelectedButton(btnLeaderboardReport);

                var teams =
                    leaderboardService.GetLeaderboard();

                StringBuilder report =
                    new StringBuilder();

                report.AppendLine(
                    "================ LEADERBOARD REPORT ================\n");

                report.AppendLine(
                    "Rank  Team                 Played   Win    Loss   Draw   Pts");

                report.AppendLine(
                    "----------------------------------------------------------------------");

                int rank = 1;

                foreach (Team team in teams)
                {
                    report.AppendLine(
                        $"{rank,-6}" +
                        $"{LimitText(team.TeamName, 20),-21}" +
                        $"{team.MatchesPlayed,-9}" +
                        $"{team.Wins,-7}" +
                        $"{team.Losses,-7}" +
                        $"{team.Draws,-7}" +
                        $"{team.Points}");

                    rank++;
                }

                report.AppendLine();

                report.AppendLine(
                    "------------------------------------------");

                report.AppendLine(
                    $"Total Teams : {teams.Count}");

                report.AppendLine(
                    "------------------------------------------");

                ShowReport(
                    "📈 Leaderboard Report",
                    report.ToString());
            }
            catch (Exception ex)
            {
                ShowError(
                    "Failed to generate leaderboard report.",
                    ex);
            }
        }

        
        // Show Report
        
        private void ShowReport(
            string title,
            string reportText)
        {
            lblPageTitle.Text = title;

            lblPageSubtitle.Text =
                "Generated report from the current database records.";

            ClearReportArea();

            TextBox reportBox =
                new TextBox();

            reportBox.Multiline = true;

            reportBox.ReadOnly = true;

            reportBox.ScrollBars =
                ScrollBars.Both;

            reportBox.WordWrap = false;

            reportBox.Font =
                new Font(
                    "Consolas",
                    10F,
                    FontStyle.Regular);

            reportBox.BackColor =
                Color.White;

            reportBox.ForeColor =
                Color.FromArgb(
                    33,
                    37,
                    41);

            reportBox.BorderStyle =
                BorderStyle.FixedSingle;

            reportBox.Dock =
                DockStyle.Fill;

            reportBox.Text =
                reportText;

            reportBox.Padding =
                new Padding(10);

            pnlReportContent.Controls.Add(
                reportBox);
        }

        
        // Clear Report Area
        
        private void ClearReportArea()
        {
            pnlReportContent.Controls.Clear();
        }

        
        // Create Message Label
        
        private Label CreateMessageLabel(
            string title,
            string message)
        {
            Label label =
                new Label();

            label.AutoSize = false;

            label.BackColor =
                Color.White;

            label.BorderStyle =
                BorderStyle.FixedSingle;

            label.Font =
                new Font(
                    "Segoe UI",
                    14F,
                    FontStyle.Bold);

            label.ForeColor =
                Color.FromArgb(
                    33,
                    37,
                    41);

            label.Dock =
                DockStyle.Fill;

            label.Text =
                $"{title}\n\n{message}";

            label.TextAlign =
                ContentAlignment.MiddleCenter;

            return label;
        }

        
        // Selected Report Button
        
        private void SetSelectedButton(
            Button selectedButton)
        {
            Button[] buttons =
            {
                btnTournamentReport,
                btnTeamReport,
                btnPlayerReport,
                btnMatchReport,
                btnLeaderboardReport
            };

            foreach (Button button in buttons)
            {
                button.BackColor =
                    Color.White;

                button.ForeColor =
                    Color.FromArgb(
                        33,
                        37,
                        41);
            }

            selectedButton.BackColor =
                Color.FromArgb(
                    30,
                    109,
                    235);

            selectedButton.ForeColor =
                Color.White;
        }

        
        // Back
        
        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            adminDashboard.Show();

            Close();
        }

        
        // Error Message
        
        private void ShowError(
            string message,
            Exception ex)
        {
            MessageBox.Show(
                message +
                "\n\n" +
                ex.Message,
                "Report Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        
        // Limit Long Text
        
        private string LimitText(
            string text,
            int maxLength)
        {
            if (string.IsNullOrEmpty(text))
                return "";

            if (text.Length <= maxLength)
                return text;

            return text.Substring(
                0,
                maxLength - 3) + "...";
        }
    }
}