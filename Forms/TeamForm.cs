using System;
using System.Drawing;
using System.Windows.Forms;
using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Forms
{
    public partial class TeamForm : Form
    {
        private readonly TeamService teamService;
        private readonly AdminDashboard adminDashboard;

        
        // Constructor
        
        public TeamForm(AdminDashboard dashboard)
        {
            InitializeComponent();

            adminDashboard = dashboard;
            teamService = new TeamService();

            LoadTeams();
        }

        
        // Form Load
        
        private void TeamForm_Load(object sender, EventArgs e)
        {
            LoadTeams();
        }

        
        // Load All Teams
        
        private void LoadTeams()
        {
            try
            {
                dgvTeams.Rows.Clear();

                var teams = teamService.GetAllTeams();

                foreach (Team team in teams)
                {
                    dgvTeams.Rows.Add(
                        team.TeamID,
                        team.TournamentID,
                        team.TeamName,
                        team.CaptainName,
                        team.GameName,
                        team.TotalPlayers,
                        team.CoachName,
                        team.MatchesPlayed,
                        team.Wins,
                        team.Losses,
                        team.Draws,
                        team.Points
                    );
                }

                lblTeamCount.Text =
                    $"Total Teams: {teams.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load teams.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        
        // ADD TEAM
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (TeamAddForm addForm =
                   new TeamAddForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadTeams();
                }
            }
        }

        
        // UPDATE TEAM
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a team first.",
                    "Update Team",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow row =
                dgvTeams.SelectedRows[0];

            int teamID =
                Convert.ToInt32(
                    row.Cells["colTeamID"].Value);

            Team? selectedTeam = null;

            try
            {
                var teams =
                    teamService.GetAllTeams();

                foreach (Team team in teams)
                {
                    if (team.TeamID == teamID)
                    {
                        selectedTeam = team;
                        break;
                    }
                }

                if (selectedTeam == null)
                {
                    MessageBox.Show(
                        "Team not found.",
                        "Update Team",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                using (TeamAddForm editForm =
                       new TeamAddForm(selectedTeam))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadTeams();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to update team.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        
        // DELETE TEAM
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a team first.",
                    "Delete Team",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow row =
                dgvTeams.SelectedRows[0];

            int teamID =
                Convert.ToInt32(
                    row.Cells["colTeamID"].Value);

            string teamName =
                row.Cells["colTeamName"].Value?.ToString()
                ?? "this team";

            DialogResult result =
                MessageBox.Show(
                    $"Are you sure you want to delete\n\n" +
                    $"\"{teamName}\"?",
                    "Delete Team",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool deleted =
                    teamService.DeleteTeam(teamID);

                if (deleted)
                {
                    MessageBox.Show(
                        "Team deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadTeams();
                }
                else
                {
                    MessageBox.Show(
                        "Team could not be deleted.",
                        "Delete Team",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to delete team.\n\n" +
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

        
        // Double Click Row
        
        private void dgvTeams_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnUpdate.PerformClick();
            }
        }
    }
}