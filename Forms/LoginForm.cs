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

            authenticationService =
                new AuthenticationService();
        }

        
        // LOGIN
        

        private void btnLogin_Click(
            object? sender,
            EventArgs e)
        {
            string username =
                txtUsername.Text.Trim();

            string password =
                txtPassword.Text;

            
            // VALIDATION
            

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
                
                // DATABASE LOGIN
                

                User? user =
                    authenticationService.Login(
                        username,
                        password);

                
                // INVALID LOGIN
                

                if (user == null)
                {
                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtPassword.Clear();

                    txtPassword.Focus();

                    return;
                }

                
                // ADMIN
                

                if (user.Role.Equals(
                    "Admin",
                    StringComparison.OrdinalIgnoreCase))
                {
                    AdminDashboard dashboard =
                        new AdminDashboard(user);

                    dashboard.FormClosed +=
                        (s, args) => this.Close();

                    dashboard.Show();

                    this.Hide();

                    return;
                }

                
                // PLAYER
                

                if (user.Role.Equals(
                    "Player",
                    StringComparison.OrdinalIgnoreCase))
                {
                    PlayerDashboard dashboard =
                        new PlayerDashboard(user);

                    dashboard.FormClosed +=
                        (s, args) => this.Close();

                    dashboard.Show();

                    this.Hide();

                    return;
                }

                
                // ORGANIZER
                

                if (user.Role.Equals(
                    "Organizer",
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Organizer Dashboard is not available yet.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                
                // UNKNOWN ROLE
                

                MessageBox.Show(
                    "Unknown user role.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to connect to the database or login.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        
        // EXIT
        

        private void btnExit_Click(
            object? sender,
            EventArgs e)
        {
            Application.Exit();
        }

        
        // LOGO
        

        private void lblLogo_Click(
            object? sender,
            EventArgs e)
        {
        }

        
        // DESCRIPTION
        

        private void lblDesc_Click(
            object? sender,
            EventArgs e)
        {
        }
    }
}