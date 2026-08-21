namespace GamingTournamentSystem.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlLeftBranding;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblDesc;

        private System.Windows.Forms.Panel pnlRightLogin;
        private System.Windows.Forms.Label lblFooter;

        private System.Windows.Forms.Panel cardLogin;
        private System.Windows.Forms.Label lblLoginHeader;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlLeftBranding = new Panel();
            lblDesc = new Label();
            lblSubtitle = new Label();
            lblMainTitle = new Label();
            pnlRightLogin = new Panel();
            lblFooter = new Label();
            cardLogin = new Panel();
            btnExit = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblLoginHeader = new Label();
            lblLogo = new Label();
            pnlLeftBranding.SuspendLayout();
            pnlRightLogin.SuspendLayout();
            cardLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeftBranding
            // 
            pnlLeftBranding.BackColor = Color.White;
            pnlLeftBranding.Controls.Add(lblDesc);
            pnlLeftBranding.Controls.Add(lblSubtitle);
            pnlLeftBranding.Controls.Add(lblMainTitle);
            pnlLeftBranding.Controls.Add(lblLogo);
            pnlLeftBranding.Dock = DockStyle.Left;
            pnlLeftBranding.Location = new Point(0, 0);
            pnlLeftBranding.Margin = new Padding(3, 4, 3, 4);
            pnlLeftBranding.Name = "pnlLeftBranding";
            pnlLeftBranding.Size = new Size(526, 746);
            pnlLeftBranding.TabIndex = 1;
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Segoe UI", 10F);
            lblDesc.ForeColor = Color.FromArgb(108, 117, 125);
            lblDesc.Location = new Point(46, 456);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(434, 66);
            lblDesc.TabIndex = 0;
            lblDesc.Text = "Manage tournaments, teams, players and matches efficiently.";
            lblDesc.TextAlign = ContentAlignment.MiddleCenter;
            lblDesc.Click += lblDesc_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 18F);
            lblSubtitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblSubtitle.Location = new Point(23, 375);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(480, 54);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Management System";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMainTitle
            // 
            lblMainTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblMainTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblMainTitle.Location = new Point(23, 312);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(480, 60);
            lblMainTitle.TabIndex = 2;
            lblMainTitle.Text = "Gaming Tournament";
            lblMainTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRightLogin
            // 
            pnlRightLogin.BackColor = Color.FromArgb(244, 246, 249);
            pnlRightLogin.Controls.Add(lblFooter);
            pnlRightLogin.Controls.Add(cardLogin);
            pnlRightLogin.Dock = DockStyle.Fill;
            pnlRightLogin.Location = new Point(526, 0);
            pnlRightLogin.Margin = new Padding(3, 4, 3, 4);
            pnlRightLogin.Name = "pnlRightLogin";
            pnlRightLogin.Size = new Size(525, 746);
            pnlRightLogin.TabIndex = 0;
            // 
            // lblFooter
            // 
            lblFooter.Dock = DockStyle.Bottom;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.FromArgb(108, 117, 125);
            lblFooter.Location = new Point(0, 692);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(525, 54);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "© 2026 Gaming Tournament System";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardLogin
            // 
            cardLogin.BackColor = Color.White;
            cardLogin.BorderStyle = BorderStyle.FixedSingle;
            cardLogin.Controls.Add(btnExit);
            cardLogin.Controls.Add(btnLogin);
            cardLogin.Controls.Add(txtPassword);
            cardLogin.Controls.Add(lblPassword);
            cardLogin.Controls.Add(txtUsername);
            cardLogin.Controls.Add(lblUsername);
            cardLogin.Controls.Add(lblLoginHeader);
            cardLogin.Location = new Point(69, 106);
            cardLogin.Margin = new Padding(3, 4, 3, 4);
            cardLogin.Name = "cardLogin";
            cardLogin.Size = new Size(389, 506);
            cardLogin.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderColor = Color.LightGray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(73, 80, 87);
            btnExit.Location = new Point(34, 388);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(320, 56);
            btnExit.TabIndex = 0;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(30, 109, 235);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(34, 300);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(320, 60);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(34, 225);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '?';
            txtPassword.Size = new Size(320, 32);
            txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(73, 80, 87);
            lblPassword.Location = new Point(34, 194);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 21);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(34, 131);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(320, 27);
            txtUsername.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.FromArgb(73, 80, 87);
            lblUsername.Location = new Point(34, 100);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            // 
            // lblLoginHeader
            // 
            lblLoginHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLoginHeader.ForeColor = Color.FromArgb(33, 37, 41);
            lblLoginHeader.Location = new Point(34, 34);
            lblLoginHeader.Name = "lblLoginHeader";
            lblLoginHeader.Size = new Size(320, 54);
            lblLoginHeader.TabIndex = 6;
            lblLoginHeader.Text = "User Login";
            lblLoginHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI Emoji", 60F);
            lblLogo.ForeColor = Color.FromArgb(30, 109, 235);
            lblLogo.Location = new Point(149, 100);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(229, 175);
            lblLogo.TabIndex = 3;
            lblLogo.Text = "??";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            lblLogo.Click += lblLogo_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 746);
            Controls.Add(pnlRightLogin);
            Controls.Add(pnlLeftBranding);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gaming Tournament Management System";
            pnlLeftBranding.ResumeLayout(false);
            pnlRightLogin.ResumeLayout(false);
            cardLogin.ResumeLayout(false);
            cardLogin.PerformLayout();
            ResumeLayout(false);
        }
        private Label lblLogo;
    }
}
