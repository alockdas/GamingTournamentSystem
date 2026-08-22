using System;
using System.Drawing;
using System.Windows.Forms;
using GamingTournamentSystem.Models;

namespace GamingTournamentSystem.Forms
{
    public partial class AdminDashboard : Form
    {
        private readonly User currentUser;

        // =========================================================
        // Constructor
        // =========================================================
        public AdminDashboard(User user)
        {
            InitializeComponent();

            currentUser = user;

            LoadUserInformation();
        }

        // =========================================================
        // Load User Information
        // =========================================================
        private void LoadUserInformation()
        {
            if (currentUser != null)
            {
                lblAdminName.Text = currentUser.FullName;
                lblAdminRole.Text = currentUser.Role;

                lblWelcomeSub.Text =
                    $"Welcome back, {currentUser.FullName}.";
            }

            lblCurrentDate.Text =
                DateTime.Now.ToString("MMMM dd, yyyy");
        }

        // =========================================================
        // Form Load
        // =========================================================
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        // =========================================================
        // Dashboard
        // =========================================================
        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            SetSelectedButton(btnNavDashboard);

            ShowDashboard();
        }

        private void ShowDashboard()
        {
            lblPageTitle.Text = "Dashboard";

            if (currentUser != null)
            {
                lblWelcomeSub.Text =
                    $"Welcome back, {currentUser.FullName}.";
            }
            else
            {
                lblWelcomeSub.Text =
                    "Welcome back, System Administrator.";
            }

            lblCurrentDate.Text =
                DateTime.Now.ToString("MMMM dd, yyyy");

            pnlMainContent.Controls.Clear();

            // =====================================================
            // Dashboard Cards
            // =====================================================

            Panel cardTournaments =
                CreateDashboardCard(
                    "🏆",
                    "Tournaments",
                    "Manage gaming tournaments",
                    new Point(0, 0));

            Panel cardTeams =
                CreateDashboardCard(
                    "👥",
                    "Teams",
                    "Manage registered teams",
                    new Point(300, 0));

            Panel cardPlayers =
                CreateDashboardCard(
                    "🎮",
                    "Players",
                    "Manage tournament players",
                    new Point(600, 0));

            Panel cardMatches =
                CreateDashboardCard(
                    "⚔️",
                    "Matches",
                    "Manage tournament matches",
                    new Point(0, 160));

            Panel cardLeaderboard =
                CreateDashboardCard(
                    "📈",
                    "Leaderboard",
                    "View tournament rankings",
                    new Point(300, 160));

            Panel cardReports =
                CreateDashboardCard(
                    "📄",
                    "Reports",
                    "Generate system reports",
                    new Point(600, 160));

            pnlMainContent.Controls.Add(cardTournaments);
            pnlMainContent.Controls.Add(cardTeams);
            pnlMainContent.Controls.Add(cardPlayers);
            pnlMainContent.Controls.Add(cardMatches);
            pnlMainContent.Controls.Add(cardLeaderboard);
            pnlMainContent.Controls.Add(cardReports);
        }

        // =========================================================
        // Create Dashboard Card
        // =========================================================
        private Panel CreateDashboardCard(
            string icon,
            string title,
            string description,
            Point location)
        {
            Panel card = new Panel();

            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;

            card.Location = location;
            card.Size = new Size(270, 135);

            // -----------------------------------------------------
            // Icon
            // -----------------------------------------------------
            Label lblIcon = new Label();

            lblIcon.AutoSize = false;
            lblIcon.Font =
                new Font("Segoe UI Emoji", 25F);

            lblIcon.Location =
                new Point(15, 15);

            lblIcon.Size =
                new Size(55, 50);

            lblIcon.Text = icon;
            lblIcon.TextAlign =
                ContentAlignment.MiddleCenter;

            // -----------------------------------------------------
            // Title
            // -----------------------------------------------------
            Label lblTitle = new Label();

            lblTitle.AutoSize = false;

            lblTitle.Font =
                new Font(
                    "Segoe UI Semibold",
                    12F,
                    FontStyle.Bold);

            lblTitle.ForeColor =
                Color.FromArgb(33, 37, 41);

            lblTitle.Location =
                new Point(80, 18);

            lblTitle.Size =
                new Size(175, 30);

            lblTitle.Text = title;

            // -----------------------------------------------------
            // Description
            // -----------------------------------------------------
            Label lblDescription = new Label();

            lblDescription.AutoSize = false;

            lblDescription.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Regular);

            lblDescription.ForeColor =
                Color.FromArgb(108, 117, 125);

            lblDescription.Location =
                new Point(80, 50);

            lblDescription.Size =
                new Size(175, 55);

            lblDescription.Text = description;

            // -----------------------------------------------------
            // Add controls
            // -----------------------------------------------------
            card.Controls.Add(lblIcon);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblDescription);

            return card;
        }

        // =========================================================
        // Tournament Management
        // =========================================================
        private void btnNavTournament_Click(object sender, EventArgs e)
        {
            try
            {
                SetSelectedButton(btnNavTournament);

                TournamentForm tournamentForm =
                    new TournamentForm(this);

                tournamentForm.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Tournament Management could not be opened.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // Team Management
        // =========================================================
        private void btnNavTeam_Click(object sender, EventArgs e)
        {
            SetSelectedButton(btnNavTeam);

            TeamForm teamForm =
                new TeamForm(this);

            teamForm.Show();

            this.Hide();
        }

        // =========================================================
        // Player Management
        // =========================================================
        // =========================================================
// Player Management
// =========================================================
private void btnNavPlayer_Click(object sender, EventArgs e)
{
    try
    {
        SetSelectedButton(btnNavPlayer);

        PlayerForm playerForm =
            new PlayerForm(this);

        playerForm.Show();

        this.Hide();
    }
    catch (Exception ex)
    {
        MessageBox.Show(
            "Player Management could not be opened.\n\n" +
            ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }
}

        // =========================================================
        // Match Management
        // =========================================================
        private void btnNavMatch_Click(object sender, EventArgs e)
        {
            try
            {
                SetSelectedButton(btnNavMatch);

                MatchForm matchForm =
                    new MatchForm(this);

                matchForm.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Match Management could not be opened.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // Leaderboard
        // =========================================================
        private void btnNavLeaderboard_Click(object sender, EventArgs e)
        {
            try
            {
                SetSelectedButton(btnNavLeaderboard);

                LeaderboardForm leaderboardForm =
                    new LeaderboardForm(this);

                leaderboardForm.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Leaderboard could not be opened.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // Reports
        // =========================================================
        private void btnNavReports_Click(object sender, EventArgs e)
        {
            try
            {
                SetSelectedButton(btnNavReports);

                ReportsForm reportsForm =
                    new ReportsForm(this);

                reportsForm.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Reports Management could not be opened.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // Create Page Message
        // =========================================================
        private Label CreatePageMessage(
            string title,
            string message)
        {
            Label label = new Label();

            label.AutoSize = false;

            label.BackColor = Color.White;

            label.BorderStyle =
                BorderStyle.FixedSingle;

            label.Font =
                new Font(
                    "Segoe UI",
                    14F,
                    FontStyle.Bold);

            label.ForeColor =
                Color.FromArgb(33, 37, 41);

            label.Location =
                new Point(0, 0);

            label.Size =
                new Size(900, 150);

            label.Text =
                $"{title}\n\n{message}";

            label.TextAlign =
                ContentAlignment.MiddleCenter;

            return label;
        }

        // =========================================================
        // Selected Navigation Button
        // =========================================================
        private void SetSelectedButton(Button selectedButton)
        {
            // -----------------------------------------------------
            // Reset all buttons
            // -----------------------------------------------------

            Button[] buttons =
            {
                btnNavDashboard,
                btnNavTournament,
                btnNavTeam,
                btnNavPlayer,
                btnNavMatch,
                btnNavLeaderboard,
                btnNavReports
            };

            foreach (Button button in buttons)
            {
                button.BackColor = Color.White;

                button.ForeColor =
                    Color.FromArgb(33, 37, 41);
            }

            // -----------------------------------------------------
            // Select current button
            // -----------------------------------------------------

            selectedButton.BackColor =
                Color.FromArgb(30, 109, 235);

            selectedButton.ForeColor =
                Color.White;
        }

        // =========================================================
        // Logout
        // =========================================================
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
    }
}