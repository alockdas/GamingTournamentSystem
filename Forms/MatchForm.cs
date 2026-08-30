using System;
using System.Drawing;
using System.Windows.Forms;
using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Forms
{
    public partial class MatchForm : Form
    {
        private readonly MatchService matchService;
        private readonly AdminDashboard adminDashboard;

        
        // Constructor
        
        public MatchForm(AdminDashboard dashboard)
        {
            InitializeComponent();

            adminDashboard = dashboard;
            matchService = new MatchService();

            LoadMatches();
        }

        
        // Form Load
        
        private void MatchForm_Load(object sender, EventArgs e)
        {
            LoadMatches();
        }

        // =========================================================
        // Load All Matches
        // =========================================================
        private void LoadMatches()
        {
            try
            {
                dgvMatches.Rows.Clear();

                var matches = matchService.GetAllMatches();

                foreach (Match match in matches)
                {
                    dgvMatches.Rows.Add(
                        match.MatchID,
                        match.TournamentID,
                        match.Team1ID,
                        match.Team2ID,
                        match.MatchDate.ToString("yyyy-MM-dd"),
                        match.MatchTime.ToString(@"hh\:mm"),
                        match.Venue,
                        match.WinnerTeamID?.ToString() ?? "-",
                        match.Status
                    );
                }

                lblMatchCount.Text =
                    $"Total Matches: {matches.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load matches.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        
        // ADD MATCH
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MatchAddForm addForm =
                   new MatchAddForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadMatches();
                }
            }
        }

        
        // UPDATE MATCH
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a match first.",
                    "Update Match",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow row =
                dgvMatches.SelectedRows[0];

            int matchID =
                Convert.ToInt32(
                    row.Cells["colMatchID"].Value);

            Match? selectedMatch = null;

            try
            {
                var matches =
                    matchService.GetAllMatches();

                foreach (Match match in matches)
                {
                    if (match.MatchID == matchID)
                    {
                        selectedMatch = match;
                        break;
                    }
                }

                if (selectedMatch == null)
                {
                    MessageBox.Show(
                        "Match not found.",
                        "Update Match",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                using (MatchAddForm editForm =
                       new MatchAddForm(selectedMatch))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadMatches();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to update match.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        
        // DELETE MATCH
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a match first.",
                    "Delete Match",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow row =
                dgvMatches.SelectedRows[0];

            int matchID =
                Convert.ToInt32(
                    row.Cells["colMatchID"].Value);

            DialogResult result =
                MessageBox.Show(
                    $"Are you sure you want to delete Match ID {matchID}?",
                    "Delete Match",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool deleted =
                    matchService.DeleteMatch(matchID);

                if (deleted)
                {
                    MessageBox.Show(
                        "Match deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadMatches();
                }
                else
                {
                    MessageBox.Show(
                        "Match could not be deleted.",
                        "Delete Match",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to delete match.\n\n" +
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
        
        private void dgvMatches_CellDoubleClick(
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