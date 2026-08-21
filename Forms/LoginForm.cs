using System;
using System.Windows.Forms;
using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthenticationService authenticationService;

        public LoginForm()
        {
            InitializeComponent();

            authenticationService = new AuthenticationService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // =========================
            // Validation
            // =========================

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Please enter your username.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            try
            {
                // =========================
                // Backend Login
                // =========================

                User? user = authenticationService.Login(
                    username,
                    password);

                // =========================
                // Login Successful
                // =========================

                if (user != null)
                {
                    MessageBox.Show(
                        $"Welcome, {user.FullName}!\nRole: {user.Role}",
                        "Login Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // =========================
                    // ADMIN LOGIN
                    // =========================

                    if (user.Role.Equals(
                        "Admin",
                        StringComparison.OrdinalIgnoreCase))
                    {
                        AdminDashboard dashboard =
                            new AdminDashboard(user);

                        // When Dashboard closes,
                        // close the LoginForm as well.
                        dashboard.FormClosed +=
                            (s, args) => this.Close();

                        // Show Dashboard
                        dashboard.Show();

                        // Hide Login Form
                        this.Hide();
                    }
                    else
                    {
                        // =========================
                        // NORMAL USER LOGIN
                        // =========================

                        MessageBox.Show(
                            "User Dashboard is not available yet.",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // =========================
                    // Login Failed
                    // =========================

                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                // =========================
                // Database / Login Error
                // =========================

                MessageBox.Show(
                    "Unable to connect to the database or login.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // EXIT BUTTON
        // =========================

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // =========================
        // LOGO CLICK
        // =========================

        private void lblLogo_Click(object sender, EventArgs e)
        {
            // No action required
        }

        // =========================
        // DESCRIPTION CLICK
        // =========================

        private void lblDesc_Click(object sender, EventArgs e)
        {
            // No action required
        }
    }
}