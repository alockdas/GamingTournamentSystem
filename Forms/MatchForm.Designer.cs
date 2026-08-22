namespace GamingTournamentSystem.Forms
{
    partial class MatchForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();

            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.lblMatchCount = new System.Windows.Forms.Label();

            this.dgvMatches = new System.Windows.Forms.DataGridView();

            this.colMatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTournamentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeam1ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeam2ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatchDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWinnerTeamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlHeader.SuspendLayout();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
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
                    33, 37, 41);

            this.lblTitle.Location =
                new System.Drawing.Point(25, 15);

            this.lblTitle.Name =
                "lblTitle";

            this.lblTitle.Size =
                new System.Drawing.Size(280, 37);

            this.lblTitle.TabIndex = 0;

            this.lblTitle.Text =
                "Match Management";

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
                new System.Drawing.Size(330, 17);

            this.lblSubtitle.TabIndex = 1;

            this.lblSubtitle.Text =
                "Create and manage tournament matches.";

            // =========================================================
            // pnlActions
            // =========================================================
            this.pnlActions.BackColor =
                System.Drawing.Color.FromArgb(
                    244, 246, 249);

            this.pnlActions.Controls.Add(
                this.btnBack);

            this.pnlActions.Controls.Add(
                this.btnDelete);

            this.pnlActions.Controls.Add(
                this.btnUpdate);

            this.pnlActions.Controls.Add(
                this.btnAdd);

            this.pnlActions.Controls.Add(
                this.lblMatchCount);

            this.pnlActions.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlActions.Location =
                new System.Drawing.Point(0, 90);

            this.pnlActions.Name =
                "pnlActions";

            this.pnlActions.Size =
                new System.Drawing.Size(1200, 65);

            this.pnlActions.TabIndex = 1;

            // =========================================================
            // lblMatchCount
            // =========================================================
            this.lblMatchCount.AutoSize = true;

            this.lblMatchCount.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblMatchCount.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.lblMatchCount.Location =
                new System.Drawing.Point(25, 23);

            this.lblMatchCount.Name =
                "lblMatchCount";

            this.lblMatchCount.Size =
                new System.Drawing.Size(110, 19);

            this.lblMatchCount.TabIndex = 0;

            this.lblMatchCount.Text =
                "Total Matches: 0";

            // =========================================================
            // btnAdd
            // =========================================================
            ConfigureActionButton(
                this.btnAdd,
                "➕  Add Match",
                new System.Drawing.Point(400, 12),
                System.Drawing.Color.FromArgb(
                    30, 109, 235));

            this.btnAdd.Click +=
                new System.EventHandler(
                    this.btnAdd_Click);

            // =========================================================
            // btnUpdate
            // =========================================================
            ConfigureActionButton(
                this.btnUpdate,
                "✏️  Update",
                new System.Drawing.Point(540, 12),
                System.Drawing.Color.FromArgb(
                    255, 193, 7));

            this.btnUpdate.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.btnUpdate.Click +=
                new System.EventHandler(
                    this.btnUpdate_Click);

            // =========================================================
            // btnDelete
            // =========================================================
            ConfigureActionButton(
                this.btnDelete,
                "🗑️  Delete",
                new System.Drawing.Point(680, 12),
                System.Drawing.Color.FromArgb(
                    220, 53, 69));

            this.btnDelete.Click +=
                new System.EventHandler(
                    this.btnDelete_Click);

            // =========================================================
            // btnBack
            // =========================================================
            ConfigureActionButton(
                this.btnBack,
                "←  Back",
                new System.Drawing.Point(820, 12),
                System.Drawing.Color.White);

            this.btnBack.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.btnBack.FlatAppearance.BorderColor =
                System.Drawing.Color.LightGray;

            this.btnBack.FlatAppearance.BorderSize = 1;

            this.btnBack.Click +=
                new System.EventHandler(
                    this.btnBack_Click);

            // =========================================================
            // dgvMatches
            // =========================================================
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.AllowUserToResizeRows = false;

            this.dgvMatches.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.dgvMatches.AutoGenerateColumns = false;

            this.dgvMatches.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvMatches.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.dgvMatches.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvMatches.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            this.dgvMatches.ColumnHeadersDefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter,

                    BackColor =
                        System.Drawing.Color.FromArgb(
                            30, 109, 235),

                    Font =
                        new System.Drawing.Font(
                            "Segoe UI Semibold",
                            9F,
                            System.Drawing.FontStyle.Bold),

                    ForeColor =
                        System.Drawing.Color.White,

                    SelectionBackColor =
                        System.Drawing.Color.FromArgb(
                            30, 109, 235),

                    SelectionForeColor =
                        System.Drawing.Color.White
                };

            this.dgvMatches.ColumnHeadersHeight = 42;
            this.dgvMatches.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvMatches.EnableHeadersVisualStyles = false;

            this.dgvMatches.GridColor =
                System.Drawing.Color.FromArgb(
                    230, 233, 238);

            this.dgvMatches.Location =
                new System.Drawing.Point(20, 175);

            this.dgvMatches.MultiSelect = false;

            this.dgvMatches.Name =
                "dgvMatches";

            this.dgvMatches.ReadOnly = true;

            this.dgvMatches.RowHeadersVisible = false;

            this.dgvMatches.RowTemplate.Height = 38;

            this.dgvMatches.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvMatches.Size =
                new System.Drawing.Size(1160, 470);

            this.dgvMatches.TabIndex = 2;

            this.dgvMatches.DefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter,

                    BackColor =
                        System.Drawing.Color.White,

                    Font =
                        new System.Drawing.Font(
                            "Segoe UI",
                            9F),

                    ForeColor =
                        System.Drawing.Color.FromArgb(
                            33, 37, 41),

                    SelectionBackColor =
                        System.Drawing.Color.FromArgb(
                            225, 235, 255),

                    SelectionForeColor =
                        System.Drawing.Color.FromArgb(
                            33, 37, 41),

                    WrapMode =
                        System.Windows.Forms.DataGridViewTriState.False
                };

            // =========================================================
            // Columns
            // =========================================================

            // Match ID
            this.colMatchID.HeaderText = "Match ID";
            this.colMatchID.Name = "colMatchID";
            this.colMatchID.ReadOnly = true;
            this.colMatchID.Width = 75;

            // Tournament ID
            this.colTournamentID.HeaderText = "Tournament";
            this.colTournamentID.Name = "colTournamentID";
            this.colTournamentID.ReadOnly = true;
            this.colTournamentID.Width = 90;

            // Team 1
            this.colTeam1ID.HeaderText = "Team 1";
            this.colTeam1ID.Name = "colTeam1ID";
            this.colTeam1ID.ReadOnly = true;
            this.colTeam1ID.Width = 75;

            // Team 2
            this.colTeam2ID.HeaderText = "Team 2";
            this.colTeam2ID.Name = "colTeam2ID";
            this.colTeam2ID.ReadOnly = true;
            this.colTeam2ID.Width = 75;

            // Match Date
            this.colMatchDate.HeaderText = "Match Date";
            this.colMatchDate.Name = "colMatchDate";
            this.colMatchDate.ReadOnly = true;
            this.colMatchDate.Width = 110;

            // Match Time
            this.colMatchTime.HeaderText = "Time";
            this.colMatchTime.Name = "colMatchTime";
            this.colMatchTime.ReadOnly = true;
            this.colMatchTime.Width = 80;

            // Venue
            this.colVenue.HeaderText = "Venue";
            this.colVenue.Name = "colVenue";
            this.colVenue.ReadOnly = true;
            this.colVenue.Width = 180;

            // Winner
            this.colWinnerTeamID.HeaderText = "Winner";
            this.colWinnerTeamID.Name = "colWinnerTeamID";
            this.colWinnerTeamID.ReadOnly = true;
            this.colWinnerTeamID.Width = 80;

            // Status
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 110;

            // Add Columns
            this.dgvMatches.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colMatchID,
                    this.colTournamentID,
                    this.colTeam1ID,
                    this.colTeam2ID,
                    this.colMatchDate,
                    this.colMatchTime,
                    this.colVenue,
                    this.colWinnerTeamID,
                    this.colStatus
                });

            this.dgvMatches.CellDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvMatches_CellDoubleClick);

            // =========================================================
            // MatchForm
            // =========================================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(
                    244, 246, 249);

            this.ClientSize =
                new System.Drawing.Size(1200, 700);

            this.Controls.Add(
                this.dgvMatches);

            this.Controls.Add(
                this.pnlActions);

            this.Controls.Add(
                this.pnlHeader);

            this.MinimumSize =
                new System.Drawing.Size(1050, 650);

            this.Name =
                "MatchForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Match Management";

            this.Load +=
                new System.EventHandler(
                    this.MatchForm_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvMatches)).EndInit();

            this.ResumeLayout(false);
        }

        // =========================================================
        // Helper Method
        // =========================================================
        private void ConfigureActionButton(
            System.Windows.Forms.Button button,
            string text,
            System.Drawing.Point location,
            System.Drawing.Color backColor)
        {
            button.BackColor = backColor;

            button.FlatAppearance.BorderSize = 0;

            button.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            button.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9F,
                    System.Drawing.FontStyle.Bold);

            button.ForeColor =
                System.Drawing.Color.White;

            button.Location =
                location;

            button.Name =
                text;

            button.Size =
                new System.Drawing.Size(125, 40);

            button.TabIndex = 0;

            button.Text = text;

            button.UseVisualStyleBackColor = false;

            button.Cursor =
                System.Windows.Forms.Cursors.Hand;
        }

        // =========================================================
        // Fields
        // =========================================================

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlActions;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.Label lblMatchCount;

        private System.Windows.Forms.DataGridView dgvMatches;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTournamentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeam1ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeam2ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatchDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatchTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWinnerTeamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}