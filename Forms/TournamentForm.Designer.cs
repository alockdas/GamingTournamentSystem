namespace GamingTournamentSystem.Forms
{
    partial class TournamentForm
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

            this.lblTournamentCount = new System.Windows.Forms.Label();

            this.dgvTournaments =
                new System.Windows.Forms.DataGridView();

            this.colTournamentID =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colTournamentName =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colGameName =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colStartDate =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colEndDate =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colPrizePool =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colStatus =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlButtons = new System.Windows.Forms.Panel();

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
                (this.dgvTournaments)).BeginInit();
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
                    33,
                    37,
                    41);

            this.lblTitle.Location =
                new System.Drawing.Point(25, 15);

            this.lblTitle.Name =
                "lblTitle";

            this.lblTitle.Size =
                new System.Drawing.Size(390, 37);

            this.lblTitle.TabIndex = 0;

            this.lblTitle.Text =
                "🏆 Tournament Management";

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
                new System.Drawing.Size(400, 17);

            this.lblSubtitle.TabIndex = 1;

            this.lblSubtitle.Text =
                "Create, update and manage gaming tournaments.";

            // =========================================================
            // pnlContent
            // =========================================================
            this.pnlContent.BackColor =
                System.Drawing.Color.FromArgb(
                    244,
                    246,
                    249);

            this.pnlContent.Controls.Add(
                this.dgvTournaments);

            this.pnlContent.Controls.Add(
                this.lblTournamentCount);

            this.pnlContent.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.pnlContent.Location =
                new System.Drawing.Point(0, 90);

            this.pnlContent.Name =
                "pnlContent";

            this.pnlContent.Padding =
                new System.Windows.Forms.Padding(20);

            this.pnlContent.Size =
                new System.Drawing.Size(1000, 520);

            this.pnlContent.TabIndex = 1;

            // =========================================================
            // lblTournamentCount
            // =========================================================
            this.lblTournamentCount.AutoSize = true;

            this.lblTournamentCount.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblTournamentCount.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblTournamentCount.Location =
                new System.Drawing.Point(20, 15);

            this.lblTournamentCount.Name =
                "lblTournamentCount";

            this.lblTournamentCount.Size =
                new System.Drawing.Size(150, 19);

            this.lblTournamentCount.TabIndex = 0;

            this.lblTournamentCount.Text =
                "Total Tournaments: 0";

            // =========================================================
            // dgvTournaments
            // =========================================================
            this.dgvTournaments.AllowUserToAddRows =
                false;

            this.dgvTournaments.AllowUserToDeleteRows =
                false;

            this.dgvTournaments.AllowUserToResizeRows =
                false;

            this.dgvTournaments.AutoGenerateColumns =
                false;

            this.dgvTournaments.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvTournaments.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvTournaments.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.dgvTournaments.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvTournaments.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            this.dgvTournaments.ColumnHeadersDefaultCellStyle =
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

            this.dgvTournaments.DefaultCellStyle =
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

            this.dgvTournaments.EnableHeadersVisualStyles =
                false;

            this.dgvTournaments.GridColor =
                System.Drawing.Color.FromArgb(
                    230,
                    233,
                    237);

            this.dgvTournaments.Location =
                new System.Drawing.Point(20, 45);

            this.dgvTournaments.MultiSelect =
                false;

            this.dgvTournaments.Name =
                "dgvTournaments";

            this.dgvTournaments.ReadOnly =
                true;

            this.dgvTournaments.RowHeadersVisible =
                false;

            this.dgvTournaments.RowTemplate.Height =
                38;

            this.dgvTournaments.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvTournaments.Size =
                new System.Drawing.Size(960, 430);

            this.dgvTournaments.TabIndex = 1;

            this.dgvTournaments.CellDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvTournaments_CellDoubleClick);

            // =========================================================
            // colTournamentID
            // =========================================================
            this.colTournamentID.HeaderText =
                "ID";

            this.colTournamentID.Name =
                "colTournamentID";

            this.colTournamentID.ReadOnly =
                true;

            this.colTournamentID.FillWeight =
                45F;

            // =========================================================
            // colTournamentName
            // =========================================================
            this.colTournamentName.HeaderText =
                "Tournament Name";

            this.colTournamentName.Name =
                "colTournamentName";

            this.colTournamentName.ReadOnly =
                true;

            this.colTournamentName.FillWeight =
                125F;

            // =========================================================
            // colGameName
            // =========================================================
            this.colGameName.HeaderText =
                "Game";

            this.colGameName.Name =
                "colGameName";

            this.colGameName.ReadOnly =
                true;

            this.colGameName.FillWeight =
                100F;

            // =========================================================
            // colStartDate
            // =========================================================
            this.colStartDate.HeaderText =
                "Start Date";

            this.colStartDate.Name =
                "colStartDate";

            this.colStartDate.ReadOnly =
                true;

            this.colStartDate.FillWeight =
                85F;

            // =========================================================
            // colEndDate
            // =========================================================
            this.colEndDate.HeaderText =
                "End Date";

            this.colEndDate.Name =
                "colEndDate";

            this.colEndDate.ReadOnly =
                true;

            this.colEndDate.FillWeight =
                85F;

            // =========================================================
            // colPrizePool
            // =========================================================
            this.colPrizePool.HeaderText =
                "Prize Pool";

            this.colPrizePool.Name =
                "colPrizePool";

            this.colPrizePool.ReadOnly =
                true;

            this.colPrizePool.FillWeight =
                90F;

            // =========================================================
            // colStatus
            // =========================================================
            this.colStatus.HeaderText =
                "Status";

            this.colStatus.Name =
                "colStatus";

            this.colStatus.ReadOnly =
                true;

            this.colStatus.FillWeight =
                80F;

            // Add columns
            this.dgvTournaments.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colTournamentID,
                    this.colTournamentName,
                    this.colGameName,
                    this.colStartDate,
                    this.colEndDate,
                    this.colPrizePool,
                    this.colStatus
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
                new System.Drawing.Size(1000, 70);

            this.pnlButtons.TabIndex = 2;

            // =========================================================
            // btnAdd
            // =========================================================
            this.btnAdd.BackColor =
                System.Drawing.Color.FromArgb(
                    30,
                    109,
                    235);

            this.btnAdd.FlatAppearance.BorderSize =
                0;

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

            this.btnUpdate.FlatAppearance.BorderSize =
                0;

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

            this.btnDelete.FlatAppearance.BorderSize =
                0;

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
                    33,
                    37,
                    41);

            this.btnBack.Location =
                new System.Drawing.Point(850, 15);

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
            // TournamentForm
            // =========================================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1000, 680);

            this.Controls.Add(
                this.pnlContent);

            this.Controls.Add(
                this.pnlButtons);

            this.Controls.Add(
                this.pnlHeader);

            this.MinimumSize =
                new System.Drawing.Size(1000, 680);

            this.Name =
                "TournamentForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Tournament Management";

            this.Load +=
                new System.EventHandler(
                    this.TournamentForm_Load);

            // Resume
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvTournaments)).EndInit();

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

        private System.Windows.Forms.Label lblTournamentCount;

        private System.Windows.Forms.DataGridView dgvTournaments;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            colTournamentID;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            colTournamentName;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            colGameName;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            colStartDate;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            colEndDate;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            colPrizePool;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            colStatus;

        private System.Windows.Forms.Panel pnlButtons;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
    }
}