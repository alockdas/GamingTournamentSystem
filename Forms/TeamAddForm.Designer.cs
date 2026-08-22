namespace GamingTournamentSystem.Forms
{
    partial class TeamAddForm
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

            this.lblFormTitle =
                new System.Windows.Forms.Label();

            this.lblFormSubtitle =
                new System.Windows.Forms.Label();

            this.pnlForm =
                new System.Windows.Forms.Panel();

            this.lblTournamentID =
                new System.Windows.Forms.Label();

            this.txtTournamentID =
                new System.Windows.Forms.TextBox();

            this.lblTeamName =
                new System.Windows.Forms.Label();

            this.txtTeamName =
                new System.Windows.Forms.TextBox();

            this.lblCaptainName =
                new System.Windows.Forms.Label();

            this.txtCaptainName =
                new System.Windows.Forms.TextBox();

            this.lblGameName =
                new System.Windows.Forms.Label();

            this.txtGameName =
                new System.Windows.Forms.TextBox();

            this.lblTotalPlayers =
                new System.Windows.Forms.Label();

            this.txtTotalPlayers =
                new System.Windows.Forms.TextBox();

            this.lblCoachName =
                new System.Windows.Forms.Label();

            this.txtCoachName =
                new System.Windows.Forms.TextBox();

            this.btnSave =
                new System.Windows.Forms.Button();

            this.btnCancel =
                new System.Windows.Forms.Button();

            // Suspend
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();

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
                new System.Drawing.Size(650, 95);

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
                    33,
                    37,
                    41);

            this.lblFormTitle.Location =
                new System.Drawing.Point(30, 15);

            this.lblFormTitle.Name =
                "lblFormTitle";

            this.lblFormTitle.Size =
                new System.Drawing.Size(200, 37);

            this.lblFormTitle.TabIndex = 0;

            this.lblFormTitle.Text =
                "➕ Add Team";

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
                    108,
                    117,
                    125);

            this.lblFormSubtitle.Location =
                new System.Drawing.Point(33, 58);

            this.lblFormSubtitle.Name =
                "lblFormSubtitle";

            this.lblFormSubtitle.Size =
                new System.Drawing.Size(300, 17);

            this.lblFormSubtitle.TabIndex = 1;

            this.lblFormSubtitle.Text =
                "Enter team information below.";

            // =========================================================
            // pnlForm
            // =========================================================
            this.pnlForm.BackColor =
                System.Drawing.Color.FromArgb(
                    244,
                    246,
                    249);

            this.pnlForm.Controls.Add(
                this.lblTournamentID);

            this.pnlForm.Controls.Add(
                this.txtTournamentID);

            this.pnlForm.Controls.Add(
                this.lblTeamName);

            this.pnlForm.Controls.Add(
                this.txtTeamName);

            this.pnlForm.Controls.Add(
                this.lblCaptainName);

            this.pnlForm.Controls.Add(
                this.txtCaptainName);

            this.pnlForm.Controls.Add(
                this.lblGameName);

            this.pnlForm.Controls.Add(
                this.txtGameName);

            this.pnlForm.Controls.Add(
                this.lblTotalPlayers);

            this.pnlForm.Controls.Add(
                this.txtTotalPlayers);

            this.pnlForm.Controls.Add(
                this.lblCoachName);

            this.pnlForm.Controls.Add(
                this.txtCoachName);

            this.pnlForm.Controls.Add(
                this.btnSave);

            this.pnlForm.Controls.Add(
                this.btnCancel);

            this.pnlForm.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.pnlForm.Location =
                new System.Drawing.Point(0, 95);

            this.pnlForm.Name =
                "pnlForm";

            this.pnlForm.Padding =
                new System.Windows.Forms.Padding(30);

            this.pnlForm.Size =
                new System.Drawing.Size(650, 495);

            this.pnlForm.TabIndex = 1;

            // =========================================================
            // lblTournamentID
            // =========================================================
            this.lblTournamentID.AutoSize = true;

            this.lblTournamentID.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblTournamentID.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblTournamentID.Location =
                new System.Drawing.Point(35, 25);

            this.lblTournamentID.Name =
                "lblTournamentID";

            this.lblTournamentID.Size =
                new System.Drawing.Size(100, 17);

            this.lblTournamentID.TabIndex = 0;

            this.lblTournamentID.Text =
                "Tournament ID";

            // =========================================================
            // txtTournamentID
            // =========================================================
            this.txtTournamentID.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtTournamentID.Location =
                new System.Drawing.Point(35, 47);

            this.txtTournamentID.Name =
                "txtTournamentID";

            this.txtTournamentID.Size =
                new System.Drawing.Size(270, 25);

            this.txtTournamentID.TabIndex = 1;

            // =========================================================
            // lblTeamName
            // =========================================================
            this.lblTeamName.AutoSize = true;

            this.lblTeamName.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblTeamName.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblTeamName.Location =
                new System.Drawing.Point(35, 90);

            this.lblTeamName.Name =
                "lblTeamName";

            this.lblTeamName.Size =
                new System.Drawing.Size(75, 17);

            this.lblTeamName.TabIndex = 2;

            this.lblTeamName.Text =
                "Team Name";

            // =========================================================
            // txtTeamName
            // =========================================================
            this.txtTeamName.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtTeamName.Location =
                new System.Drawing.Point(35, 112);

            this.txtTeamName.Name =
                "txtTeamName";

            this.txtTeamName.Size =
                new System.Drawing.Size(270, 25);

            this.txtTeamName.TabIndex = 3;

            // =========================================================
            // lblCaptainName
            // =========================================================
            this.lblCaptainName.AutoSize = true;

            this.lblCaptainName.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblCaptainName.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblCaptainName.Location =
                new System.Drawing.Point(35, 155);

            this.lblCaptainName.Name =
                "lblCaptainName";

            this.lblCaptainName.Size =
                new System.Drawing.Size(94, 17);

            this.lblCaptainName.TabIndex = 4;

            this.lblCaptainName.Text =
                "Captain Name";

            // =========================================================
            // txtCaptainName
            // =========================================================
            this.txtCaptainName.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtCaptainName.Location =
                new System.Drawing.Point(35, 177);

            this.txtCaptainName.Name =
                "txtCaptainName";

            this.txtCaptainName.Size =
                new System.Drawing.Size(270, 25);

            this.txtCaptainName.TabIndex = 5;

            // =========================================================
            // lblGameName
            // =========================================================
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
                new System.Drawing.Point(350, 25);

            this.lblGameName.Name =
                "lblGameName";

            this.lblGameName.Size =
                new System.Drawing.Size(75, 17);

            this.lblGameName.TabIndex = 6;

            this.lblGameName.Text =
                "Game Name";

            // =========================================================
            // txtGameName
            // =========================================================
            this.txtGameName.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtGameName.Location =
                new System.Drawing.Point(350, 47);

            this.txtGameName.Name =
                "txtGameName";

            this.txtGameName.Size =
                new System.Drawing.Size(270, 25);

            this.txtGameName.TabIndex = 7;

            // =========================================================
            // lblTotalPlayers
            // =========================================================
            this.lblTotalPlayers.AutoSize = true;

            this.lblTotalPlayers.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblTotalPlayers.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblTotalPlayers.Location =
                new System.Drawing.Point(350, 90);

            this.lblTotalPlayers.Name =
                "lblTotalPlayers";

            this.lblTotalPlayers.Size =
                new System.Drawing.Size(87, 17);

            this.lblTotalPlayers.TabIndex = 8;

            this.lblTotalPlayers.Text =
                "Total Players";

            // =========================================================
            // txtTotalPlayers
            // =========================================================
            this.txtTotalPlayers.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtTotalPlayers.Location =
                new System.Drawing.Point(350, 112);

            this.txtTotalPlayers.Name =
                "txtTotalPlayers";

            this.txtTotalPlayers.Size =
                new System.Drawing.Size(270, 25);

            this.txtTotalPlayers.TabIndex = 9;

            // =========================================================
            // lblCoachName
            // =========================================================
            this.lblCoachName.AutoSize = true;

            this.lblCoachName.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblCoachName.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblCoachName.Location =
                new System.Drawing.Point(350, 155);

            this.lblCoachName.Name =
                "lblCoachName";

            this.lblCoachName.Size =
                new System.Drawing.Size(82, 17);

            this.lblCoachName.TabIndex = 10;

            this.lblCoachName.Text =
                "Coach Name";

            // =========================================================
            // txtCoachName
            // =========================================================
            this.txtCoachName.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtCoachName.Location =
                new System.Drawing.Point(350, 177);

            this.txtCoachName.Name =
                "txtCoachName";

            this.txtCoachName.Size =
                new System.Drawing.Size(270, 25);

            this.txtCoachName.TabIndex = 11;

            // =========================================================
            // btnSave
            // =========================================================
            this.btnSave.BackColor =
                System.Drawing.Color.FromArgb(
                    30,
                    109,
                    235);

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
                new System.Drawing.Point(350, 250);

            this.btnSave.Name =
                "btnSave";

            this.btnSave.Size =
                new System.Drawing.Size(130, 42);

            this.btnSave.TabIndex = 12;

            this.btnSave.Text =
                "💾  SAVE";

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
                    33,
                    37,
                    41);

            this.btnCancel.Location =
                new System.Drawing.Point(495, 250);

            this.btnCancel.Name =
                "btnCancel";

            this.btnCancel.Size =
                new System.Drawing.Size(125, 42);

            this.btnCancel.TabIndex = 13;

            this.btnCancel.Text =
                "✖  CANCEL";

            this.btnCancel.UseVisualStyleBackColor =
                false;

            this.btnCancel.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnCancel.DialogResult =
                System.Windows.Forms.DialogResult.Cancel;

            // =========================================================
            // TeamAddForm
            // =========================================================
            this.AcceptButton =
                this.btnSave;

            this.CancelButton =
                this.btnCancel;

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(
                    7F,
                    15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(
                    650,
                    590);

            this.Controls.Add(
                this.pnlForm);

            this.Controls.Add(
                this.pnlHeader);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedDialog;

            this.MaximizeBox = false;

            this.MinimizeBox = false;

            this.Name =
                "TeamAddForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text =
                "Add Team";

            // Resume
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();

            this.ResumeLayout(false);
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

        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.TextBox txtTeamName;

        private System.Windows.Forms.Label lblCaptainName;
        private System.Windows.Forms.TextBox txtCaptainName;

        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.TextBox txtGameName;

        private System.Windows.Forms.Label lblTotalPlayers;
        private System.Windows.Forms.TextBox txtTotalPlayers;

        private System.Windows.Forms.Label lblCoachName;
        private System.Windows.Forms.TextBox txtCoachName;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}