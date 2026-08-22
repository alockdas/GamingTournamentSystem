namespace GamingTournamentSystem.Forms
{
    partial class PlayerAddForm
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

            this.lblTeamID =
                new System.Windows.Forms.Label();

            this.txtTeamID =
                new System.Windows.Forms.TextBox();

            this.lblFullName =
                new System.Windows.Forms.Label();

            this.txtFullName =
                new System.Windows.Forms.TextBox();

            this.lblUsername =
                new System.Windows.Forms.Label();

            this.txtUsername =
                new System.Windows.Forms.TextBox();

            this.lblEmail =
                new System.Windows.Forms.Label();

            this.txtEmail =
                new System.Windows.Forms.TextBox();

            this.lblPassword =
                new System.Windows.Forms.Label();

            this.txtPassword =
                new System.Windows.Forms.TextBox();

            this.lblInGameName =
                new System.Windows.Forms.Label();

            this.txtInGameName =
                new System.Windows.Forms.TextBox();

            this.lblPhone =
                new System.Windows.Forms.Label();

            this.txtPhone =
                new System.Windows.Forms.TextBox();

            this.lblAge =
                new System.Windows.Forms.Label();

            this.txtAge =
                new System.Windows.Forms.TextBox();

            this.lblRole =
                new System.Windows.Forms.Label();

            this.txtRole =
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
                new System.Drawing.Size(700, 95);

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
                new System.Drawing.Size(260, 37);

            this.lblFormTitle.TabIndex = 0;

            this.lblFormTitle.Text =
                "➕ Add New Player";

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
                new System.Drawing.Size(500, 17);

            this.lblFormSubtitle.TabIndex = 1;

            this.lblFormSubtitle.Text =
                "Create a player account and assign the player to a team.";

            // =========================================================
            // pnlForm
            // =========================================================
            this.pnlForm.BackColor =
                System.Drawing.Color.FromArgb(
                    244,
                    246,
                    249);

            this.pnlForm.Controls.Add(
                this.lblTeamID);

            this.pnlForm.Controls.Add(
                this.txtTeamID);

            this.pnlForm.Controls.Add(
                this.lblFullName);

            this.pnlForm.Controls.Add(
                this.txtFullName);

            this.pnlForm.Controls.Add(
                this.lblUsername);

            this.pnlForm.Controls.Add(
                this.txtUsername);

            this.pnlForm.Controls.Add(
                this.lblEmail);

            this.pnlForm.Controls.Add(
                this.txtEmail);

            this.pnlForm.Controls.Add(
                this.lblPassword);

            this.pnlForm.Controls.Add(
                this.txtPassword);

            this.pnlForm.Controls.Add(
                this.lblInGameName);

            this.pnlForm.Controls.Add(
                this.txtInGameName);

            this.pnlForm.Controls.Add(
                this.lblPhone);

            this.pnlForm.Controls.Add(
                this.txtPhone);

            this.pnlForm.Controls.Add(
                this.lblAge);

            this.pnlForm.Controls.Add(
                this.txtAge);

            this.pnlForm.Controls.Add(
                this.lblRole);

            this.pnlForm.Controls.Add(
                this.txtRole);

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
                new System.Drawing.Size(700, 545);

            this.pnlForm.TabIndex = 1;

            // =========================================================
            // LEFT COLUMN
            // =========================================================

            // =========================================================
            // lblTeamID
            // =========================================================
            this.lblTeamID.AutoSize = true;

            this.lblTeamID.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblTeamID.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblTeamID.Location =
                new System.Drawing.Point(35, 20);

            this.lblTeamID.Name =
                "lblTeamID";

            this.lblTeamID.Size =
                new System.Drawing.Size(58, 17);

            this.lblTeamID.TabIndex = 0;

            this.lblTeamID.Text =
                "Team ID";

            // =========================================================
            // txtTeamID
            // =========================================================
            this.txtTeamID.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtTeamID.Location =
                new System.Drawing.Point(35, 42);

            this.txtTeamID.Name =
                "txtTeamID";

            this.txtTeamID.Size =
                new System.Drawing.Size(285, 25);

            this.txtTeamID.TabIndex = 1;

            // =========================================================
            // lblFullName
            // =========================================================
            this.lblFullName.AutoSize = true;

            this.lblFullName.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblFullName.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblFullName.Location =
                new System.Drawing.Point(35, 82);

            this.lblFullName.Name =
                "lblFullName";

            this.lblFullName.Size =
                new System.Drawing.Size(70, 17);

            this.lblFullName.TabIndex = 2;

            this.lblFullName.Text =
                "Full Name";

            // =========================================================
            // txtFullName
            // =========================================================
            this.txtFullName.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtFullName.Location =
                new System.Drawing.Point(35, 104);

            this.txtFullName.Name =
                "txtFullName";

            this.txtFullName.Size =
                new System.Drawing.Size(285, 25);

            this.txtFullName.TabIndex = 3;

            // =========================================================
            // lblUsername
            // =========================================================
            this.lblUsername.AutoSize = true;

            this.lblUsername.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblUsername.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblUsername.Location =
                new System.Drawing.Point(35, 144);

            this.lblUsername.Name =
                "lblUsername";

            this.lblUsername.Size =
                new System.Drawing.Size(72, 17);

            this.lblUsername.TabIndex = 4;

            this.lblUsername.Text =
                "Username";

            // =========================================================
            // txtUsername
            // =========================================================
            this.txtUsername.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtUsername.Location =
                new System.Drawing.Point(35, 166);

            this.txtUsername.Name =
                "txtUsername";

            this.txtUsername.Size =
                new System.Drawing.Size(285, 25);

            this.txtUsername.TabIndex = 5;

            // =========================================================
            // lblEmail
            // =========================================================
            this.lblEmail.AutoSize = true;

            this.lblEmail.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblEmail.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblEmail.Location =
                new System.Drawing.Point(35, 206);

            this.lblEmail.Name =
                "lblEmail";

            this.lblEmail.Size =
                new System.Drawing.Size(39, 17);

            this.lblEmail.TabIndex = 6;

            this.lblEmail.Text =
                "Email";

            // =========================================================
            // txtEmail
            // =========================================================
            this.txtEmail.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtEmail.Location =
                new System.Drawing.Point(35, 228);

            this.txtEmail.Name =
                "txtEmail";

            this.txtEmail.Size =
                new System.Drawing.Size(285, 25);

            this.txtEmail.TabIndex = 7;

            // =========================================================
            // lblPassword
            // =========================================================
            this.lblPassword.AutoSize = true;

            this.lblPassword.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblPassword.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblPassword.Location =
                new System.Drawing.Point(35, 268);

            this.lblPassword.Name =
                "lblPassword";

            this.lblPassword.Size =
                new System.Drawing.Size(67, 17);

            this.lblPassword.TabIndex = 8;

            this.lblPassword.Text =
                "Password";

            // =========================================================
            // txtPassword
            // =========================================================
            this.txtPassword.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtPassword.Location =
                new System.Drawing.Point(35, 290);

            this.txtPassword.Name =
                "txtPassword";

            this.txtPassword.Size =
                new System.Drawing.Size(285, 25);

            this.txtPassword.TabIndex = 9;

            this.txtPassword.UseSystemPasswordChar =
                true;

            // =========================================================
            // RIGHT COLUMN
            // =========================================================

            // =========================================================
            // lblInGameName
            // =========================================================
            this.lblInGameName.AutoSize = true;

            this.lblInGameName.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblInGameName.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblInGameName.Location =
                new System.Drawing.Point(370, 20);

            this.lblInGameName.Name =
                "lblInGameName";

            this.lblInGameName.Size =
                new System.Drawing.Size(91, 17);

            this.lblInGameName.TabIndex = 10;

            this.lblInGameName.Text =
                "In-Game Name";

            // =========================================================
            // txtInGameName
            // =========================================================
            this.txtInGameName.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtInGameName.Location =
                new System.Drawing.Point(370, 42);

            this.txtInGameName.Name =
                "txtInGameName";

            this.txtInGameName.Size =
                new System.Drawing.Size(285, 25);

            this.txtInGameName.TabIndex = 11;

            // =========================================================
            // lblPhone
            // =========================================================
            this.lblPhone.AutoSize = true;

            this.lblPhone.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblPhone.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblPhone.Location =
                new System.Drawing.Point(370, 82);

            this.lblPhone.Name =
                "lblPhone";

            this.lblPhone.Size =
                new System.Drawing.Size(45, 17);

            this.lblPhone.TabIndex = 12;

            this.lblPhone.Text =
                "Phone";

            // =========================================================
            // txtPhone
            // =========================================================
            this.txtPhone.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtPhone.Location =
                new System.Drawing.Point(370, 104);

            this.txtPhone.Name =
                "txtPhone";

            this.txtPhone.Size =
                new System.Drawing.Size(285, 25);

            this.txtPhone.TabIndex = 13;

            // =========================================================
            // lblAge
            // =========================================================
            this.lblAge.AutoSize = true;

            this.lblAge.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblAge.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblAge.Location =
                new System.Drawing.Point(370, 144);

            this.lblAge.Name =
                "lblAge";

            this.lblAge.Size =
                new System.Drawing.Size(29, 17);

            this.lblAge.TabIndex = 14;

            this.lblAge.Text =
                "Age";

            // =========================================================
            // txtAge
            // =========================================================
            this.txtAge.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtAge.Location =
                new System.Drawing.Point(370, 166);

            this.txtAge.Name =
                "txtAge";

            this.txtAge.Size =
                new System.Drawing.Size(285, 25);

            this.txtAge.TabIndex = 15;

            // =========================================================
            // lblRole
            // =========================================================
            this.lblRole.AutoSize = true;

            this.lblRole.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblRole.ForeColor =
                System.Drawing.Color.FromArgb(
                    33,
                    37,
                    41);

            this.lblRole.Location =
                new System.Drawing.Point(370, 206);

            this.lblRole.Name =
                "lblRole";

            this.lblRole.Size =
                new System.Drawing.Size(34, 17);

            this.lblRole.TabIndex = 16;

            this.lblRole.Text =
                "Role";

            // =========================================================
            // txtRole
            // =========================================================
            this.txtRole.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtRole.Location =
                new System.Drawing.Point(370, 228);

            this.txtRole.Name =
                "txtRole";

            this.txtRole.Size =
                new System.Drawing.Size(285, 25);

            this.txtRole.TabIndex = 17;

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
                new System.Drawing.Point(370, 290);

            this.btnSave.Name =
                "btnSave";

            this.btnSave.Size =
                new System.Drawing.Size(135, 42);

            this.btnSave.TabIndex = 18;

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
                new System.Drawing.Point(520, 290);

            this.btnCancel.Name =
                "btnCancel";

            this.btnCancel.Size =
                new System.Drawing.Size(135, 42);

            this.btnCancel.TabIndex = 19;

            this.btnCancel.Text =
                "✖  CANCEL";

            this.btnCancel.UseVisualStyleBackColor =
                false;

            this.btnCancel.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnCancel.Click +=
                new System.EventHandler(
                    this.btnCancel_Click);

            // =========================================================
            // PlayerAddForm
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
                    700,
                    640);

            this.Controls.Add(
                this.pnlForm);

            this.Controls.Add(
                this.pnlHeader);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedDialog;

            this.MaximizeBox = false;

            this.MinimizeBox = false;

            this.Name =
                "PlayerAddForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text =
                "Add Player";

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

        private System.Windows.Forms.Label lblTeamID;
        private System.Windows.Forms.TextBox txtTeamID;

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Label lblInGameName;
        private System.Windows.Forms.TextBox txtInGameName;

        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;

        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;

        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtRole;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}