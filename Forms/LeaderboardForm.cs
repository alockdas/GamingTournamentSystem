using System;
using System.Drawing;
using System.Windows.Forms;
using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Forms
{
    public partial class LeaderboardForm : Form
    {
        private readonly LeaderboardService leaderboardService;
        private readonly AdminDashboard adminDashboard;

        
        // Constructor
        
        public LeaderboardForm(AdminDashboard dashboard)
        {
            InitializeComponent();

            adminDashboard = dashboard;
            leaderboardService = new LeaderboardService();

            LoadLeaderboard();
        }

        
        // Form Load
        
        private void LeaderboardForm_Load(object sender, EventArgs e)
        {
            LoadLeaderboard();
        }

        
        // Load Leaderboard
        
        private void LoadLeaderboard()
        {
            try
            {
                dgvLeaderboard.Rows.Clear();

                var teams =
                    leaderboardService.GetLeaderboard();

                int rank = 1;

                foreach (Team team in teams)
                {
                    dgvLeaderboard.Rows.Add(
                        rank,
                        team.TeamName,
                        team.MatchesPlayed,
                        team.Wins,
                        team.Losses,
                        team.Draws,
                        team.Points
                    );

                    rank++;
                }

                lblTeamCount.Text =
                    $"Total Teams: {teams.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load leaderboard.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        
        // BACK
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            adminDashboard.Show();

            this.Close();
        }
    }
}