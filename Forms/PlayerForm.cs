using System;
using System.Windows.Forms;
using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Forms
{
    public partial class PlayerForm : Form
    {
        private readonly PlayerService playerService;
        private readonly AdminDashboard adminDashboard;

        // =========================================================
        // Constructor
        // =========================================================
        public PlayerForm(AdminDashboard dashboard)
        {
            InitializeComponent();

            adminDashboard = dashboard;
            playerService = new PlayerService();

            LoadPlayers();
        }

        // =========================================================
        // Form Load
        // =========================================================
        private void PlayerForm_Load(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        // =========================================================
        // Load All Players
        // =========================================================
        private void LoadPlayers()
        {
            try
            {
                dgvPlayers.Rows.Clear();

                var players = playerService.GetAllPlayers();

                foreach (Player player in players)
                {
                    dgvPlayers.Rows.Add(
                        player.PlayerID,
                        player.TeamID,
                        player.FullName,
                        player.Username,
                        player.Email,
                        player.InGameName,
                        player.Phone,
                        player.Age,
                        player.Role
                    );
                }

                lblPlayerCount.Text =
                    $"Total Players: {players.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load players.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // ADD PLAYER
        // =========================================================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (PlayerAddForm addForm =
                   new PlayerAddForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadPlayers();
                }
            }
        }

        // =========================================================
        // UPDATE PLAYER
        // =========================================================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPlayers.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a player first.",
                    "Update Player",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow row =
                dgvPlayers.SelectedRows[0];

            int playerID =
                Convert.ToInt32(
                    row.Cells["colPlayerID"].Value);

            Player? selectedPlayer = null;

            try
            {
                var players =
                    playerService.GetAllPlayers();

                foreach (Player player in players)
                {
                    if (player.PlayerID == playerID)
                    {
                        selectedPlayer = player;
                        break;
                    }
                }

                if (selectedPlayer == null)
                {
                    MessageBox.Show(
                        "Player not found.",
                        "Update Player",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                using (PlayerAddForm editForm =
                       new PlayerAddForm(selectedPlayer))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadPlayers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to update player.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // DELETE PLAYER
        // =========================================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPlayers.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a player first.",
                    "Delete Player",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow row =
                dgvPlayers.SelectedRows[0];

            int playerID =
                Convert.ToInt32(
                    row.Cells["colPlayerID"].Value);

            string playerName =
                row.Cells["colFullName"].Value?.ToString()
                ?? "this player";

            DialogResult result =
                MessageBox.Show(
                    $"Are you sure you want to delete\n\n" +
                    $"\"{playerName}\"?",
                    "Delete Player",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool deleted =
                    playerService.DeletePlayer(playerID);

                if (deleted)
                {
                    MessageBox.Show(
                        "Player deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadPlayers();
                }
                else
                {
                    MessageBox.Show(
                        "Player could not be deleted.",
                        "Delete Player",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to delete player.\n\n" +
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
        private void dgvPlayers_CellDoubleClick(
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