namespace GamingTournamentSystem.Forms
{
    partial class TeamForm
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

            this.pnlContent = new System.Windows.Forms.Panel();

            this.lblTeamCount = new System.Windows.Forms.Label();

            this.dgvTeams =
                new System.Windows.Forms.DataGridView();

            this.colTeamID =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colTournamentID =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colTeamName =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colCaptainName =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colGameName =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colTotalPlayers =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colCoachName =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colMatchesPlayed =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colWins =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colLosses =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colDraws =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colPoints =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlButtons =
                new System.Windows.Forms.Panel();

            this.btnAdd =
                new System.Windows.Forms.Button();

            this.btnUpdate =
                new System.Windows.Forms.Button();

            this.btnDelete =
                new System.Windows.Forms.Button();

            this.btnBack =
                new System.Windows.Forms.Button();

            // Suspend
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvTeams)).BeginInit();

            this.pnlButtons.SuspendLayout();

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
                new System.Drawing.Size(1200, 90);

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
                    33,
                    37,
                    41);

            this.lblTitle.Location =
                new System.Drawing.Point(25, 15);

            this.lblTitle.Name =
                "lblTitle";

            this.lblTitle.Size =
                new System.Drawing.Size(300, 37);

            this.lblTitle.TabIndex = 0;

            this.lblTitle.Text =
                "👥 Team Management";

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
                    108,
                    117,
                    125);

            this.lblSubtitle.Location =
                new System.Drawing.Point(28, 55);

            this.lblSubtitle.Name =
                "lblSubtitle";

            this.lblSubtitle.Size =
                new System.Drawing.Size(450, 17);

            this.lblSubtitle.TabIndex = 1;

            this.lblSubtitle.Text =
                "Create, update and manage registered teams.";

            // =========================================================
            // pnlContent
            // =========================================================
            this.pnlContent.BackColor =
                System.Drawing.Color.FromArgb(
                    244,
                    246,
                    249);

            this.pnlContent.Controls.Add(
                this.dgvTeams);

            this.pnlContent.Controls.Add(
                this.lblTeamCount);

            this.pnlContent.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.pnlContent.Location =
                new System.Drawing.Point(0, 90);

            this.pnlContent.Name =
                "pnlContent";

            this.pnlContent.Padding =
                new System.Windows.Forms.Padding(20);

            this.pnlContent.Size =
                new System.Drawing.Size(1200, 520);

            this.pnlContent.TabIndex = 1;

            // =========================================================
            // lblTeamCount
            // =========================================================
            this.lblTeamCount.AutoSize = true;

            this.lblTeamCount.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblTeamCount.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblTeamCount.Location =
                new System.Drawing.Point(20, 15);

            this.lblTeamCount.Name =
                "lblTeamCount";

            this.lblTeamCount.Size =
                new System.Drawing.Size(120, 19);

            this.lblTeamCount.TabIndex = 0;

            this.lblTeamCount.Text =
                "Total Teams: 0";

            // =========================================================
            // dgvTeams
            // =========================================================
            this.dgvTeams.AllowUserToAddRows =
                false;

            this.dgvTeams.AllowUserToDeleteRows =
                false;

            this.dgvTeams.AllowUserToResizeRows =
                false;

            this.dgvTeams.AutoGenerateColumns =
                false;

            this.dgvTeams.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvTeams.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvTeams.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.dgvTeams.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvTeams.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            this.dgvTeams.ColumnHeadersDefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    BackColor =
                        System.Drawing.Color.FromArgb(
                            30,
                            109,
                            235),

                    ForeColor =
                        System.Drawing.Color.White,

                    Font =
                        new System.Drawing.Font(
                            "Segoe UI Semibold",
                            9F,
                            System.Drawing.FontStyle.Bold),

                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter,

                    SelectionBackColor =
                        System.Drawing.Color.FromArgb(
                            30,
                            109,
                            235),

                    SelectionForeColor =
                        System.Drawing.Color.White
                };

            this.dgvTeams.DefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    BackColor =
                        System.Drawing.Color.White,

                    ForeColor =
                        System.Drawing.Color.FromArgb(
                            33,
                            37,
                            41),

                    Font =
                        new System.Drawing.Font(
                            "Segoe UI",
                            9F),

                    SelectionBackColor =
                        System.Drawing.Color.FromArgb(
                            220,
                            235,
                            255),

                    SelectionForeColor =
                        System.Drawing.Color.FromArgb(
                            33,
                            37,
                            41),

                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                };

            this.dgvTeams.EnableHeadersVisualStyles =
                false;

            this.dgvTeams.GridColor =
                System.Drawing.Color.FromArgb(
                    230,
                    233,
                    237);

            this.dgvTeams.Location =
                new System.Drawing.Point(20, 45);

            this.dgvTeams.MultiSelect =
                false;

            this.dgvTeams.Name =
                "dgvTeams";

            this.dgvTeams.ReadOnly =
                true;

            this.dgvTeams.RowHeadersVisible =
                false;

            this.dgvTeams.RowTemplate.Height =
                38;

            this.dgvTeams.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvTeams.Size =
                new System.Drawing.Size(1160, 430);

            this.dgvTeams.TabIndex = 1;

            this.dgvTeams.CellDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvTeams_CellDoubleClick);

            // =========================================================
            // Columns
            // =========================================================

            this.colTeamID.HeaderText = "ID";
            this.colTeamID.Name = "colTeamID";
            this.colTeamID.ReadOnly = true;
            this.colTeamID.FillWeight = 40F;

            this.colTournamentID.HeaderText = "Tournament ID";
            this.colTournamentID.Name = "colTournamentID";
            this.colTournamentID.ReadOnly = true;
            this.colTournamentID.FillWeight = 70F;

            this.colTeamName.HeaderText = "Team Name";
            this.colTeamName.Name = "colTeamName";
            this.colTeamName.ReadOnly = true;
            this.colTeamName.FillWeight = 110F;

            this.colCaptainName.HeaderText = "Captain";
            this.colCaptainName.Name = "colCaptainName";
            this.colCaptainName.ReadOnly = true;
            this.colCaptainName.FillWeight = 100F;

            this.colGameName.HeaderText = "Game";
            this.colGameName.Name = "colGameName";
            this.colGameName.ReadOnly = true;
            this.colGameName.FillWeight = 85F;

            this.colTotalPlayers.HeaderText = "Players";
            this.colTotalPlayers.Name = "colTotalPlayers";
            this.colTotalPlayers.ReadOnly = true;
            this.colTotalPlayers.FillWeight = 60F;

            this.colCoachName.HeaderText = "Coach";
            this.colCoachName.Name = "colCoachName";
            this.colCoachName.ReadOnly = true;
            this.colCoachName.FillWeight = 90F;

            this.colMatchesPlayed.HeaderText = "Played";
            this.colMatchesPlayed.Name = "colMatchesPlayed";
            this.colMatchesPlayed.ReadOnly = true;
            this.colMatchesPlayed.FillWeight = 60F;

            this.colWins.HeaderText = "Wins";
            this.colWins.Name = "colWins";
            this.colWins.ReadOnly = true;
            this.colWins.FillWeight = 55F;

            this.colLosses.HeaderText = "Losses";
            this.colLosses.Name = "colLosses";
            this.colLosses.ReadOnly = true;
            this.colLosses.FillWeight = 60F;

            this.colDraws.HeaderText = "Draws";
            this.colDraws.Name = "colDraws";
            this.colDraws.ReadOnly = true;
            this.colDraws.FillWeight = 55F;

            this.colPoints.HeaderText = "Points";
            this.colPoints.Name = "colPoints";
            this.colPoints.ReadOnly = true;
            this.colPoints.FillWeight = 60F;

            this.dgvTeams.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colTeamID,
                    this.colTournamentID,
                    this.colTeamName,
                    this.colCaptainName,
                    this.colGameName,
                    this.colTotalPlayers,
                    this.colCoachName,
                    this.colMatchesPlayed,
                    this.colWins,
                    this.colLosses,
                    this.colDraws,
                    this.colPoints
                });

            // =========================================================
            // pnlButtons
            // =========================================================
            this.pnlButtons.BackColor =
                System.Drawing.Color.White;

            this.pnlButtons.Controls.Add(
                this.btnBack);

            this.pnlButtons.Controls.Add(
                this.btnDelete);

            this.pnlButtons.Controls.Add(
                this.btnUpdate);

            this.pnlButtons.Controls.Add(
                this.btnAdd);

            this.pnlButtons.Dock =
                System.Windows.Forms.DockStyle.Bottom;

            this.pnlButtons.Location =
                new System.Drawing.Point(0, 610);

            this.pnlButtons.Name =
                "pnlButtons";

            this.pnlButtons.Size =
                new System.Drawing.Size(1200, 70);

            this.pnlButtons.TabIndex = 2;

            // =========================================================
            // btnAdd
            // =========================================================
            this.btnAdd.BackColor =
                System.Drawing.Color.FromArgb(
                    30,
                    109,
                    235);

            this.btnAdd.FlatAppearance.BorderSize = 0;

            this.btnAdd.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnAdd.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.btnAdd.ForeColor =
                System.Drawing.Color.White;

            this.btnAdd.Location =
                new System.Drawing.Point(25, 15);

            this.btnAdd.Name =
                "btnAdd";

            this.btnAdd.Size =
                new System.Drawing.Size(120, 40);

            this.btnAdd.TabIndex = 0;

            this.btnAdd.Text =
                "➕  ADD";

            this.btnAdd.UseVisualStyleBackColor =
                false;

            this.btnAdd.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnAdd.Click +=
                new System.EventHandler(
                    this.btnAdd_Click);

            // =========================================================
            // btnUpdate
            // =========================================================
            this.btnUpdate.BackColor =
                System.Drawing.Color.FromArgb(
                    255,
                    193,
                    7);

            this.btnUpdate.FlatAppearance.BorderSize = 0;

            this.btnUpdate.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnUpdate.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.btnUpdate.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.btnUpdate.Location =
                new System.Drawing.Point(160, 15);

            this.btnUpdate.Name =
                "btnUpdate";

            this.btnUpdate.Size =
                new System.Drawing.Size(120, 40);

            this.btnUpdate.TabIndex = 1;

            this.btnUpdate.Text =
                "✏️  UPDATE";

            this.btnUpdate.UseVisualStyleBackColor =
                false;

            this.btnUpdate.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnUpdate.Click +=
                new System.EventHandler(
                    this.btnUpdate_Click);

            // =========================================================
            // btnDelete
            // =========================================================
            this.btnDelete.BackColor =
                System.Drawing.Color.FromArgb(
                    220,
                    53,
                    69);

            this.btnDelete.FlatAppearance.BorderSize = 0;

            this.btnDelete.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnDelete.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.btnDelete.ForeColor =
                System.Drawing.Color.White;

            this.btnDelete.Location =
                new System.Drawing.Point(295, 15);

            this.btnDelete.Name =
                "btnDelete";

            this.btnDelete.Size =
                new System.Drawing.Size(120, 40);

            this.btnDelete.TabIndex = 2;

            this.btnDelete.Text =
                "🗑️  DELETE";

            this.btnDelete.UseVisualStyleBackColor =
                false;

            this.btnDelete.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnDelete.Click +=
                new System.EventHandler(
                    this.btnDelete_Click);

            // =========================================================
            // btnBack
            // =========================================================
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
                new System.Drawing.Point(1050, 15);

            this.btnBack.Name =
                "btnBack";

            this.btnBack.Size =
                new System.Drawing.Size(120, 40);

            this.btnBack.TabIndex = 3;

            this.btnBack.Text =
                "←  BACK";

            this.btnBack.UseVisualStyleBackColor =
                false;

            this.btnBack.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnBack.Click +=
                new System.EventHandler(
                    this.btnBack_Click);

            // =========================================================
            // TeamForm
            // =========================================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1200, 680);

            this.Controls.Add(
                this.pnlContent);

            this.Controls.Add(
                this.pnlButtons);

            this.Controls.Add(
                this.pnlHeader);

            this.MinimumSize =
                new System.Drawing.Size(1200, 680);

            this.Name =
                "TeamForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Team Management";

            this.Load +=
                new System.EventHandler(
                    this.TeamForm_Load);

            // Resume
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvTeams)).EndInit();

            this.pnlButtons.ResumeLayout(false);

            this.ResumeLayout(false);
        }

        // =========================================================
        // Fields
        // =========================================================

        private System.Windows.Forms.Panel pnlHeader;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.Label lblTeamCount;

        private System.Windows.Forms.DataGridView dgvTeams;

        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTournamentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaptainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoachName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatchesPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWins;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLosses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDraws;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPoints;

        private System.Windows.Forms.Panel pnlButtons;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
    }
}