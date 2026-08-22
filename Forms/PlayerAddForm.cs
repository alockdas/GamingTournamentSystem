using System;
using System.Windows.Forms;
using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Forms
{
    public partial class PlayerAddForm : Form
    {
        private readonly PlayerService playerService;
        private readonly Player? editingPlayer;

        // =========================================================
        // ADD Constructor
        // =========================================================
        public PlayerAddForm()
        {
            InitializeComponent();

            playerService = new PlayerService();
            editingPlayer = null;

            lblFormTitle.Text = "➕ Add New Player";
            lblFormSubtitle.Text =
                "Create a player account and assign the player to a team.";
        }

        // =========================================================
        // UPDATE Constructor
        // =========================================================
        public PlayerAddForm(Player player)
        {
            InitializeComponent();

            playerService = new PlayerService();
            editingPlayer = player;

            lblFormTitle.Text = "✏️ Update Player";
            lblFormSubtitle.Text =
                "Update the selected player's information.";

            LoadPlayerInformation();
        }

        // =========================================================
        // Load Existing Player
        // =========================================================
        private void LoadPlayerInformation()
        {
            if (editingPlayer == null)
                return;

            txtTeamID.Text =
                editingPlayer.TeamID.ToString();

            txtFullName.Text =
                editingPlayer.FullName;

            txtUsername.Text =
                editingPlayer.Username;

            txtEmail.Text =
                editingPlayer.Email;

            txtPassword.Text =
                editingPlayer.Password;

            txtInGameName.Text =
                editingPlayer.InGameName;

            txtPhone.Text =
                editingPlayer.Phone;

            txtAge.Text =
                editingPlayer.Age.ToString();

            txtRole.Text =
                editingPlayer.Role;
        }

        // =========================================================
        // SAVE
        // =========================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------
            // Team ID
            // -----------------------------------------------------
            if (string.IsNullOrWhiteSpace(txtTeamID.Text))
            {
                MessageBox.Show(
                    "Please enter Team ID.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTeamID.Focus();
                return;
            }

            if (!int.TryParse(
                    txtTeamID.Text.Trim(),
                    out int teamID))
            {
                MessageBox.Show(
                    "Team ID must be a valid number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTeamID.Focus();
                return;
            }

            if (teamID <= 0)
            {
                MessageBox.Show(
                    "Team ID must be greater than 0.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTeamID.Focus();
                return;
            }

            // -----------------------------------------------------
            // Full Name
            // -----------------------------------------------------
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show(
                    "Please enter Full Name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFullName.Focus();
                return;
            }

            // -----------------------------------------------------
            // Username
            // -----------------------------------------------------
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show(
                    "Please enter Username.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsername.Focus();
                return;
            }

            // -----------------------------------------------------
            // Email
            // -----------------------------------------------------
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show(
                    "Please enter Email.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return;
            }

            // -----------------------------------------------------
            // Password
            // -----------------------------------------------------
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(
                    "Please enter Password.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            // -----------------------------------------------------
            // In-Game Name
            // -----------------------------------------------------
            if (string.IsNullOrWhiteSpace(txtInGameName.Text))
            {
                MessageBox.Show(
                    "Please enter In-Game Name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtInGameName.Focus();
                return;
            }

            // -----------------------------------------------------
            // Phone
            // -----------------------------------------------------
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show(
                    "Please enter Phone.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPhone.Focus();
                return;
            }

            // -----------------------------------------------------
            // Age
            // -----------------------------------------------------
            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show(
                    "Please enter Age.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAge.Focus();
                return;
            }

            if (!int.TryParse(
                    txtAge.Text.Trim(),
                    out int age))
            {
                MessageBox.Show(
                    "Age must be a valid number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAge.Focus();
                return;
            }

            if (age <= 0)
            {
                MessageBox.Show(
                    "Age must be greater than 0.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAge.Focus();
                return;
            }

            // -----------------------------------------------------
            // Role
            // -----------------------------------------------------
            if (string.IsNullOrWhiteSpace(txtRole.Text))
            {
                MessageBox.Show(
                    "Please enter Role.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtRole.Focus();
                return;
            }

            // -----------------------------------------------------
            // Create Player Object
            // -----------------------------------------------------
            Player player;

            if (editingPlayer == null)
            {
                player = new Player(
                    teamID,
                    txtFullName.Text.Trim(),
                    txtUsername.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtPassword.Text.Trim(),
                    txtInGameName.Text.Trim(),
                    txtPhone.Text.Trim(),
                    age,
                    txtRole.Text.Trim()
                );
            }
            else
            {
                player = new Player(
                    editingPlayer.PlayerID,
                    editingPlayer.UserID,
                    teamID,
                    txtFullName.Text.Trim(),
                    txtUsername.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtPassword.Text.Trim(),
                    txtInGameName.Text.Trim(),
                    txtPhone.Text.Trim(),
                    age,
                    txtRole.Text.Trim()
                );
            }

            // -----------------------------------------------------
            // ADD / UPDATE
            // -----------------------------------------------------
            try
            {
                if (editingPlayer == null)
                {
                    // AddPlayer() is VOID
                    playerService.AddPlayer(player);

                    MessageBox.Show(
                        "Player added successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    bool updated =
                        playerService.UpdatePlayer(player);

                    if (!updated)
                    {
                        MessageBox.Show(
                            "Player could not be updated.",
                            "Update Player",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    MessageBox.Show(
                        "Player updated successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to save player.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // CANCEL
        // =========================================================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}