namespace GamingTournamentSystem.Forms
{
    partial class MatchAddForm
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

            this.pnlForm = new System.Windows.Forms.Panel();

            this.lblTournamentID = new System.Windows.Forms.Label();
            this.txtTournamentID = new System.Windows.Forms.TextBox();

            this.lblTeam1ID = new System.Windows.Forms.Label();
            this.txtTeam1ID = new System.Windows.Forms.TextBox();

            this.lblTeam2ID = new System.Windows.Forms.Label();
            this.txtTeam2ID = new System.Windows.Forms.TextBox();

            this.lblMatchDate = new System.Windows.Forms.Label();
            this.txtMatchDate = new System.Windows.Forms.TextBox();

            this.lblMatchTime = new System.Windows.Forms.Label();
            this.txtMatchTime = new System.Windows.Forms.TextBox();

            this.lblVenue = new System.Windows.Forms.Label();
            this.txtVenue = new System.Windows.Forms.TextBox();

            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            this.lblWinnerTeamID = new System.Windows.Forms.Label();
            this.txtWinnerTeamID = new System.Windows.Forms.TextBox();

            this.lblHint = new System.Windows.Forms.Label();

            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // =========================================================
            // pnlHeader
            // =========================================================
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
                new System.Drawing.Size(760, 105);

            this.pnlHeader.TabIndex = 0;

            // =========================================================
            // lblFormTitle
            // =========================================================
            this.lblFormTitle.AutoSize = true;

            this.lblFormTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Bold);

            this.lblFormTitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.lblFormTitle.Location =
                new System.Drawing.Point(30, 20);

            this.lblFormTitle.Name =
                "lblFormTitle";

            this.lblFormTitle.Size =
                new System.Drawing.Size(245, 37);

            this.lblFormTitle.TabIndex = 0;

            this.lblFormTitle.Text =
                "➕ Add New Match";

            // =========================================================
            // lblFormSubtitle
            // =========================================================
            this.lblFormSubtitle.AutoSize = true;

            this.lblFormSubtitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9.5F);

            this.lblFormSubtitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    108, 117, 125);

            this.lblFormSubtitle.Location =
                new System.Drawing.Point(33, 62);

            this.lblFormSubtitle.Name =
                "lblFormSubtitle";

            this.lblFormSubtitle.Size =
                new System.Drawing.Size(380, 17);

            this.lblFormSubtitle.TabIndex = 1;

            this.lblFormSubtitle.Text =
                "Enter the information below to schedule a new match.";

            // =========================================================
            // pnlForm
            // =========================================================
            this.pnlForm.BackColor =
                System.Drawing.Color.FromArgb(
                    244, 246, 249);

            this.pnlForm.Controls.Add(
                this.lblHint);

            this.pnlForm.Controls.Add(
                this.txtWinnerTeamID);

            this.pnlForm.Controls.Add(
                this.lblWinnerTeamID);

            this.pnlForm.Controls.Add(
                this.cmbStatus);

            this.pnlForm.Controls.Add(
                this.lblStatus);

            this.pnlForm.Controls.Add(
                this.txtVenue);

            this.pnlForm.Controls.Add(
                this.lblVenue);

            this.pnlForm.Controls.Add(
                this.txtMatchTime);

            this.pnlForm.Controls.Add(
                this.lblMatchTime);

            this.pnlForm.Controls.Add(
                this.txtMatchDate);

            this.pnlForm.Controls.Add(
                this.lblMatchDate);

            this.pnlForm.Controls.Add(
                this.txtTeam2ID);

            this.pnlForm.Controls.Add(
                this.lblTeam2ID);

            this.pnlForm.Controls.Add(
                this.txtTeam1ID);

            this.pnlForm.Controls.Add(
                this.lblTeam1ID);

            this.pnlForm.Controls.Add(
                this.txtTournamentID);

            this.pnlForm.Controls.Add(
                this.lblTournamentID);

            this.pnlForm.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.pnlForm.Location =
                new System.Drawing.Point(0, 105);

            this.pnlForm.Name =
                "pnlForm";

            this.pnlForm.Padding =
                new System.Windows.Forms.Padding(30);

            this.pnlForm.Size =
                new System.Drawing.Size(760, 470);

            this.pnlForm.TabIndex = 1;

            // =========================================================
            // Tournament ID
            // =========================================================
            ConfigureLabel(
                this.lblTournamentID,
                "Tournament ID",
                new System.Drawing.Point(35, 25));

            ConfigureTextBox(
                this.txtTournamentID,
                new System.Drawing.Point(35, 50),
                310);

            this.txtTournamentID.Name =
                "txtTournamentID";

            // =========================================================
            // Team 1 ID
            // =========================================================
            ConfigureLabel(
                this.lblTeam1ID,
                "Team 1 ID",
                new System.Drawing.Point(395, 25));

            ConfigureTextBox(
                this.txtTeam1ID,
                new System.Drawing.Point(395, 50),
                310);

            this.txtTeam1ID.Name =
                "txtTeam1ID";

            // =========================================================
            // Team 2 ID
            // =========================================================
            ConfigureLabel(
                this.lblTeam2ID,
                "Team 2 ID",
                new System.Drawing.Point(35, 115));

            ConfigureTextBox(
                this.txtTeam2ID,
                new System.Drawing.Point(35, 140),
                310);

            this.txtTeam2ID.Name =
                "txtTeam2ID";

            // =========================================================
            // Match Date
            // =========================================================
            ConfigureLabel(
                this.lblMatchDate,
                "Match Date",
                new System.Drawing.Point(395, 115));

            ConfigureTextBox(
                this.txtMatchDate,
                new System.Drawing.Point(395, 140),
                310);

            this.txtMatchDate.Name =
                "txtMatchDate";

            this.txtMatchDate.PlaceholderText =
                "yyyy-MM-dd";

            // =========================================================
            // Match Time
            // =========================================================
            ConfigureLabel(
                this.lblMatchTime,
                "Match Time",
                new System.Drawing.Point(35, 205));

            ConfigureTextBox(
                this.txtMatchTime,
                new System.Drawing.Point(35, 230),
                310);

            this.txtMatchTime.Name =
                "txtMatchTime";

            this.txtMatchTime.PlaceholderText =
                "HH:mm";

            // =========================================================
            // Venue
            // =========================================================
            ConfigureLabel(
                this.lblVenue,
                "Venue",
                new System.Drawing.Point(395, 205));

            ConfigureTextBox(
                this.txtVenue,
                new System.Drawing.Point(395, 230),
                310);

            this.txtVenue.Name =
                "txtVenue";

            // =========================================================
            // Status
            // =========================================================
            ConfigureLabel(
                this.lblStatus,
                "Status",
                new System.Drawing.Point(35, 295));

            this.cmbStatus.BackColor =
                System.Drawing.Color.White;

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
                    "Scheduled",
                    "Ongoing",
                    "Completed"
                });

            this.cmbStatus.Location =
                new System.Drawing.Point(35, 320);

            this.cmbStatus.Name =
                "cmbStatus";

            this.cmbStatus.Size =
                new System.Drawing.Size(310, 25);

            this.cmbStatus.TabIndex = 7;

            this.cmbStatus.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cmbStatus_SelectedIndexChanged);

            // =========================================================
            // Winner Team ID
            // =========================================================
            ConfigureLabel(
                this.lblWinnerTeamID,
                "Winner Team ID",
                new System.Drawing.Point(395, 295));

            ConfigureTextBox(
                this.txtWinnerTeamID,
                new System.Drawing.Point(395, 320),
                310);

            this.txtWinnerTeamID.Name =
                "txtWinnerTeamID";

            // =========================================================
            // Hint
            // =========================================================
            this.lblHint.AutoSize = false;

            this.lblHint.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblHint.ForeColor =
                System.Drawing.Color.FromArgb(
                    108, 117, 125);

            this.lblHint.Location =
                new System.Drawing.Point(35, 365);

            this.lblHint.Name =
                "lblHint";

            this.lblHint.Size =
                new System.Drawing.Size(670, 45);

            this.lblHint.TabIndex = 10;

            this.lblHint.Text =
                "Date format: yyyy-MM-dd     |     Time format: HH:mm\r\n" +
                "Winner Team ID is required only when Status is Completed.";

            // =========================================================
            // pnlButtons
            // =========================================================
            this.pnlButtons.BackColor =
                System.Drawing.Color.White;

            this.pnlButtons.Controls.Add(
                this.btnCancel);

            this.pnlButtons.Controls.Add(
                this.btnSave);

            this.pnlButtons.Dock =
                System.Windows.Forms.DockStyle.Bottom;

            this.pnlButtons.Location =
                new System.Drawing.Point(0, 575);

            this.pnlButtons.Name =
                "pnlButtons";

            this.pnlButtons.Size =
                new System.Drawing.Size(760, 75);

            this.pnlButtons.TabIndex = 2;

            // =========================================================
            // btnSave
            // =========================================================
            this.btnSave.BackColor =
                System.Drawing.Color.FromArgb(
                    30, 109, 235);

            this.btnSave.FlatAppearance.BorderSize = 0;

            this.btnSave.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnSave.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnSave.ForeColor =
                System.Drawing.Color.White;

            this.btnSave.Location =
                new System.Drawing.Point(425, 16);

            this.btnSave.Name =
                "btnSave";

            this.btnSave.Size =
                new System.Drawing.Size(140, 42);

            this.btnSave.TabIndex = 0;

            this.btnSave.Text =
                "💾  Save Match";

            this.btnSave.UseVisualStyleBackColor =
                false;

            this.btnSave.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnSave.Click +=
                new System.EventHandler(
                    this.btnSave_Click);

            // =========================================================
            // btnCancel
            // =========================================================
            this.btnCancel.BackColor =
                System.Drawing.Color.White;

            this.btnCancel.FlatAppearance.BorderColor =
                System.Drawing.Color.LightGray;

            this.btnCancel.FlatAppearance.BorderSize = 1;

            this.btnCancel.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnCancel.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnCancel.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.btnCancel.Location =
                new System.Drawing.Point(580, 16);

            this.btnCancel.Name =
                "btnCancel";

            this.btnCancel.Size =
                new System.Drawing.Size(140, 42);

            this.btnCancel.TabIndex = 1;

            this.btnCancel.Text =
                "✖  Cancel";

            this.btnCancel.UseVisualStyleBackColor =
                false;

            this.btnCancel.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnCancel.Click +=
                new System.EventHandler(
                    this.btnCancel_Click);

            // =========================================================
            // MatchAddForm
            // =========================================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(
                    244, 246, 249);

            this.ClientSize =
                new System.Drawing.Size(760, 650);

            this.Controls.Add(
                this.pnlForm);

            this.Controls.Add(
                this.pnlHeader);

            this.Controls.Add(
                this.pnlButtons);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.MinimizeBox = false;

            this.Name =
                "MatchAddForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text =
                "Add Match";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();

            this.pnlButtons.ResumeLayout(false);

            this.ResumeLayout(false);
        }

        // =========================================================
        // Configure Label
        // =========================================================
        private void ConfigureLabel(
            System.Windows.Forms.Label label,
            string text,
            System.Drawing.Point location)
        {
            label.AutoSize = true;

            label.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            label.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            label.Location =
                location;

            label.Text =
                text;
        }

        // =========================================================
        // Configure TextBox
        // =========================================================
        private void ConfigureTextBox(
            System.Windows.Forms.TextBox textBox,
            System.Drawing.Point location,
            int width)
        {
            textBox.BackColor =
                System.Drawing.Color.White;

            textBox.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            textBox.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            textBox.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            textBox.Location =
                location;

            textBox.Size =
                new System.Drawing.Size(
                    width,
                    30);

            textBox.TabIndex = 0;
        }

        // =========================================================
        // Fields
        // =========================================================

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFormSubtitle;

        private System.Windows.Forms.Panel pnlForm;

        private System.Windows.Forms.Label lblTournamentID;
        private System.Windows.Forms.TextBox txtTournamentID;

        private System.Windows.Forms.Label lblTeam1ID;
        private System.Windows.Forms.TextBox txtTeam1ID;

        private System.Windows.Forms.Label lblTeam2ID;
        private System.Windows.Forms.TextBox txtTeam2ID;

        private System.Windows.Forms.Label lblMatchDate;
        private System.Windows.Forms.TextBox txtMatchDate;

        private System.Windows.Forms.Label lblMatchTime;
        private System.Windows.Forms.TextBox txtMatchTime;

        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.TextBox txtVenue;

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;

        private System.Windows.Forms.Label lblWinnerTeamID;
        private System.Windows.Forms.TextBox txtWinnerTeamID;

        private System.Windows.Forms.Label lblHint;

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}