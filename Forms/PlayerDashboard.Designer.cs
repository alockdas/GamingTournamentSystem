namespace GamingTournamentSystem.Forms
{
    partial class PlayerDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTopHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlProfileWidget = new System.Windows.Forms.Panel();
            this.lblBellIcon = new System.Windows.Forms.Label();
            this.lblPlayerRole = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblAvatar = new System.Windows.Forms.Label();

            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlSidebarHeader = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblPlayerPanelLogo = new System.Windows.Forms.Label();

            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnTournaments = new System.Windows.Forms.Button();
            this.btnMyTeam = new System.Windows.Forms.Button();
            this.btnMatches = new System.Windows.Forms.Button();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            this.pnlMainWorkArea = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();

            this.lblUsernameValue = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();

            this.pnlTopHeader.SuspendLayout();
            this.pnlProfileWidget.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlSidebarHeader.SuspendLayout();
            this.pnlMainWorkArea.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();

            // =====================================================
            // pnlTopHeader
            // =====================================================

            this.pnlTopHeader.BackColor =
                System.Drawing.Color.White;

            this.pnlTopHeader.Controls.Add(
                this.pnlProfileWidget);

            this.pnlTopHeader.Controls.Add(
                this.lblHeaderTitle);

            this.pnlTopHeader.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlTopHeader.Location =
                new System.Drawing.Point(0, 0);

            this.pnlTopHeader.Name =
                "pnlTopHeader";

            this.pnlTopHeader.Size =
                new System.Drawing.Size(1200, 60);

            this.pnlTopHeader.TabIndex = 0;

            // =====================================================
            // lblHeaderTitle
            // =====================================================

            this.lblHeaderTitle.AutoSize = true;

            this.lblHeaderTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    13F,
                    System.Drawing.FontStyle.Bold);

            this.lblHeaderTitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.lblHeaderTitle.Location =
                new System.Drawing.Point(260, 18);

            this.lblHeaderTitle.Name =
                "lblHeaderTitle";

            this.lblHeaderTitle.Text =
                "Gaming Tournament Management System";

            // =====================================================
            // pnlProfileWidget
            // =====================================================

            this.pnlProfileWidget.Controls.Add(
                this.lblBellIcon);

            this.pnlProfileWidget.Controls.Add(
                this.lblPlayerRole);

            this.pnlProfileWidget.Controls.Add(
                this.lblPlayerName);

            this.pnlProfileWidget.Controls.Add(
                this.lblAvatar);

            this.pnlProfileWidget.Dock =
                System.Windows.Forms.DockStyle.Right;

            this.pnlProfileWidget.Location =
                new System.Drawing.Point(920, 0);

            this.pnlProfileWidget.Name =
                "pnlProfileWidget";

            this.pnlProfileWidget.Size =
                new System.Drawing.Size(280, 60);

            // =====================================================
            // lblAvatar
            // =====================================================

            this.lblAvatar.Font =
                new System.Drawing.Font(
                    "Segoe UI Emoji",
                    18F);

            this.lblAvatar.Location =
                new System.Drawing.Point(15, 10);

            this.lblAvatar.Size =
                new System.Drawing.Size(38, 38);

            this.lblAvatar.Text =
                "👤";

            this.lblAvatar.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // =====================================================
            // lblPlayerName
            // =====================================================

            this.lblPlayerName.AutoSize = true;

            this.lblPlayerName.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblPlayerName.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.lblPlayerName.Location =
                new System.Drawing.Point(55, 11);

            this.lblPlayerName.Name =
                "lblPlayerName";

            this.lblPlayerName.Text =
                "Player";

            // =====================================================
            // lblPlayerRole
            // =====================================================

            this.lblPlayerRole.AutoSize = true;

            this.lblPlayerRole.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblPlayerRole.ForeColor =
                System.Drawing.Color.FromArgb(
                    108, 117, 125);

            this.lblPlayerRole.Location =
                new System.Drawing.Point(55, 31);

            this.lblPlayerRole.Name =
                "lblPlayerRole";

            this.lblPlayerRole.Text =
                "Player";

            // =====================================================
            // lblBellIcon
            // =====================================================

            this.lblBellIcon.Font =
                new System.Drawing.Font(
                    "Segoe UI Emoji",
                    14F);

            this.lblBellIcon.Location =
                new System.Drawing.Point(235, 15);

            this.lblBellIcon.Size =
                new System.Drawing.Size(30, 30);

            this.lblBellIcon.Text =
                "🔔";

            // =====================================================
            // pnlSidebar
            // =====================================================

            this.pnlSidebar.BackColor =
                System.Drawing.Color.White;

            this.pnlSidebar.Controls.Add(
                this.btnLogout);

            this.pnlSidebar.Controls.Add(
                this.btnProfile);

            this.pnlSidebar.Controls.Add(
                this.btnLeaderboard);

            this.pnlSidebar.Controls.Add(
                this.btnMatches);

            this.pnlSidebar.Controls.Add(
                this.btnMyTeam);

            this.pnlSidebar.Controls.Add(
                this.btnTournaments);

            this.pnlSidebar.Controls.Add(
                this.btnDashboard);

            this.pnlSidebar.Controls.Add(
                this.pnlSidebarHeader);

            this.pnlSidebar.Dock =
                System.Windows.Forms.DockStyle.Left;

            this.pnlSidebar.Location =
                new System.Drawing.Point(0, 60);

            this.pnlSidebar.Name =
                "pnlSidebar";

            this.pnlSidebar.Size =
                new System.Drawing.Size(240, 640);

            // =====================================================
            // pnlSidebarHeader
            // =====================================================

            this.pnlSidebarHeader.Controls.Add(
                this.lblLogo);

            this.pnlSidebarHeader.Controls.Add(
                this.lblPlayerPanelLogo);

            this.pnlSidebarHeader.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlSidebarHeader.Size =
                new System.Drawing.Size(240, 80);

            // =====================================================
            // lblLogo
            // =====================================================

            this.lblLogo.Font =
                new System.Drawing.Font(
                    "Segoe UI Emoji",
                    22F);

            this.lblLogo.ForeColor =
                System.Drawing.Color.FromArgb(
                    30, 109, 235);

            this.lblLogo.Location =
                new System.Drawing.Point(95, 5);

            this.lblLogo.Size =
                new System.Drawing.Size(50, 40);

            this.lblLogo.Text =
                "🎮";

            this.lblLogo.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // =====================================================
            // lblPlayerPanelLogo
            // =====================================================

            this.lblPlayerPanelLogo.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    11F,
                    System.Drawing.FontStyle.Bold);

            this.lblPlayerPanelLogo.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.lblPlayerPanelLogo.Location =
                new System.Drawing.Point(10, 48);

            this.lblPlayerPanelLogo.Size =
                new System.Drawing.Size(220, 25);

            this.lblPlayerPanelLogo.Text =
                "PLAYER PANEL";

            this.lblPlayerPanelLogo.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // =====================================================
            // NAV BUTTON COMMON STYLE
            // =====================================================

            SetupNavButton(
                this.btnDashboard,
                "📊  Dashboard",
                90);

            SetupNavButton(
                this.btnTournaments,
                "🏆  Tournaments",
                140);

            SetupNavButton(
                this.btnMyTeam,
                "👥  My Team",
                190);

            SetupNavButton(
                this.btnMatches,
                "⚔️  My Matches",
                240);

            SetupNavButton(
                this.btnLeaderboard,
                "📈  Leaderboard",
                290);

            SetupNavButton(
                this.btnProfile,
                "👤  My Profile",
                340);

            // =====================================================
            // Active Dashboard Button
            // =====================================================

            this.btnDashboard.BackColor =
                System.Drawing.Color.FromArgb(
                    30, 109, 235);

            this.btnDashboard.ForeColor =
                System.Drawing.Color.White;

            // =====================================================
            // Logout
            // =====================================================

            this.btnLogout.BackColor =
                System.Drawing.Color.White;

            this.btnLogout.FlatAppearance.BorderColor =
                System.Drawing.Color.LightGray;

            this.btnLogout.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnLogout.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.btnLogout.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.btnLogout.Location =
                new System.Drawing.Point(15, 575);

            this.btnLogout.Size =
                new System.Drawing.Size(210, 44);

            this.btnLogout.Text =
                "🚪  Logout";

            this.btnLogout.UseVisualStyleBackColor =
                false;

            this.btnLogout.Click +=
                new System.EventHandler(
                    this.btnLogout_Click);

            // =====================================================
            // pnlMainWorkArea
            // =====================================================

            this.pnlMainWorkArea.BackColor =
                System.Drawing.Color.FromArgb(
                    244, 246, 249);

            this.pnlMainWorkArea.Controls.Add(
                this.lblFooter);

            this.pnlMainWorkArea.Controls.Add(
                this.pnlContent);

            this.pnlMainWorkArea.Controls.Add(
                this.pnlTitleBar);

            this.pnlMainWorkArea.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.pnlMainWorkArea.Padding =
                new System.Windows.Forms.Padding(15);

            this.pnlMainWorkArea.Location =
                new System.Drawing.Point(240, 60);

            this.pnlMainWorkArea.Size =
                new System.Drawing.Size(960, 640);

            // =====================================================
            // pnlTitleBar
            // =====================================================

            this.pnlTitleBar.Controls.Add(
                this.lblCurrentDate);

            this.pnlTitleBar.Controls.Add(
                this.lblWelcome);

            this.pnlTitleBar.Controls.Add(
                this.lblPageTitle);

            this.pnlTitleBar.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlTitleBar.Location =
                new System.Drawing.Point(15, 15);

            this.pnlTitleBar.Size =
                new System.Drawing.Size(930, 75);

            // =====================================================
            // lblPageTitle
            // =====================================================

            this.lblPageTitle.AutoSize = true;

            this.lblPageTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Bold);

            this.lblPageTitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.lblPageTitle.Location =
                new System.Drawing.Point(0, 0);

            this.lblPageTitle.Text =
                "Dashboard";

            // =====================================================
            // lblWelcome
            // =====================================================

            this.lblWelcome.AutoSize = true;

            this.lblWelcome.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9.5F);

            this.lblWelcome.ForeColor =
                System.Drawing.Color.FromArgb(
                    108, 117, 125);

            this.lblWelcome.Location =
                new System.Drawing.Point(3, 42);

            this.lblWelcome.Text =
                "Welcome back, Player.";

            // =====================================================
            // lblCurrentDate
            // =====================================================

            this.lblCurrentDate.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.lblCurrentDate.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    11F,
                    System.Drawing.FontStyle.Bold);

            this.lblCurrentDate.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.lblCurrentDate.Location =
                new System.Drawing.Point(680, 10);

            this.lblCurrentDate.Size =
                new System.Drawing.Size(250, 30);

            this.lblCurrentDate.Text =
                "August 22, 2026";

            this.lblCurrentDate.TextAlign =
                System.Drawing.ContentAlignment.TopRight;

            // =====================================================
            // pnlContent
            // =====================================================

            this.pnlContent.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.pnlContent.BackColor =
                System.Drawing.Color.Transparent;

            this.pnlContent.Location =
                new System.Drawing.Point(15, 95);

            this.pnlContent.Name =
                "pnlContent";

            this.pnlContent.Size =
                new System.Drawing.Size(930, 490);

            // =====================================================
            // lblFooter
            // =====================================================

            this.lblFooter.Dock =
                System.Windows.Forms.DockStyle.Bottom;

            this.lblFooter.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblFooter.ForeColor =
                System.Drawing.Color.FromArgb(
                    108, 117, 125);

            this.lblFooter.Height = 25;

            this.lblFooter.Text =
                "© 2026 Gaming Tournament Management System";

            // =====================================================
            // Hidden data labels
            // =====================================================

            this.lblUsernameValue.Visible = false;
            this.lblEmailValue.Visible = false;

            // =====================================================
            // PlayerDashboard
            // =====================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1200, 700);

            this.Controls.Add(
                this.pnlMainWorkArea);

            this.Controls.Add(
                this.pnlSidebar);

            this.Controls.Add(
                this.pnlTopHeader);

            this.MinimumSize =
                new System.Drawing.Size(1100, 650);

            this.Name =
                "PlayerDashboard";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Gaming Tournament Management System - Player Dashboard";

            this.Load +=
                new System.EventHandler(
                    this.PlayerDashboard_Load);

            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();

            this.pnlProfileWidget.ResumeLayout(false);
            this.pnlProfileWidget.PerformLayout();

            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebarHeader.ResumeLayout(false);

            this.pnlMainWorkArea.ResumeLayout(false);

            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();

            this.ResumeLayout(false);
        }

        // =====================================================
        // NAV BUTTON SETUP
        // =====================================================

        private void SetupNavButton(
            System.Windows.Forms.Button button,
            string text,
            int top)
        {
            button.BackColor =
                System.Drawing.Color.White;

            button.FlatAppearance.BorderSize = 0;

            button.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            button.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            button.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            button.Location =
                new System.Drawing.Point(15, top);

            button.Size =
                new System.Drawing.Size(210, 42);

            button.Text =
                text;

            button.UseVisualStyleBackColor =
                false;
        }

        // =====================================================
        // DECLARATIONS
        // =====================================================

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderTitle;

        private System.Windows.Forms.Panel pnlProfileWidget;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerRole;
        private System.Windows.Forms.Label lblBellIcon;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlSidebarHeader;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblPlayerPanelLogo;

        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnTournaments;
        private System.Windows.Forms.Button btnMyTeam;
        private System.Windows.Forms.Button btnMatches;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel pnlMainWorkArea;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblCurrentDate;

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblFooter;

        private System.Windows.Forms.Label lblUsernameValue;
        private System.Windows.Forms.Label lblEmailValue;
    }
}