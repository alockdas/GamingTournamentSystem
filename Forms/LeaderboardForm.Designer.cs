namespace GamingTournamentSystem.Forms
{
    partial class LeaderboardForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();

            this.pnlMain = new System.Windows.Forms.Panel();

            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();

            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLosses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDraws = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.lblTeamCount = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            this.SuspendLayout();

            // =========================================================
            // pnlHeader
            // =========================================================
            this.pnlHeader.BackColor =
                System.Drawing.Color.White;

            this.pnlHeader.Controls.Add(
                this.lblSubtitle);

            this.pnlHeader.Controls.Add(
                this.lblTitle);

            this.pnlHeader.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlHeader.Location =
                new System.Drawing.Point(0, 0);

            this.pnlHeader.Name =
                "pnlHeader";

            this.pnlHeader.Size =
                new System.Drawing.Size(1000, 90);

            this.pnlHeader.TabIndex = 0;

            // =========================================================
            // lblTitle
            // =========================================================
            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.lblTitle.Location =
                new System.Drawing.Point(25, 15);

            this.lblTitle.Name =
                "lblTitle";

            this.lblTitle.Size =
                new System.Drawing.Size(220, 37);

            this.lblTitle.TabIndex = 0;

            this.lblTitle.Text =
                "📈 Leaderboard";

            // =========================================================
            // lblSubtitle
            // =========================================================
            this.lblSubtitle.AutoSize = true;

            this.lblSubtitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9.5F);

            this.lblSubtitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    108, 117, 125);

            this.lblSubtitle.Location =
                new System.Drawing.Point(28, 55);

            this.lblSubtitle.Name =
                "lblSubtitle";

            this.lblSubtitle.Size =
                new System.Drawing.Size(350, 17);

            this.lblSubtitle.TabIndex = 1;

            this.lblSubtitle.Text =
                "View tournament team rankings and standings.";

            // =========================================================
            // pnlMain
            // =========================================================
            this.pnlMain.BackColor =
                System.Drawing.Color.FromArgb(
                    244, 246, 249);

            this.pnlMain.Controls.Add(
                this.dgvLeaderboard);

            this.pnlMain.Controls.Add(
                this.lblTeamCount);

            this.pnlMain.Controls.Add(
                this.btnBack);

            this.pnlMain.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.pnlMain.Location =
                new System.Drawing.Point(0, 90);

            this.pnlMain.Name =
                "pnlMain";

            this.pnlMain.Padding =
                new System.Windows.Forms.Padding(25);

            this.pnlMain.Size =
                new System.Drawing.Size(1000, 560);

            this.pnlMain.TabIndex = 1;

            // =========================================================
            // dgvLeaderboard
            // =========================================================
            this.dgvLeaderboard.AllowUserToAddRows =
                false;

            this.dgvLeaderboard.AllowUserToDeleteRows =
                false;

            this.dgvLeaderboard.AllowUserToResizeRows =
                false;

            this.dgvLeaderboard.AutoGenerateColumns =
                false;

            this.dgvLeaderboard.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvLeaderboard.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.dgvLeaderboard.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvLeaderboard.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            this.dgvLeaderboard.ColumnHeadersDefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    BackColor =
                        System.Drawing.Color.FromArgb(
                            30, 109, 235),

                    ForeColor =
                        System.Drawing.Color.White,

                    Font =
                        new System.Drawing.Font(
                            "Segoe UI Semibold",
                            9.5F,
                            System.Drawing.FontStyle.Bold),

                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                };

            this.dgvLeaderboard.ColumnHeadersHeight =
                45;

            this.dgvLeaderboard.EnableHeadersVisualStyles =
                false;

            this.dgvLeaderboard.GridColor =
                System.Drawing.Color.LightGray;

            this.dgvLeaderboard.Location =
                new System.Drawing.Point(25, 25);

            this.dgvLeaderboard.MultiSelect =
                false;

            this.dgvLeaderboard.Name =
                "dgvLeaderboard";

            this.dgvLeaderboard.ReadOnly =
                true;

            this.dgvLeaderboard.RowHeadersVisible =
                false;

            this.dgvLeaderboard.RowTemplate.Height =
                38;

            this.dgvLeaderboard.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvLeaderboard.Size =
                new System.Drawing.Size(950, 390);

            this.dgvLeaderboard.TabIndex = 0;

            // =========================================================
            // Rank Column
            // =========================================================
            this.colRank.HeaderText =
                "Rank";

            this.colRank.Name =
                "colRank";

            this.colRank.ReadOnly =
                true;

            this.colRank.Width =
                80;

            this.colRank.DefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                };

            // =========================================================
            // Team Name Column
            // =========================================================
            this.colTeamName.HeaderText =
                "Team";

            this.colTeamName.Name =
                "colTeamName";

            this.colTeamName.ReadOnly =
                true;

            this.colTeamName.Width =
                280;

            // =========================================================
            // Played Column
            // =========================================================
            this.colPlayed.HeaderText =
                "Played";

            this.colPlayed.Name =
                "colPlayed";

            this.colPlayed.ReadOnly =
                true;

            this.colPlayed.Width =
                100;

            this.colPlayed.DefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                };

            // =========================================================
            // Wins Column
            // =========================================================
            this.colWins.HeaderText =
                "Win";

            this.colWins.Name =
                "colWins";

            this.colWins.ReadOnly =
                true;

            this.colWins.Width =
                100;

            this.colWins.DefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                };

            // =========================================================
            // Losses Column
            // =========================================================
            this.colLosses.HeaderText =
                "Loss";

            this.colLosses.Name =
                "colLosses";

            this.colLosses.ReadOnly =
                true;

            this.colLosses.Width =
                100;

            this.colLosses.DefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                };

            // =========================================================
            // Draws Column
            // =========================================================
            this.colDraws.HeaderText =
                "Draw";

            this.colDraws.Name =
                "colDraws";

            this.colDraws.ReadOnly =
                true;

            this.colDraws.Width =
                100;

            this.colDraws.DefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                };

            // =========================================================
            // Points Column
            // =========================================================
            this.colPoints.HeaderText =
                "Pts";

            this.colPoints.Name =
                "colPoints";

            this.colPoints.ReadOnly =
                true;

            this.colPoints.Width =
                120;

            this.colPoints.DefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter,

                    Font =
                        new System.Drawing.Font(
                            "Segoe UI Semibold",
                            9.5F,
                            System.Drawing.FontStyle.Bold)
                };

            // =========================================================
            // Add Columns
            // =========================================================
            this.dgvLeaderboard.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colRank,
                    this.colTeamName,
                    this.colPlayed,
                    this.colWins,
                    this.colLosses,
                    this.colDraws,
                    this.colPoints
                });

            // =========================================================
            // lblTeamCount
            // =========================================================
            this.lblTeamCount.AutoSize = true;

            this.lblTeamCount.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblTeamCount.ForeColor =
                System.Drawing.Color.FromArgb(
                    108, 117, 125);

            this.lblTeamCount.Location =
                new System.Drawing.Point(25, 435);

            this.lblTeamCount.Name =
                "lblTeamCount";

            this.lblTeamCount.Size =
                new System.Drawing.Size(105, 17);

            this.lblTeamCount.TabIndex = 1;

            this.lblTeamCount.Text =
                "Total Teams: 0";

            // =========================================================
            // btnBack
            // =========================================================
            this.btnBack.BackColor =
                System.Drawing.Color.White;

            this.btnBack.FlatAppearance.BorderColor =
                System.Drawing.Color.LightGray;

            this.btnBack.FlatAppearance.BorderSize =
                1;

            this.btnBack.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnBack.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.btnBack.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.btnBack.Location =
                new System.Drawing.Point(25, 475);

            this.btnBack.Name =
                "btnBack";

            this.btnBack.Size =
                new System.Drawing.Size(120, 42);

            this.btnBack.TabIndex = 2;

            this.btnBack.Text =
                "←  Back";

            this.btnBack.UseVisualStyleBackColor =
                false;

            this.btnBack.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnBack.Click +=
                new System.EventHandler(
                    this.btnBack_Click);

            // =========================================================
            // LeaderboardForm
            // =========================================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(
                    7F,
                    15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(
                    1000,
                    650);

            this.Controls.Add(
                this.pnlMain);

            this.Controls.Add(
                this.pnlHeader);

            this.MinimumSize =
                new System.Drawing.Size(
                    900,
                    600);

            this.Name =
                "LeaderboardForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Leaderboard - Gaming Tournament Management System";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvLeaderboard)).EndInit();

            this.ResumeLayout(false);
        }

        // =========================================================
        // Fields
        // =========================================================

        private System.Windows.Forms.Panel pnlHeader;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlMain;

        private System.Windows.Forms.DataGridView dgvLeaderboard;

        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWins;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLosses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDraws;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPoints;

        private System.Windows.Forms.Label lblTeamCount;

        private System.Windows.Forms.Button btnBack;
    }
}