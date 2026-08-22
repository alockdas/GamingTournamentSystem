using System;
using System.Drawing;
using System.Windows.Forms;
using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Forms
{
    public partial class PlayerDashboard : Form
    {
        private readonly User currentUser;
        private readonly PlayerDashboardService dashboardService;

        public PlayerDashboard(User user)
        {
            InitializeComponent();

            currentUser = user;
            dashboardService = new PlayerDashboardService();

            lblPlayerName.Text = currentUser.FullName;
            lblPlayerRole.Text = currentUser.Role;

            lblWelcome.Text =
                $"Welcome back, {currentUser.FullName}.";

            lblCurrentDate.Text =
                DateTime.Now.ToString("MMMM dd, yyyy");

            SetActiveButton(btnDashboard);

            LoadDashboard();
        }

        // =====================================================
        // FORM LOAD
        // =====================================================

        private void PlayerDashboard_Load(
            object? sender,
            EventArgs e)
        {
            LoadDashboard();
        }

        // =====================================================
        // DASHBOARD
        // =====================================================

        private void btnDashboard_Click(
            object? sender,
            EventArgs e)
        {
            SetActiveButton(btnDashboard);

            lblPageTitle.Text = "Dashboard";

            lblWelcome.Text =
                $"Welcome back, {currentUser.FullName}.";

            LoadDashboard();
        }

        private void LoadDashboard()
        {
            try
            {
                pnlContent.Controls.Clear();

                int tournaments =
                    dashboardService.GetTournamentCount();

                int matches =
                    dashboardService.GetPlayerMatchCount(
                        currentUser.UserID);

                int points =
                    dashboardService.GetTeamPoints(
                        currentUser.UserID);

                TeamInfo? team =
                    dashboardService.GetMyTeam(
                        currentUser.UserID);

                Panel card1 = CreateStatCard(
                    "🏆",
                    "Tournaments",
                    tournaments.ToString(),
                    "Available tournaments",
                    20);

                Panel card2 = CreateStatCard(
                    "⚔",
                    "My Matches",
                    matches.ToString(),
                    "Matches assigned to you",
                    245);

                Panel card3 = CreateStatCard(
                    "⭐",
                    "Team Points",
                    points.ToString(),
                    "Current team points",
                    470);

                pnlContent.Controls.Add(card1);
                pnlContent.Controls.Add(card2);
                pnlContent.Controls.Add(card3);

                // =================================================
                // TEAM SUMMARY
                // =================================================

                Panel teamCard = new Panel
                {
                    BackColor = Color.White,
                    Location = new Point(20, 190),
                    Size = new Size(655, 210),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label teamTitle = new Label
                {
                    Text = "My Team",
                    Font = new Font(
                        "Segoe UI",
                        15F,
                        FontStyle.Bold),
                    ForeColor =
                        Color.FromArgb(33, 37, 41),
                    Location = new Point(20, 20),
                    AutoSize = true
                };

                teamCard.Controls.Add(teamTitle);

                if (team != null)
                {
                    AddInfoLabel(
                        teamCard,
                        "Team Name:",
                        team.TeamName,
                        65);

                    AddInfoLabel(
                        teamCard,
                        "Game:",
                        team.GameName,
                        100);

                    AddInfoLabel(
                        teamCard,
                        "Tournament:",
                        team.TournamentName,
                        135);

                    AddInfoLabel(
                        teamCard,
                        "Record:",
                        $"{team.Wins} Wins / {team.Losses} Losses / {team.Draws} Draws",
                        170);
                }
                else
                {
                    Label noTeam = new Label
                    {
                        Text =
                            "You are not assigned to any team yet.",
                        Font =
                            new Font("Segoe UI", 10F),
                        ForeColor =
                            Color.FromArgb(108, 117, 125),
                        Location =
                            new Point(20, 75),
                        AutoSize = true
                    };

                    teamCard.Controls.Add(noTeam);
                }

                pnlContent.Controls.Add(teamCard);
            }
            catch (Exception ex)
            {
                ShowDatabaseError(ex);
            }
        }

        // =====================================================
        // TOURNAMENTS
        // =====================================================

        private void btnTournaments_Click(
            object? sender,
            EventArgs e)
        {
            SetActiveButton(btnTournaments);

            lblPageTitle.Text = "Tournaments";

            lblWelcome.Text =
                "View all available tournaments.";

            LoadTournaments();
        }

        private void LoadTournaments()
        {
            try
            {
                pnlContent.Controls.Clear();

                var tournaments =
                    dashboardService.GetTournaments();

                Label heading = CreateContentTitle(
                    "Available Tournaments");

                pnlContent.Controls.Add(heading);

                if (tournaments.Count == 0)
                {
                    AddNoDataMessage(
                        "No tournaments are available currently.",
                        20,
                        65);

                    return;
                }

                int y = 65;

                foreach (var tournament in tournaments)
                {
                    Panel card = new Panel
                    {
                        BackColor = Color.White,
                        Location = new Point(20, y),
                        Size = new Size(860, 125),
                        BorderStyle =
                            BorderStyle.FixedSingle
                    };

                    Label name = new Label
                    {
                        Text = tournament.TournamentName,
                        Font = new Font(
                            "Segoe UI",
                            13F,
                            FontStyle.Bold),
                        ForeColor =
                            Color.FromArgb(33, 37, 41),
                        Location =
                            new Point(20, 15),
                        AutoSize = true
                    };

                    Label game = new Label
                    {
                        Text =
                            $"Game: {tournament.GameName}",
                        Font =
                            new Font("Segoe UI", 9.5F),
                        Location =
                            new Point(20, 48),
                        AutoSize = true
                    };

                    Label dates = new Label
                    {
                        Text =
                            $"Date: {tournament.StartDate:dd MMM yyyy} - {tournament.EndDate:dd MMM yyyy}",
                        Font =
                            new Font("Segoe UI", 9.5F),
                        Location =
                            new Point(20, 76),
                        AutoSize = true
                    };

                    Label prize = new Label
                    {
                        Text =
                            $"Prize Pool: ${tournament.PrizePool:N2}",
                        Font =
                            new Font(
                                "Segoe UI",
                                9.5F,
                                FontStyle.Bold),
                        Location =
                            new Point(400, 48),
                        AutoSize = true
                    };

                    Label status = new Label
                    {
                        Text =
                            $"Status: {tournament.Status}",
                        Font =
                            new Font(
                                "Segoe UI",
                                9.5F,
                                FontStyle.Bold),
                        ForeColor =
                            Color.FromArgb(30, 109, 235),
                        Location =
                            new Point(400, 76),
                        AutoSize = true
                    };

                    card.Controls.Add(name);
                    card.Controls.Add(game);
                    card.Controls.Add(dates);
                    card.Controls.Add(prize);
                    card.Controls.Add(status);

                    pnlContent.Controls.Add(card);

                    y += 140;
                }
            }
            catch (Exception ex)
            {
                ShowDatabaseError(ex);
            }
        }

        // =====================================================
        // MY TEAM
        // =====================================================

        private void btnMyTeam_Click(
            object? sender,
            EventArgs e)
        {
            SetActiveButton(btnMyTeam);

            lblPageTitle.Text = "My Team";

            lblWelcome.Text =
                "View your current team information.";

            LoadMyTeam();
        }

        private void LoadMyTeam()
        {
            try
            {
                pnlContent.Controls.Clear();

                TeamInfo? team =
                    dashboardService.GetMyTeam(
                        currentUser.UserID);

                Label heading =
                    CreateContentTitle("My Team");

                pnlContent.Controls.Add(heading);

                if (team == null)
                {
                    AddNoDataMessage(
                        "You are not assigned to a team yet.",
                        20,
                        65);

                    return;
                }

                Panel card = new Panel
                {
                    BackColor = Color.White,
                    Location = new Point(20, 65),
                    Size = new Size(700, 360),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label teamName = new Label
                {
                    Text = team.TeamName,
                    Font = new Font(
                        "Segoe UI",
                        18F,
                        FontStyle.Bold),
                    ForeColor =
                        Color.FromArgb(30, 109, 235),
                    Location = new Point(30, 25),
                    AutoSize = true
                };

                card.Controls.Add(teamName);

                AddInfoLabel(
                    card,
                    "Game:",
                    team.GameName,
                    80);

                AddInfoLabel(
                    card,
                    "Tournament:",
                    team.TournamentName,
                    120);

                AddInfoLabel(
                    card,
                    "Captain:",
                    team.CaptainName,
                    160);

                AddInfoLabel(
                    card,
                    "Coach:",
                    team.CoachName,
                    200);

                AddInfoLabel(
                    card,
                    "Total Players:",
                    team.TotalPlayers.ToString(),
                    240);

                AddInfoLabel(
                    card,
                    "Matches Played:",
                    team.MatchesPlayed.ToString(),
                    280);

                AddInfoLabel(
                    card,
                    "Record:",
                    $"{team.Wins} Wins / {team.Losses} Losses / {team.Draws} Draws",
                    320);

                pnlContent.Controls.Add(card);
            }
            catch (Exception ex)
            {
                ShowDatabaseError(ex);
            }
        }

        // =====================================================
        // MATCHES
        // =====================================================

        private void btnMatches_Click(
            object? sender,
            EventArgs e)
        {
            SetActiveButton(btnMatches);

            lblPageTitle.Text = "My Matches";

            lblWelcome.Text =
                "View your upcoming and completed matches.";

            LoadMatches();
        }

        private void LoadMatches()
        {
            try
            {
                pnlContent.Controls.Clear();

                Label heading =
                    CreateContentTitle("My Matches");

                pnlContent.Controls.Add(heading);

                var matches =
                    dashboardService.GetMyMatches(
                        currentUser.UserID);

                if (matches.Count == 0)
                {
                    AddNoDataMessage(
                        "No matches have been assigned to your team.",
                        20,
                        65);

                    return;
                }

                int y = 65;

                foreach (var match in matches)
                {
                    Panel card = new Panel
                    {
                        BackColor = Color.White,
                        Location = new Point(20, y),
                        Size = new Size(860, 135),
                        BorderStyle =
                            BorderStyle.FixedSingle
                    };

                    Label tournament = new Label
                    {
                        Text =
                            match.TournamentName,
                        Font =
                            new Font(
                                "Segoe UI",
                                12F,
                                FontStyle.Bold),
                        Location =
                            new Point(20, 15),
                        AutoSize = true
                    };

                    Label teams = new Label
                    {
                        Text =
                            $"{match.Team1Name}  VS  {match.Team2Name}",
                        Font =
                            new Font(
                                "Segoe UI",
                                11F,
                                FontStyle.Bold),
                        ForeColor =
                            Color.FromArgb(
                                30, 109, 235),
                        Location =
                            new Point(20, 48),
                        AutoSize = true
                    };

                    Label date = new Label
                    {
                        Text =
                            $"{match.MatchDate:dd MMM yyyy}  |  {match.MatchTime}",
                        Location =
                            new Point(20, 82),
                        AutoSize = true,
                        Font =
                            new Font(
                                "Segoe UI",
                                9.5F)
                    };

                    Label venue = new Label
                    {
                        Text =
                            $"Venue: {match.Venue}",
                        Location =
                            new Point(300, 82),
                        AutoSize = true,
                        Font =
                            new Font(
                                "Segoe UI",
                                9.5F)
                    };

                    Label status = new Label
                    {
                        Text =
                            match.Status,
                        Location =
                            new Point(700, 20),
                        AutoSize = true,
                        Font =
                            new Font(
                                "Segoe UI",
                                10F,
                                FontStyle.Bold),
                        ForeColor =
                            Color.FromArgb(
                                30, 109, 235)
                    };

                    Label winner = new Label
                    {
                        Text =
                            $"Winner: {match.WinnerName}",
                        Location =
                            new Point(700, 55),
                        AutoSize = true,
                        Font =
                            new Font(
                                "Segoe UI",
                                8.5F)
                    };

                    card.Controls.Add(tournament);
                    card.Controls.Add(teams);
                    card.Controls.Add(date);
                    card.Controls.Add(venue);
                    card.Controls.Add(status);
                    card.Controls.Add(winner);

                    pnlContent.Controls.Add(card);

                    y += 150;
                }
            }
            catch (Exception ex)
            {
                ShowDatabaseError(ex);
            }
        }

        // =====================================================
        // LEADERBOARD
        // =====================================================

        private void btnLeaderboard_Click(
            object? sender,
            EventArgs e)
        {
            SetActiveButton(btnLeaderboard);

            lblPageTitle.Text = "Leaderboard";

            lblWelcome.Text =
                "View tournament rankings and team standings.";

            LoadLeaderboard();
        }

        private void LoadLeaderboard()
        {
            try
            {
                pnlContent.Controls.Clear();

                Label heading =
                    CreateContentTitle(
                        "Tournament Leaderboard");

                pnlContent.Controls.Add(heading);

                var leaderboard =
                    dashboardService.GetLeaderboard();

                if (leaderboard.Count == 0)
                {
                    AddNoDataMessage(
                        "No leaderboard data is available.",
                        20,
                        65);

                    return;
                }

                // Header
                Panel header = new Panel
                {
                    BackColor =
                        Color.FromArgb(30, 109, 235),
                    Location =
                        new Point(20, 65),
                    Size =
                        new Size(860, 45)
                };

                AddHeaderLabel(header, "#", 10, 120);
                AddHeaderLabel(header, "Team", 60, 200);
                AddHeaderLabel(header, "Game", 270, 150);
                AddHeaderLabel(header, "Played", 430, 80);
                AddHeaderLabel(header, "Wins", 515, 70);
                AddHeaderLabel(header, "Loss", 590, 70);
                AddHeaderLabel(header, "Points", 665, 100);

                pnlContent.Controls.Add(header);

                int y = 115;

                foreach (var item in leaderboard)
                {
                    Panel row = new Panel
                    {
                        BackColor = Color.White,
                        Location = new Point(20, y),
                        Size = new Size(860, 45),
                        BorderStyle =
                            BorderStyle.FixedSingle
                    };

                    AddRowLabel(
                        row,
                        item.Position.ToString(),
                        10,
                        120);

                    AddRowLabel(
                        row,
                        item.TeamName,
                        60,
                        200);

                    AddRowLabel(
                        row,
                        item.GameName,
                        270,
                        150);

                    AddRowLabel(
                        row,
                        item.MatchesPlayed.ToString(),
                        430,
                        80);

                    AddRowLabel(
                        row,
                        item.Wins.ToString(),
                        515,
                        70);

                    AddRowLabel(
                        row,
                        item.Losses.ToString(),
                        590,
                        70);

                    AddRowLabel(
                        row,
                        item.Points.ToString(),
                        665,
                        100);

                    pnlContent.Controls.Add(row);

                    y += 48;
                }
            }
            catch (Exception ex)
            {
                ShowDatabaseError(ex);
            }
        }

        // =====================================================
        // PROFILE
        // =====================================================

        private void btnProfile_Click(
            object? sender,
            EventArgs e)
        {
            SetActiveButton(btnProfile);

            lblPageTitle.Text = "My Profile";

            lblWelcome.Text =
                "View your account information.";

            LoadProfile();
        }

        private void LoadProfile()
        {
            pnlContent.Controls.Clear();

            Label heading =
                CreateContentTitle("My Profile");

            pnlContent.Controls.Add(heading);

            Panel card = new Panel
            {
                BackColor = Color.White,
                Location = new Point(20, 65),
                Size = new Size(700, 360),
                BorderStyle =
                    BorderStyle.FixedSingle
            };

            Label profileTitle = new Label
            {
                Text = "Account Information",
                Font = new Font(
                    "Segoe UI",
                    16F,
                    FontStyle.Bold),
                ForeColor =
                    Color.FromArgb(33, 37, 41),
                Location =
                    new Point(30, 25),
                AutoSize = true
            };

            card.Controls.Add(profileTitle);

            AddInfoLabel(
                card,
                "Full Name:",
                currentUser.FullName,
                80);

            AddInfoLabel(
                card,
                "Username:",
                currentUser.Username,
                125);

            AddInfoLabel(
                card,
                "Email:",
                currentUser.Email,
                170);

            AddInfoLabel(
                card,
                "Role:",
                currentUser.Role,
                215);

            AddInfoLabel(
                card,
                "User ID:",
                currentUser.UserID.ToString(),
                260);

            AddInfoLabel(
                card,
                "Account Status:",
                "Active",
                305);

            pnlContent.Controls.Add(card);
        }

        // =====================================================
        // LOGOUT
        // =====================================================

        private void btnLogout_Click(
            object? sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            LoginForm loginForm =
                new LoginForm();

            loginForm.FormClosed +=
                (s, args) => this.Close();

            loginForm.Show();

            this.Hide();
        }

        // =====================================================
        // ACTIVE BUTTON
        // =====================================================

        private void SetActiveButton(Button activeButton)
        {
            Button[] buttons =
            {
                btnDashboard,
                btnTournaments,
                btnMyTeam,
                btnMatches,
                btnLeaderboard,
                btnProfile
            };

            foreach (Button button in buttons)
            {
                button.BackColor = Color.White;
                button.ForeColor =
                    Color.FromArgb(33, 37, 41);
            }

            activeButton.BackColor =
                Color.FromArgb(30, 109, 235);

            activeButton.ForeColor =
                Color.White;
        }

        // =====================================================
        // STAT CARD
        // =====================================================

        private Panel CreateStatCard(
            string icon,
            string title,
            string value,
            string description,
            int x)
        {
            Panel card = new Panel
            {
                BackColor = Color.White,
                Location = new Point(x, 20),
                Size = new Size(205, 150),
                BorderStyle =
                    BorderStyle.FixedSingle
            };

            Label iconLabel = new Label
            {
                Text = icon,
                Font =
                    new Font(
                        "Segoe UI Emoji",
                        25F),
                Location =
                    new Point(15, 15),
                Size =
                    new Size(50, 45),
                TextAlign =
                    ContentAlignment.MiddleCenter
            };

            Label titleLabel = new Label
            {
                Text = title,
                Font =
                    new Font(
                        "Segoe UI",
                        9.5F,
                        FontStyle.Bold),
                Location =
                    new Point(70, 18),
                AutoSize = true
            };

            Label valueLabel = new Label
            {
                Text = value,
                Font =
                    new Font(
                        "Segoe UI",
                        22F,
                        FontStyle.Bold),
                ForeColor =
                    Color.FromArgb(
                        30, 109, 235),
                Location =
                    new Point(15, 68),
                AutoSize = true
            };

            Label descriptionLabel = new Label
            {
                Text = description,
                Font =
                    new Font(
                        "Segoe UI",
                        8.5F),
                ForeColor =
                    Color.FromArgb(
                        108, 117, 125),
                Location =
                    new Point(15, 110),
                AutoSize = true
            };

            card.Controls.Add(iconLabel);
            card.Controls.Add(titleLabel);
            card.Controls.Add(valueLabel);
            card.Controls.Add(descriptionLabel);

            return card;
        }

        // =====================================================
        // CONTENT TITLE
        // =====================================================

        private Label CreateContentTitle(string text)
        {
            return new Label
            {
                Text = text,
                Font =
                    new Font(
                        "Segoe UI",
                        16F,
                        FontStyle.Bold),
                ForeColor =
                    Color.FromArgb(
                        33, 37, 41),
                Location =
                    new Point(20, 20),
                AutoSize = true
            };
        }

        // =====================================================
        // INFO LABEL
        // =====================================================

        private void AddInfoLabel(
            Panel parent,
            string title,
            string value,
            int y)
        {
            Label label = new Label
            {
                Text = title,
                Font =
                    new Font(
                        "Segoe UI",
                        9.5F,
                        FontStyle.Bold),
                ForeColor =
                    Color.FromArgb(
                        73, 80, 87),
                Location =
                    new Point(30, y),
                Size =
                    new Size(140, 25)
            };

            Label valueLabel = new Label
            {
                Text = value,
                Font =
                    new Font(
                        "Segoe UI",
                        9.5F),
                ForeColor =
                    Color.FromArgb(
                        33, 37, 41),
                Location =
                    new Point(175, y),
                Size =
                    new Size(480, 25)
            };

            parent.Controls.Add(label);
            parent.Controls.Add(valueLabel);
        }

        // =====================================================
        // NO DATA MESSAGE
        // =====================================================

        private void AddNoDataMessage(
            string text,
            int x,
            int y)
        {
            Label label = new Label
            {
                Text = text,
                Font =
                    new Font(
                        "Segoe UI",
                        10F),
                ForeColor =
                    Color.FromArgb(
                        108, 117, 125),
                Location =
                    new Point(x, y),
                AutoSize = true
            };

            pnlContent.Controls.Add(label);
        }

        // =====================================================
        // LEADERBOARD HEADER
        // =====================================================

        private void AddHeaderLabel(
            Panel parent,
            string text,
            int x,
            int width)
        {
            Label label = new Label
            {
                Text = text,
                Font =
                    new Font(
                        "Segoe UI",
                        8.5F,
                        FontStyle.Bold),
                ForeColor = Color.White,
                Location =
                    new Point(x, 12),
                Size =
                    new Size(width, 25)
            };

            parent.Controls.Add(label);
        }

        // =====================================================
        // LEADERBOARD ROW
        // =====================================================

        private void AddRowLabel(
            Panel parent,
            string text,
            int x,
            int width)
        {
            Label label = new Label
            {
                Text = text,
                Font =
                    new Font(
                        "Segoe UI",
                        8.5F),
                ForeColor =
                    Color.FromArgb(
                        33, 37, 41),
                Location =
                    new Point(x, 12),
                Size =
                    new Size(width, 25)
            };

            parent.Controls.Add(label);
        }

        // =====================================================
        // DATABASE ERROR
        // =====================================================

        private void ShowDatabaseError(Exception ex)
        {
            MessageBox.Show(
                "Unable to load dashboard data.\n\n" +
                "Error: " + ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}