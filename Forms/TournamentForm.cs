using System;
using System.Drawing;
using System.Windows.Forms;
using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Forms
{
    public partial class TournamentForm : Form
    {
        private readonly TournamentService tournamentService;
        private readonly AdminDashboard adminDashboard;

        // =========================================================
        // Constructor
        // =========================================================
        public TournamentForm(AdminDashboard dashboard)
        {
            InitializeComponent();

            adminDashboard = dashboard;
            tournamentService = new TournamentService();

            LoadTournaments();
        }

        // =========================================================
        // Form Load
        // =========================================================
        private void TournamentForm_Load(object sender, EventArgs e)
        {
            LoadTournaments();
        }

        // =========================================================
        // Load All Tournaments
        // =========================================================
        private void LoadTournaments()
        {
            try
            {
                dgvTournaments.Rows.Clear();

                var tournaments =
                    tournamentService.GetAllTournaments();

                foreach (Tournament tournament in tournaments)
                {
                    dgvTournaments.Rows.Add(
                        tournament.TournamentID,
                        tournament.TournamentName,
                        tournament.GameName,
                        tournament.StartDate.ToString("yyyy-MM-dd"),
                        tournament.EndDate.ToString("yyyy-MM-dd"),
                        tournament.PrizePool.ToString("N2"),
                        tournament.Status
                    );
                }

                lblTournamentCount.Text =
                    $"Total Tournaments: {tournaments.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load tournaments.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // ADD TOURNAMENT
        // =========================================================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (TournamentAddForm addForm =
                   new TournamentAddForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadTournaments();
                }
            }
        }

        // =========================================================
        // UPDATE TOURNAMENT
        // =========================================================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTournaments.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a tournament first.",
                    "Update Tournament",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow row =
                dgvTournaments.SelectedRows[0];

            int tournamentID =
                Convert.ToInt32(row.Cells["colTournamentID"].Value);

            Tournament? selectedTournament = null;

            try
            {
                var tournaments =
                    tournamentService.GetAllTournaments();

                foreach (Tournament tournament in tournaments)
                {
                    if (tournament.TournamentID == tournamentID)
                    {
                        selectedTournament = tournament;
                        break;
                    }
                }

                if (selectedTournament == null)
                {
                    MessageBox.Show(
                        "Tournament not found.",
                        "Update Tournament",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                using (TournamentAddForm editForm =
                       new TournamentAddForm(selectedTournament))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadTournaments();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to update tournament.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // DELETE TOURNAMENT
        // =========================================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTournaments.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a tournament first.",
                    "Delete Tournament",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow row =
                dgvTournaments.SelectedRows[0];

            int tournamentID =
                Convert.ToInt32(row.Cells["colTournamentID"].Value);

            string tournamentName =
                row.Cells["colTournamentName"].Value?.ToString()
                ?? "this tournament";

            DialogResult result =
                MessageBox.Show(
                    $"Are you sure you want to delete\n\n" +
                    $"\"{tournamentName}\"?",
                    "Delete Tournament",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool deleted =
                    tournamentService.DeleteTournament(
                        tournamentID);

                if (deleted)
                {
                    MessageBox.Show(
                        "Tournament deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadTournaments();
                }
                else
                {
                    MessageBox.Show(
                        "Tournament could not be deleted.",
                        "Delete Tournament",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to delete tournament.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // BACK
        // =========================================================
        private void btnBack_Click(object sender, EventArgs e)
        {
            adminDashboard.Show();
            this.Close();
        }

        // =========================================================
        // Double Click Row
        // =========================================================
        private void dgvTournaments_CellDoubleClick(
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