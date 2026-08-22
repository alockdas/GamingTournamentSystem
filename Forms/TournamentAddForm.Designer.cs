namespace GamingTournamentSystem.Forms
{
    partial class TournamentAddForm
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
            this.lblFormSubtitle = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();

            this.pnlContent = new System.Windows.Forms.Panel();

            this.lblTournamentName = new System.Windows.Forms.Label();
            this.txtTournamentName = new System.Windows.Forms.TextBox();

            this.lblGameName = new System.Windows.Forms.Label();
            this.txtGameName = new System.Windows.Forms.TextBox();

            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();

            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();

            this.lblPrizePool = new System.Windows.Forms.Label();
            this.txtPrizePool = new System.Windows.Forms.TextBox();

            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            this.pnlButtons = new System.Windows.Forms.Panel();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            // =====================================================
            // Suspend Layout
            // =====================================================

            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlButtons.SuspendLayout();

            this.SuspendLayout();

            // =====================================================
            // pnlHeader
            // =====================================================

            this.pnlHeader.BackColor =
                System.Drawing.Color.White;

            this.pnlHeader.Controls.Add(
                this.lblFormSubtitle);

            this.pnlHeader.Controls.Add(
                this.lblFormTitle);

            this.pnlHeader.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlHeader.Location =
                new System.Drawing.Point(0, 0);

            this.pnlHeader.Name =
                "pnlHeader";

            this.pnlHeader.Size =
                new System.Drawing.Size(700, 100);

            this.pnlHeader.TabIndex = 0;

            // =====================================================
            // lblFormTitle
            // =====================================================

            this.lblFormTitle.AutoSize = true;

            this.lblFormTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Bold);

            this.lblFormTitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblFormTitle.Location =
                new System.Drawing.Point(30, 18);

            this.lblFormTitle.Name =
                "lblFormTitle";

            this.lblFormTitle.Size =
                new System.Drawing.Size(270, 37);

            this.lblFormTitle.TabIndex = 0;

            this.lblFormTitle.Text =
                "Add New Tournament";

            // =====================================================
            // lblFormSubtitle
            // =====================================================

            this.lblFormSubtitle.AutoSize = true;

            this.lblFormSubtitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9.5F);

            this.lblFormSubtitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    108,
                    117,
                    125);

            this.lblFormSubtitle.Location =
                new System.Drawing.Point(33, 62);

            this.lblFormSubtitle.Name =
                "lblFormSubtitle";

            this.lblFormSubtitle.Size =
                new System.Drawing.Size(270, 17);

            this.lblFormSubtitle.TabIndex = 1;

            this.lblFormSubtitle.Text =
                "Create a new gaming tournament.";

            // =====================================================
            // pnlContent
            // =====================================================

            this.pnlContent.BackColor =
                System.Drawing.Color.FromArgb(
                    244,
                    246,
                    249);

            this.pnlContent.Controls.Add(
                this.cmbStatus);

            this.pnlContent.Controls.Add(
                this.lblStatus);

            this.pnlContent.Controls.Add(
                this.txtPrizePool);

            this.pnlContent.Controls.Add(
                this.lblPrizePool);

            this.pnlContent.Controls.Add(
                this.dtpEndDate);

            this.pnlContent.Controls.Add(
                this.lblEndDate);

            this.pnlContent.Controls.Add(
                this.dtpStartDate);

            this.pnlContent.Controls.Add(
                this.lblStartDate);

            this.pnlContent.Controls.Add(
                this.txtGameName);

            this.pnlContent.Controls.Add(
                this.lblGameName);

            this.pnlContent.Controls.Add(
                this.txtTournamentName);

            this.pnlContent.Controls.Add(
                this.lblTournamentName);

            this.pnlContent.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.pnlContent.Location =
                new System.Drawing.Point(0, 100);

            this.pnlContent.Name =
                "pnlContent";

            this.pnlContent.Padding =
                new System.Windows.Forms.Padding(30);

            this.pnlContent.Size =
                new System.Drawing.Size(700, 420);

            this.pnlContent.TabIndex = 1;

            // =====================================================
            // lblTournamentName
            // =====================================================

            this.lblTournamentName.AutoSize = true;

            this.lblTournamentName.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblTournamentName.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblTournamentName.Location =
                new System.Drawing.Point(30, 25);

            this.lblTournamentName.Name =
                "lblTournamentName";

            this.lblTournamentName.Size =
                new System.Drawing.Size(119, 17);

            this.lblTournamentName.TabIndex = 0;

            this.lblTournamentName.Text =
                "Tournament Name";

            // =====================================================
            // txtTournamentName
            // =====================================================

            this.txtTournamentName.BackColor =
                System.Drawing.Color.White;

            this.txtTournamentName.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtTournamentName.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtTournamentName.Location =
                new System.Drawing.Point(30, 48);

            this.txtTournamentName.Name =
                "txtTournamentName";

            this.txtTournamentName.Size =
                new System.Drawing.Size(640, 25);

            this.txtTournamentName.TabIndex = 1;

            // =====================================================
            // lblGameName
            // =====================================================

            this.lblGameName.AutoSize = true;

            this.lblGameName.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblGameName.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblGameName.Location =
                new System.Drawing.Point(30, 88);

            this.lblGameName.Name =
                "lblGameName";

            this.lblGameName.Size =
                new System.Drawing.Size(72, 17);

            this.lblGameName.TabIndex = 2;

            this.lblGameName.Text =
                "Game Name";

            // =====================================================
            // txtGameName
            // =====================================================

            this.txtGameName.BackColor =
                System.Drawing.Color.White;

            this.txtGameName.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtGameName.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtGameName.Location =
                new System.Drawing.Point(30, 111);

            this.txtGameName.Name =
                "txtGameName";

            this.txtGameName.Size =
                new System.Drawing.Size(640, 25);

            this.txtGameName.TabIndex = 3;

            // =====================================================
            // lblStartDate
            // =====================================================

            this.lblStartDate.AutoSize = true;

            this.lblStartDate.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblStartDate.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblStartDate.Location =
                new System.Drawing.Point(30, 151);

            this.lblStartDate.Name =
                "lblStartDate";

            this.lblStartDate.Size =
                new System.Drawing.Size(65, 17);

            this.lblStartDate.TabIndex = 4;

            this.lblStartDate.Text =
                "Start Date";

            // =====================================================
            // dtpStartDate
            // =====================================================

            this.dtpStartDate.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.dtpStartDate.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpStartDate.Location =
                new System.Drawing.Point(30, 174);

            this.dtpStartDate.Name =
                "dtpStartDate";

            this.dtpStartDate.Size =
                new System.Drawing.Size(300, 25);

            this.dtpStartDate.TabIndex = 5;

            // =====================================================
            // lblEndDate
            // =====================================================

            this.lblEndDate.AutoSize = true;

            this.lblEndDate.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblEndDate.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblEndDate.Location =
                new System.Drawing.Point(370, 151);

            this.lblEndDate.Name =
                "lblEndDate";

            this.lblEndDate.Size =
                new System.Drawing.Size(61, 17);

            this.lblEndDate.TabIndex = 6;

            this.lblEndDate.Text =
                "End Date";

            // =====================================================
            // dtpEndDate
            // =====================================================

            this.dtpEndDate.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.dtpEndDate.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpEndDate.Location =
                new System.Drawing.Point(370, 174);

            this.dtpEndDate.Name =
                "dtpEndDate";

            this.dtpEndDate.Size =
                new System.Drawing.Size(300, 25);

            this.dtpEndDate.TabIndex = 7;

            // =====================================================
            // lblPrizePool
            // =====================================================

            this.lblPrizePool.AutoSize = true;

            this.lblPrizePool.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblPrizePool.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblPrizePool.Location =
                new System.Drawing.Point(30, 214);

            this.lblPrizePool.Name =
                "lblPrizePool";

            this.lblPrizePool.Size =
                new System.Drawing.Size(71, 17);

            this.lblPrizePool.TabIndex = 8;

            this.lblPrizePool.Text =
                "Prize Pool";

            // =====================================================
            // txtPrizePool
            // =====================================================

            this.txtPrizePool.BackColor =
                System.Drawing.Color.White;

            this.txtPrizePool.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtPrizePool.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtPrizePool.Location =
                new System.Drawing.Point(30, 237);

            this.txtPrizePool.Name =
                "txtPrizePool";

            this.txtPrizePool.Size =
                new System.Drawing.Size(300, 25);

            this.txtPrizePool.TabIndex = 9;

            this.txtPrizePool.Text =
                "0.00";

            // =====================================================
            // lblStatus
            // =====================================================

            this.lblStatus.AutoSize = true;

            this.lblStatus.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblStatus.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblStatus.Location =
                new System.Drawing.Point(370, 214);

            this.lblStatus.Name =
                "lblStatus";

            this.lblStatus.Size =
                new System.Drawing.Size(45, 17);

            this.lblStatus.TabIndex = 10;

            this.lblStatus.Text =
                "Status";

            // =====================================================
            // cmbStatus
            // =====================================================

            this.cmbStatus.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbStatus.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.cmbStatus.FormattingEnabled = true;

            this.cmbStatus.Items.AddRange(
                new object[]
                {
                    "Upcoming",
                    "Ongoing",
                    "Completed",
                    "Cancelled"
                });

            this.cmbStatus.Location =
                new System.Drawing.Point(370, 237);

            this.cmbStatus.Name =
                "cmbStatus";

            this.cmbStatus.Size =
                new System.Drawing.Size(300, 25);

            this.cmbStatus.TabIndex = 11;

            // =====================================================
            // pnlButtons
            // =====================================================

            this.pnlButtons.BackColor =
                System.Drawing.Color.White;

            this.pnlButtons.Controls.Add(
                this.btnCancel);

            this.pnlButtons.Controls.Add(
                this.btnSave);

            this.pnlButtons.Dock =
                System.Windows.Forms.DockStyle.Bottom;

            this.pnlButtons.Location =
                new System.Drawing.Point(0, 520);

            this.pnlButtons.Name =
                "pnlButtons";

            this.pnlButtons.Size =
                new System.Drawing.Size(700, 80);

            this.pnlButtons.TabIndex = 2;

            // =====================================================
            // btnSave
            // =====================================================

            this.btnSave.BackColor =
                System.Drawing.Color.FromArgb(
                    30,
                    109,
                    235);

            this.btnSave.FlatAppearance.BorderSize =
                0;

            this.btnSave.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnSave.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.btnSave.ForeColor =
                System.Drawing.Color.White;

            this.btnSave.Location =
                new System.Drawing.Point(370, 20);

            this.btnSave.Name =
                "btnSave";

            this.btnSave.Size =
                new System.Drawing.Size(190, 42);

            this.btnSave.TabIndex = 0;

            this.btnSave.Text =
                "➕  CREATE TOURNAMENT";

            this.btnSave.UseVisualStyleBackColor =
                false;

            this.btnSave.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnSave.Click +=
                new System.EventHandler(
                    this.btnSave_Click);

            // =====================================================
            // btnCancel
            // =====================================================

            this.btnCancel.BackColor =
                System.Drawing.Color.White;

            this.btnCancel.FlatAppearance.BorderColor =
                System.Drawing.Color.LightGray;

            this.btnCancel.FlatAppearance.BorderSize =
                1;

            this.btnCancel.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnCancel.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.btnCancel.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.btnCancel.Location =
                new System.Drawing.Point(570, 20);

            this.btnCancel.Name =
                "btnCancel";

            this.btnCancel.Size =
                new System.Drawing.Size(105, 42);

            this.btnCancel.TabIndex = 1;

            this.btnCancel.Text =
                "CANCEL";

            this.btnCancel.UseVisualStyleBackColor =
                false;

            this.btnCancel.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnCancel.Click +=
                new System.EventHandler(
                    this.btnCancel_Click);

            // =====================================================
            // TournamentAddForm
            // =====================================================

            this.AcceptButton =
                this.btnSave;

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(
                    7F,
                    15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.CancelButton =
                this.btnCancel;

            this.ClientSize =
                new System.Drawing.Size(
                    700,
                    600);

            this.Controls.Add(
                this.pnlContent);

            this.Controls.Add(
                this.pnlButtons);

            this.Controls.Add(
                this.pnlHeader);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.MinimizeBox = false;

            this.Name =
                "TournamentAddForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text =
                "Tournament";

            this.Load +=
                new System.EventHandler(
                    this.TournamentAddForm_Load);

            // =====================================================
            // Resume Layout
            // =====================================================

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();

            this.pnlButtons.ResumeLayout(false);

            this.ResumeLayout(false);
        }

        // =========================================================
        // Fields
        // =========================================================

        private System.Windows.Forms.Panel pnlHeader;

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFormSubtitle;

        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.TextBox txtTournamentName;

        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.TextBox txtGameName;

        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;

        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;

        private System.Windows.Forms.Label lblPrizePool;
        private System.Windows.Forms.TextBox txtPrizePool;

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;

        private System.Windows.Forms.Panel pnlButtons;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}