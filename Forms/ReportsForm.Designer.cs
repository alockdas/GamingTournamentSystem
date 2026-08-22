namespace GamingTournamentSystem.Forms
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        // =========================================================
        // Dispose
        // =========================================================
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // =========================================================
        // InitializeComponent
        // =========================================================
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
            this.lblReportsLogo = new System.Windows.Forms.Label();

            this.btnTournamentReport = new System.Windows.Forms.Button();
            this.btnTeamReport = new System.Windows.Forms.Button();
            this.btnPlayerReport = new System.Windows.Forms.Button();
            this.btnMatchReport = new System.Windows.Forms.Button();
            this.btnLeaderboardReport = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.pnlMainWorkArea = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();

            this.pnlReportContent = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();

            // =====================================================
            // Suspend Layout
            // =====================================================
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
                    33,
                    37,
                    41);

            this.lblHeaderTitle.Location =
                new System.Drawing.Point(260, 18);

            this.lblHeaderTitle.Name =
                "lblHeaderTitle";

            this.lblHeaderTitle.Size =
                new System.Drawing.Size(359, 25);

            this.lblHeaderTitle.TabIndex = 0;

            this.lblHeaderTitle.Text =
                "Gaming Tournament Management System";

            // =====================================================
            // pnlProfileWidget
            // =====================================================
            this.pnlProfileWidget.Controls.Add(
                this.lblBellIcon);

            this.pnlProfileWidget.Controls.Add(
                this.lblAdminRole);

            this.pnlProfileWidget.Controls.Add(
                this.lblAdminName);

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

            this.pnlProfileWidget.TabIndex = 1;

            // =====================================================
            // lblAvatar
            // =====================================================
            this.lblAvatar.AutoSize = true;

            this.lblAvatar.Font =
                new System.Drawing.Font(
                    "Segoe UI Emoji",
                    18F);

            this.lblAvatar.Location =
                new System.Drawing.Point(15, 12);

            this.lblAvatar.Name =
                "lblAvatar";

            this.lblAvatar.Size =
                new System.Drawing.Size(38, 32);

            this.lblAvatar.TabIndex = 0;

            this.lblAvatar.Text = "👤";

            // =====================================================
            // lblAdminName
            // =====================================================
            this.lblAdminName.AutoSize = true;

            this.lblAdminName.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblAdminName.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblAdminName.Location =
                new System.Drawing.Point(55, 12);

            this.lblAdminName.Name =
                "lblAdminName";

            this.lblAdminName.Size =
                new System.Drawing.Size(142, 17);

            this.lblAdminName.TabIndex = 1;

            this.lblAdminName.Text =
                "System Administrator";

            // =====================================================
            // lblAdminRole
            // =====================================================
            this.lblAdminRole.AutoSize = true;

            this.lblAdminRole.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblAdminRole.ForeColor =
                System.Drawing.Color.FromArgb(
                    108,
                    117,
                    125);

            this.lblAdminRole.Location =
                new System.Drawing.Point(55, 31);

            this.lblAdminRole.Name =
                "lblAdminRole";

            this.lblAdminRole.Size =
                new System.Drawing.Size(42, 15);

            this.lblAdminRole.TabIndex = 2;

            this.lblAdminRole.Text =
                "Admin";

            // =====================================================
            // lblBellIcon
            // =====================================================
            this.lblBellIcon.AutoSize = true;

            this.lblBellIcon.Font =
                new System.Drawing.Font(
                    "Segoe UI Emoji",
                    14F);

            this.lblBellIcon.Location =
                new System.Drawing.Point(235, 16);

            this.lblBellIcon.Name =
                "lblBellIcon";

            this.lblBellIcon.Size =
                new System.Drawing.Size(29, 25);

            this.lblBellIcon.TabIndex = 3;

            this.lblBellIcon.Text = "🔔";

            // =====================================================
            // pnlSidebar
            // =====================================================
            this.pnlSidebar.BackColor =
                System.Drawing.Color.White;

            this.pnlSidebar.Controls.Add(
                this.btnBack);

            this.pnlSidebar.Controls.Add(
                this.btnLeaderboardReport);

            this.pnlSidebar.Controls.Add(
                this.btnMatchReport);

            this.pnlSidebar.Controls.Add(
                this.btnPlayerReport);

            this.pnlSidebar.Controls.Add(
                this.btnTeamReport);

            this.pnlSidebar.Controls.Add(
                this.btnTournamentReport);

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

            this.pnlSidebar.TabIndex = 1;

            // =====================================================
            // pnlSidebarHeader
            // =====================================================
            this.pnlSidebarHeader.Controls.Add(
                this.lblLogo);

            this.pnlSidebarHeader.Controls.Add(
                this.lblReportsLogo);

            this.pnlSidebarHeader.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlSidebarHeader.Location =
                new System.Drawing.Point(0, 0);

            this.pnlSidebarHeader.Name =
                "pnlSidebarHeader";

            this.pnlSidebarHeader.Size =
                new System.Drawing.Size(240, 80);

            this.pnlSidebarHeader.TabIndex = 0;

            // =====================================================
            // lblLogo
            // =====================================================
            this.lblLogo.Font =
                new System.Drawing.Font(
                    "Segoe UI Emoji",
                    22F);

            this.lblLogo.ForeColor =
                System.Drawing.Color.FromArgb(
                    30,
                    109,
                    235);

            this.lblLogo.Location =
                new System.Drawing.Point(95, 5);

            this.lblLogo.Name =
                "lblLogo";

            this.lblLogo.Size =
                new System.Drawing.Size(50, 40);

            this.lblLogo.TabIndex = 1;

            this.lblLogo.Text = "📄";

            this.lblLogo.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // =====================================================
            // lblReportsLogo
            // =====================================================
            this.lblReportsLogo.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    11F,
                    System.Drawing.FontStyle.Bold);

            this.lblReportsLogo.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblReportsLogo.Location =
                new System.Drawing.Point(10, 48);

            this.lblReportsLogo.Name =
                "lblReportsLogo";

            this.lblReportsLogo.Size =
                new System.Drawing.Size(220, 25);

            this.lblReportsLogo.TabIndex = 0;

            this.lblReportsLogo.Text =
                "REPORTS";

            this.lblReportsLogo.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // =====================================================
            // Tournament Report Button
            // =====================================================
            ConfigureReportButton(
                this.btnTournamentReport,
                "🏆  Tournament Report",
                90,
                true);

            this.btnTournamentReport.Click +=
                new System.EventHandler(
                    this.btnTournamentReport_Click);

            // =====================================================
            // Team Report Button
            // =====================================================
            ConfigureReportButton(
                this.btnTeamReport,
                "👥  Team Report",
                140,
                false);

            this.btnTeamReport.Click +=
                new System.EventHandler(
                    this.btnTeamReport_Click);

            // =====================================================
            // Player Report Button
            // =====================================================
            ConfigureReportButton(
                this.btnPlayerReport,
                "🎮  Player Report",
                190,
                false);

            this.btnPlayerReport.Click +=
                new System.EventHandler(
                    this.btnPlayerReport_Click);

            // =====================================================
            // Match Report Button
            // =====================================================
            ConfigureReportButton(
                this.btnMatchReport,
                "⚔️  Match Report",
                240,
                false);

            this.btnMatchReport.Click +=
                new System.EventHandler(
                    this.btnMatchReport_Click);

            // =====================================================
            // Leaderboard Report Button
            // =====================================================
            ConfigureReportButton(
                this.btnLeaderboardReport,
                "📈  Leaderboard Report",
                290,
                false);

            this.btnLeaderboardReport.Click +=
                new System.EventHandler(
                    this.btnLeaderboardReport_Click);

            // =====================================================
            // Back Button
            // =====================================================
            this.btnBack.BackColor =
                System.Drawing.Color.White;

            this.btnBack.FlatAppearance.BorderColor =
                System.Drawing.Color.LightGray;

            this.btnBack.FlatAppearance.BorderSize = 1;

            this.btnBack.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnBack.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.btnBack.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.btnBack.Location =
                new System.Drawing.Point(15, 575);

            this.btnBack.Name =
                "btnBack";

            this.btnBack.Size =
                new System.Drawing.Size(210, 44);

            this.btnBack.TabIndex = 6;

            this.btnBack.Text =
                "⬅  Back to Dashboard";

            this.btnBack.UseVisualStyleBackColor =
                false;

            this.btnBack.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnBack.Click +=
                new System.EventHandler(
                    this.btnBack_Click);

            // =====================================================
            // pnlMainWorkArea
            // =====================================================
            this.pnlMainWorkArea.BackColor =
                System.Drawing.Color.FromArgb(
                    244,
                    246,
                    249);

            this.pnlMainWorkArea.Controls.Add(
                this.lblFooter);

            this.pnlMainWorkArea.Controls.Add(
                this.pnlReportContent);

            this.pnlMainWorkArea.Controls.Add(
                this.pnlTitleBar);

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

            // =====================================================
            // pnlTitleBar
            // =====================================================
            this.pnlTitleBar.Controls.Add(
                this.lblPageSubtitle);

            this.pnlTitleBar.Controls.Add(
                this.lblPageTitle);

            this.pnlTitleBar.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlTitleBar.Location =
                new System.Drawing.Point(15, 15);

            this.pnlTitleBar.Name =
                "pnlTitleBar";

            this.pnlTitleBar.Size =
                new System.Drawing.Size(930, 70);

            this.pnlTitleBar.TabIndex = 0;

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
                    33,
                    37,
                    41);

            this.lblPageTitle.Location =
                new System.Drawing.Point(0, 0);

            this.lblPageTitle.Name =
                "lblPageTitle";

            this.lblPageTitle.Size =
                new System.Drawing.Size(110, 37);

            this.lblPageTitle.TabIndex = 0;

            this.lblPageTitle.Text =
                "Reports";

            // =====================================================
            // lblPageSubtitle
            // =====================================================
            this.lblPageSubtitle.AutoSize = true;

            this.lblPageSubtitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9.5F);

            this.lblPageSubtitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    108,
                    117,
                    125);

            this.lblPageSubtitle.Location =
                new System.Drawing.Point(3, 42);

            this.lblPageSubtitle.Name =
                "lblPageSubtitle";

            this.lblPageSubtitle.Size =
                new System.Drawing.Size(350, 17);

            this.lblPageSubtitle.TabIndex = 1;

            this.lblPageSubtitle.Text =
                "Generate and view tournament management reports.";

            // =====================================================
            // pnlReportContent
            // =====================================================
            this.pnlReportContent.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.pnlReportContent.BackColor =
                System.Drawing.Color.Transparent;

            this.pnlReportContent.Location =
                new System.Drawing.Point(15, 100);

            this.pnlReportContent.Name =
                "pnlReportContent";

            this.pnlReportContent.Size =
                new System.Drawing.Size(930, 490);

            this.pnlReportContent.TabIndex = 1;

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
                    108,
                    117,
                    125);

            this.lblFooter.Location =
                new System.Drawing.Point(15, 600);

            this.lblFooter.Name =
                "lblFooter";

            this.lblFooter.Size =
                new System.Drawing.Size(930, 25);

            this.lblFooter.TabIndex = 2;

            this.lblFooter.Text =
                "© 2026 Gaming Tournament Management System";

            // =====================================================
            // ReportsForm
            // =====================================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(
                    7F,
                    15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(
                    1200,
                    700);

            this.Controls.Add(
                this.pnlMainWorkArea);

            this.Controls.Add(
                this.pnlSidebar);

            this.Controls.Add(
                this.pnlTopHeader);

            this.MinimumSize =
                new System.Drawing.Size(
                    1100,
                    650);

            this.Name =
                "ReportsForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Gaming Tournament Management System - Reports";

            this.Load +=
                new System.EventHandler(
                    this.ReportsForm_Load);

            // =====================================================
            // Resume Layout
            // =====================================================
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

        // =========================================================
        // Configure Report Button
        // =========================================================
        private void ConfigureReportButton(
            System.Windows.Forms.Button button,
            string text,
            int top,
            bool selected)
        {
            button.BackColor = selected
                ? System.Drawing.Color.FromArgb(
                    30,
                    109,
                    235)
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
                : System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            button.Location =
                new System.Drawing.Point(
                    15,
                    top);

            button.Name =
                text.Replace("🏆", "btnTournamentReport")
                    .Replace("👥", "btnTeamReport")
                    .Replace("🎮", "btnPlayerReport")
                    .Replace("⚔️", "btnMatchReport")
                    .Replace("📈", "btnLeaderboardReport")
                    .Trim();

            button.Size =
                new System.Drawing.Size(
                    210,
                    42);

            button.TabIndex =
                top / 50;

            button.Text =
                text;

            button.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            button.Padding =
                new System.Windows.Forms.Padding(
                    12,
                    0,
                    5,
                    0);

            button.UseVisualStyleBackColor =
                false;

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
        private System.Windows.Forms.Label lblReportsLogo;

        private System.Windows.Forms.Button btnTournamentReport;
        private System.Windows.Forms.Button btnTeamReport;
        private System.Windows.Forms.Button btnPlayerReport;
        private System.Windows.Forms.Button btnMatchReport;
        private System.Windows.Forms.Button btnLeaderboardReport;
        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.Panel pnlMainWorkArea;
        private System.Windows.Forms.Panel pnlTitleBar;

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;

        private System.Windows.Forms.Panel pnlReportContent;
        private System.Windows.Forms.Label lblFooter;
    }
}