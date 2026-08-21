namespace GamingTournamentSystem.Forms
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;

        // =========================
        // Dispose
        // =========================
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // =========================
        // InitializeComponent
        // =========================
        private void InitializeComponent()
        {
            this.pnlTopHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlProfileWidget = new System.Windows.Forms.Panel();
            this.lblBellIcon = new System.Windows.Forms.Label();
            this.lblAdminRole = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblAvatar = new System.Windows.Forms.Label();

            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlSidebarHeader = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblAdminPanelLogo = new System.Windows.Forms.Label();

            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavTournament = new System.Windows.Forms.Button();
            this.btnNavTeam = new System.Windows.Forms.Button();
            this.btnNavPlayer = new System.Windows.Forms.Button();
            this.btnNavMatch = new System.Windows.Forms.Button();
            this.btnNavLeaderboard = new System.Windows.Forms.Button();
            this.btnNavReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            this.pnlMainWorkArea = new System.Windows.Forms.Panel();
            this.pnlDashboardTitleBar = new System.Windows.Forms.Panel();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblWelcomeSub = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();

            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();

            // Suspend
            this.pnlTopHeader.SuspendLayout();
            this.pnlProfileWidget.SuspendLayout();

            this.pnlSidebar.SuspendLayout();
            this.pnlSidebarHeader.SuspendLayout();

            this.pnlMainWorkArea.SuspendLayout();
            this.pnlDashboardTitleBar.SuspendLayout();

            this.SuspendLayout();

            // =========================================================
            // pnlTopHeader
            // =========================================================
            this.pnlTopHeader.BackColor = System.Drawing.Color.White;
            this.pnlTopHeader.Controls.Add(this.pnlProfileWidget);
            this.pnlTopHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlTopHeader.Name = "pnlTopHeader";
            this.pnlTopHeader.Size = new System.Drawing.Size(1200, 60);
            this.pnlTopHeader.TabIndex = 0;

            // =========================================================
            // lblHeaderTitle
            // =========================================================
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    13F,
                    System.Drawing.FontStyle.Bold);

            this.lblHeaderTitle.ForeColor =
                System.Drawing.Color.FromArgb(33, 37, 41);

            this.lblHeaderTitle.Location =
                new System.Drawing.Point(260, 18);

            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size =
                new System.Drawing.Size(359, 25);

            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text =
                "Gaming Tournament Management System";

            // =========================================================
            // pnlProfileWidget
            // =========================================================
            this.pnlProfileWidget.Controls.Add(this.lblBellIcon);
            this.pnlProfileWidget.Controls.Add(this.lblAdminRole);
            this.pnlProfileWidget.Controls.Add(this.lblAdminName);
            this.pnlProfileWidget.Controls.Add(this.lblAvatar);

            this.pnlProfileWidget.Dock =
                System.Windows.Forms.DockStyle.Right;

            this.pnlProfileWidget.Location =
                new System.Drawing.Point(920, 0);

            this.pnlProfileWidget.Name = "pnlProfileWidget";

            this.pnlProfileWidget.Size =
                new System.Drawing.Size(280, 60);

            this.pnlProfileWidget.TabIndex = 1;

            // =========================================================
            // lblAvatar
            // =========================================================
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.Font =
                new System.Drawing.Font("Segoe UI Emoji", 18F);

            this.lblAvatar.Location =
                new System.Drawing.Point(15, 12);

            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size =
                new System.Drawing.Size(38, 32);

            this.lblAvatar.TabIndex = 0;
            this.lblAvatar.Text = "👤";

            // =========================================================
            // lblAdminName
            // =========================================================
            this.lblAdminName.AutoSize = true;

            this.lblAdminName.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblAdminName.ForeColor =
                System.Drawing.Color.FromArgb(33, 37, 41);

            this.lblAdminName.Location =
                new System.Drawing.Point(55, 12);

            this.lblAdminName.Name = "lblAdminName";

            this.lblAdminName.Size =
                new System.Drawing.Size(142, 17);

            this.lblAdminName.TabIndex = 1;
            this.lblAdminName.Text = "System Administrator";

            // =========================================================
            // lblAdminRole
            // =========================================================
            this.lblAdminRole.AutoSize = true;

            this.lblAdminRole.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblAdminRole.ForeColor =
                System.Drawing.Color.FromArgb(108, 117, 125);

            this.lblAdminRole.Location =
                new System.Drawing.Point(55, 31);

            this.lblAdminRole.Name = "lblAdminRole";

            this.lblAdminRole.Size =
                new System.Drawing.Size(42, 15);

            this.lblAdminRole.TabIndex = 2;
            this.lblAdminRole.Text = "Admin";

            // =========================================================
            // lblBellIcon
            // =========================================================
            this.lblBellIcon.AutoSize = true;

            this.lblBellIcon.Font =
                new System.Drawing.Font(
                    "Segoe UI Emoji",
                    14F);

            this.lblBellIcon.Location =
                new System.Drawing.Point(235, 16);

            this.lblBellIcon.Name = "lblBellIcon";

            this.lblBellIcon.Size =
                new System.Drawing.Size(29, 25);

            this.lblBellIcon.TabIndex = 3;
            this.lblBellIcon.Text = "🔔";

            // =========================================================
            // pnlSidebar
            // =========================================================
            this.pnlSidebar.BackColor =
                System.Drawing.Color.White;

            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnNavReports);
            this.pnlSidebar.Controls.Add(this.btnNavLeaderboard);
            this.pnlSidebar.Controls.Add(this.btnNavMatch);
            this.pnlSidebar.Controls.Add(this.btnNavPlayer);
            this.pnlSidebar.Controls.Add(this.btnNavTeam);
            this.pnlSidebar.Controls.Add(this.btnNavTournament);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.pnlSidebarHeader);

            this.pnlSidebar.Dock =
                System.Windows.Forms.DockStyle.Left;

            this.pnlSidebar.Location =
                new System.Drawing.Point(0, 60);

            this.pnlSidebar.Name = "pnlSidebar";

            this.pnlSidebar.Size =
                new System.Drawing.Size(240, 640);

            this.pnlSidebar.TabIndex = 1;

            // =========================================================
            // pnlSidebarHeader
            // =========================================================
            this.pnlSidebarHeader.Controls.Add(this.lblLogo);
            this.pnlSidebarHeader.Controls.Add(this.lblAdminPanelLogo);

            this.pnlSidebarHeader.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlSidebarHeader.Location =
                new System.Drawing.Point(0, 0);

            this.pnlSidebarHeader.Name =
                "pnlSidebarHeader";

            this.pnlSidebarHeader.Size =
                new System.Drawing.Size(240, 80);

            this.pnlSidebarHeader.TabIndex = 0;

            // =========================================================
            // lblLogo
            // =========================================================
            this.lblLogo.Font =
                new System.Drawing.Font(
                    "Segoe UI Emoji",
                    22F);

            this.lblLogo.ForeColor =
                System.Drawing.Color.FromArgb(30, 109, 235);

            this.lblLogo.Location =
                new System.Drawing.Point(95, 5);

            this.lblLogo.Name = "lblLogo";

            this.lblLogo.Size =
                new System.Drawing.Size(50, 40);

            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "🎮";
            this.lblLogo.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // =========================================================
            // lblAdminPanelLogo
            // =========================================================
            this.lblAdminPanelLogo.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    11F,
                    System.Drawing.FontStyle.Bold);

            this.lblAdminPanelLogo.ForeColor =
                System.Drawing.Color.FromArgb(33, 37, 41);

            this.lblAdminPanelLogo.Location =
                new System.Drawing.Point(10, 48);

            this.lblAdminPanelLogo.Name =
                "lblAdminPanelLogo";

            this.lblAdminPanelLogo.Size =
                new System.Drawing.Size(220, 25);

            this.lblAdminPanelLogo.TabIndex = 0;
            this.lblAdminPanelLogo.Text = "ADMIN PANEL";

            this.lblAdminPanelLogo.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // =========================================================
            // Dashboard Button
            // =========================================================
            ConfigureNavigationButton(
                this.btnNavDashboard,
                "📊  Dashboard",
                90,
                true);

            this.btnNavDashboard.Click +=
                new System.EventHandler(this.btnNavDashboard_Click);

            // =========================================================
            // Tournament Button
            // =========================================================
            ConfigureNavigationButton(
                this.btnNavTournament,
                "🏆  Tournament Management",
                140,
                false);

            this.btnNavTournament.Click +=
                new System.EventHandler(this.btnNavTournament_Click);

            // =========================================================
            // Team Button
            // =========================================================
            ConfigureNavigationButton(
                this.btnNavTeam,
                "👥  Team Management",
                190,
                false);

            this.btnNavTeam.Click +=
                new System.EventHandler(this.btnNavTeam_Click);

            // =========================================================
            // Player Button
            // =========================================================
            ConfigureNavigationButton(
                this.btnNavPlayer,
                "🎮  Player Management",
                240,
                false);

            this.btnNavPlayer.Click +=
                new System.EventHandler(this.btnNavPlayer_Click);

            // =========================================================
            // Match Button
            // =========================================================
            ConfigureNavigationButton(
                this.btnNavMatch,
                "⚔️  Match Management",
                290,
                false);

            this.btnNavMatch.Click +=
                new System.EventHandler(this.btnNavMatch_Click);

            // =========================================================
            // Leaderboard Button
            // =========================================================
            ConfigureNavigationButton(
                this.btnNavLeaderboard,
                "📈  Leaderboard",
                340,
                false);

            this.btnNavLeaderboard.Click +=
                new System.EventHandler(this.btnNavLeaderboard_Click);

            // =========================================================
            // Reports Button
            // =========================================================
            ConfigureNavigationButton(
                this.btnNavReports,
                "📄  Reports",
                390,
                false);

            this.btnNavReports.Click +=
                new System.EventHandler(this.btnNavReports_Click);

            // =========================================================
            // Logout Button
            // =========================================================
            this.btnLogout.BackColor =
                System.Drawing.Color.White;

            this.btnLogout.FlatAppearance.BorderColor =
                System.Drawing.Color.LightGray;

            this.btnLogout.FlatAppearance.BorderSize = 1;

            this.btnLogout.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnLogout.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.btnLogout.ForeColor =
                System.Drawing.Color.FromArgb(33, 37, 41);

            this.btnLogout.Location =
                new System.Drawing.Point(15, 575);

            this.btnLogout.Name =
                "btnLogout";

            this.btnLogout.Size =
                new System.Drawing.Size(210, 44);

            this.btnLogout.TabIndex = 7;

            this.btnLogout.Text =
                "🚪  Logout";

            this.btnLogout.UseVisualStyleBackColor =
                false;

            this.btnLogout.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnLogout.Click +=
                new System.EventHandler(this.btnLogout_Click);

            // =========================================================
            // pnlMainWorkArea
            // =========================================================
            this.pnlMainWorkArea.BackColor =
                System.Drawing.Color.FromArgb(244, 246, 249);

            this.pnlMainWorkArea.Controls.Add(this.lblFooter);
            this.pnlMainWorkArea.Controls.Add(this.pnlMainContent);
            this.pnlMainWorkArea.Controls.Add(this.pnlDashboardTitleBar);

            this.pnlMainWorkArea.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.pnlMainWorkArea.Location =
                new System.Drawing.Point(240, 60);

            this.pnlMainWorkArea.Name =
                "pnlMainWorkArea";

            this.pnlMainWorkArea.Padding =
                new System.Windows.Forms.Padding(15);

            this.pnlMainWorkArea.Size =
                new System.Drawing.Size(960, 640);

            this.pnlMainWorkArea.TabIndex = 2;

            // =========================================================
            // pnlDashboardTitleBar
            // =========================================================
            this.pnlDashboardTitleBar.Controls.Add(this.lblCurrentDate);
            this.pnlDashboardTitleBar.Controls.Add(this.lblWelcomeSub);
            this.pnlDashboardTitleBar.Controls.Add(this.lblPageTitle);

            this.pnlDashboardTitleBar.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlDashboardTitleBar.Location =
                new System.Drawing.Point(15, 15);

            this.pnlDashboardTitleBar.Name =
                "pnlDashboardTitleBar";

            this.pnlDashboardTitleBar.Size =
                new System.Drawing.Size(930, 65);

            this.pnlDashboardTitleBar.TabIndex = 0;

            // =========================================================
            // lblPageTitle
            // =========================================================
            this.lblPageTitle.AutoSize = true;

            this.lblPageTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Bold);

            this.lblPageTitle.ForeColor =
                System.Drawing.Color.FromArgb(33, 37, 41);

            this.lblPageTitle.Location =
                new System.Drawing.Point(0, 0);

            this.lblPageTitle.Name =
                "lblPageTitle";

            this.lblPageTitle.Size =
                new System.Drawing.Size(155, 37);

            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text =
                "Dashboard";

            // =========================================================
            // lblWelcomeSub
            // =========================================================
            this.lblWelcomeSub.AutoSize = true;

            this.lblWelcomeSub.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9.5F);

            this.lblWelcomeSub.ForeColor =
                System.Drawing.Color.FromArgb(108, 117, 125);

            this.lblWelcomeSub.Location =
                new System.Drawing.Point(3, 40);

            this.lblWelcomeSub.Name =
                "lblWelcomeSub";

            this.lblWelcomeSub.Size =
                new System.Drawing.Size(232, 17);

            this.lblWelcomeSub.TabIndex = 1;

            this.lblWelcomeSub.Text =
                "Welcome back, System Administrator.";

            // =========================================================
            // lblCurrentDate
            // =========================================================
            this.lblCurrentDate.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.lblCurrentDate.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    11F,
                    System.Drawing.FontStyle.Bold);

            this.lblCurrentDate.ForeColor =
                System.Drawing.Color.FromArgb(33, 37, 41);

            this.lblCurrentDate.Location =
                new System.Drawing.Point(680, 10);

            this.lblCurrentDate.Name =
                "lblCurrentDate";

            this.lblCurrentDate.Size =
                new System.Drawing.Size(250, 30);

            this.lblCurrentDate.TabIndex = 2;

            this.lblCurrentDate.Text =
                "August 21, 2026";

            this.lblCurrentDate.TextAlign =
                System.Drawing.ContentAlignment.TopRight;

            // =========================================================
            // pnlMainContent
            // =========================================================
            this.pnlMainContent.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.pnlMainContent.BackColor =
                System.Drawing.Color.Transparent;

            this.pnlMainContent.Location =
                new System.Drawing.Point(15, 90);

            this.pnlMainContent.Name =
                "pnlMainContent";

            this.pnlMainContent.Size =
                new System.Drawing.Size(930, 500);

            this.pnlMainContent.TabIndex = 1;

            // =========================================================
            // lblFooter
            // =========================================================
            this.lblFooter.Dock =
                System.Windows.Forms.DockStyle.Bottom;

            this.lblFooter.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblFooter.ForeColor =
                System.Drawing.Color.FromArgb(108, 117, 125);

            this.lblFooter.Location =
                new System.Drawing.Point(15, 600);

            this.lblFooter.Name =
                "lblFooter";

            this.lblFooter.Size =
                new System.Drawing.Size(930, 25);

            this.lblFooter.TabIndex = 2;

            this.lblFooter.Text =
                "© 2026 Gaming Tournament Management System";

            // =========================================================
            // AdminDashboard
            // =========================================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1200, 700);

            this.Controls.Add(this.pnlMainWorkArea);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlTopHeader);

            this.MinimumSize =
                new System.Drawing.Size(1100, 650);

            this.Name =
                "AdminDashboard";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Gaming Tournament Management System - Admin Dashboard";

            this.Load +=
                new System.EventHandler(this.AdminDashboard_Load);

            // Resume
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();

            this.pnlProfileWidget.ResumeLayout(false);
            this.pnlProfileWidget.PerformLayout();

            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebarHeader.ResumeLayout(false);

            this.pnlMainWorkArea.ResumeLayout(false);
            this.pnlDashboardTitleBar.ResumeLayout(false);
            this.pnlDashboardTitleBar.PerformLayout();

            this.ResumeLayout(false);
        }

        // =========================================================
        // Helper Method for Navigation Buttons
        // =========================================================
        private void ConfigureNavigationButton(
            System.Windows.Forms.Button button,
            string text,
            int top,
            bool selected)
        {
            button.BackColor = selected
                ? System.Drawing.Color.FromArgb(30, 109, 235)
                : System.Drawing.Color.White;

            button.FlatAppearance.BorderSize = 0;

            button.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            button.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            button.ForeColor = selected
                ? System.Drawing.Color.White
                : System.Drawing.Color.FromArgb(33, 37, 41);

            button.Location =
                new System.Drawing.Point(15, top);

            button.Name = text
                .Replace("📊", "btnNavDashboard")
                .Replace("🏆", "btnNavTournament")
                .Replace("👥", "btnNavTeam")
                .Replace("🎮", "btnNavPlayer")
                .Replace("⚔️", "btnNavMatch")
                .Replace("📈", "btnNavLeaderboard")
                .Replace("📄", "btnNavReports")
                .Trim();

            button.Size =
                new System.Drawing.Size(210, 42);

            button.TabIndex = top / 50;

            button.Text = text;

            button.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            button.Padding =
                new System.Windows.Forms.Padding(12, 0, 5, 0);

            button.UseVisualStyleBackColor = false;

            button.Cursor =
                System.Windows.Forms.Cursors.Hand;
        }

        // =========================================================
        // Fields
        // =========================================================

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderTitle;

        private System.Windows.Forms.Panel pnlProfileWidget;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblAdminRole;
        private System.Windows.Forms.Label lblBellIcon;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlSidebarHeader;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblAdminPanelLogo;

        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavTournament;
        private System.Windows.Forms.Button btnNavTeam;
        private System.Windows.Forms.Button btnNavPlayer;
        private System.Windows.Forms.Button btnNavMatch;
        private System.Windows.Forms.Button btnNavLeaderboard;
        private System.Windows.Forms.Button btnNavReports;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel pnlMainWorkArea;
        private System.Windows.Forms.Panel pnlDashboardTitleBar;

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblWelcomeSub;
        private System.Windows.Forms.Label lblCurrentDate;

        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Label lblFooter;
    }
}