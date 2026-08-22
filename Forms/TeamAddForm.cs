using System;
using System.Drawing;
using System.Windows.Forms;
using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Forms
{
    public partial class TeamAddForm : Form
    {
        private readonly TeamService teamService;
        private readonly Team? editingTeam;

        // =========================================================
        // ADD Constructor
        // =========================================================
        public TeamAddForm()
        {
            InitializeComponent();

            teamService = new TeamService();
            editingTeam = null;

            lblFormTitle.Text = "➕ Add New Team";
            lblFormSubtitle.Text =
                "Enter the information below to register a new team.";
        }

        // =========================================================
        // UPDATE Constructor
        // =========================================================
        public TeamAddForm(Team team)
        {
            InitializeComponent();

            teamService = new TeamService();
            editingTeam = team;

            lblFormTitle.Text = "✏️ Update Team";
            lblFormSubtitle.Text =
                "Update the selected team's information.";

            LoadTeamInformation();
        }

        // =========================================================
        // Load Existing Team Information
        // =========================================================
        private void LoadTeamInformation()
        {
            if (editingTeam == null)
                return;

            txtTournamentID.Text =
                editingTeam.TournamentID.ToString();

            txtTeamName.Text =
                editingTeam.TeamName;

            txtCaptainName.Text =
                editingTeam.CaptainName;

            txtGameName.Text =
                editingTeam.GameName;

            txtTotalPlayers.Text =
                editingTeam.TotalPlayers.ToString();

            txtCoachName.Text =
                editingTeam.CoachName;
        }

        // =========================================================
        // SAVE
        // =========================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------
            // Validation
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(txtTournamentID.Text))
            {
                MessageBox.Show(
                    "Please enter Tournament ID.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTournamentID.Focus();
                return;
            }

            if (!int.TryParse(
                    txtTournamentID.Text.Trim(),
                    out int tournamentID))
            {
                MessageBox.Show(
                    "Tournament ID must be a valid number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTournamentID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTeamName.Text))
            {
                MessageBox.Show(
                    "Please enter Team Name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTeamName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCaptainName.Text))
            {
                MessageBox.Show(
                    "Please enter Captain Name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCaptainName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGameName.Text))
            {
                MessageBox.Show(
                    "Please enter Game Name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtGameName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTotalPlayers.Text))
            {
                MessageBox.Show(
                    "Please enter Total Players.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTotalPlayers.Focus();
                return;
            }

            if (!int.TryParse(
                    txtTotalPlayers.Text.Trim(),
                    out int totalPlayers))
            {
                MessageBox.Show(
                    "Total Players must be a valid number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTotalPlayers.Focus();
                return;
            }

            if (totalPlayers <= 0)
            {
                MessageBox.Show(
                    "Total Players must be greater than 0.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTotalPlayers.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCoachName.Text))
            {
                MessageBox.Show(
                    "Please enter Coach Name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCoachName.Focus();
                return;
            }

            // -----------------------------------------------------
            // Create Team Object
            // -----------------------------------------------------

            Team team = new Team(
                editingTeam?.TeamID ?? 0,
                tournamentID,
                txtTeamName.Text.Trim(),
                txtCaptainName.Text.Trim(),
                txtGameName.Text.Trim(),
                totalPlayers,
                txtCoachName.Text.Trim(),
                editingTeam?.MatchesPlayed ?? 0,
                editingTeam?.Wins ?? 0,
                editingTeam?.Losses ?? 0,
                editingTeam?.Draws ?? 0,
                editingTeam?.Points ?? 0
            );

            // -----------------------------------------------------
            // ADD
            // -----------------------------------------------------

            try
            {
                if (editingTeam == null)
                {
                    teamService.AddTeam(team);

                    MessageBox.Show(
                        "Team added successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                // -------------------------------------------------
                // UPDATE
                // -------------------------------------------------

                else
                {
                    bool updated =
                        teamService.UpdateTeam(team);

                    if (!updated)
                    {
                        MessageBox.Show(
                            "Team could not be updated.",
                            "Update Team",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    MessageBox.Show(
                        "Team updated successfully!",
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
                    "Failed to save team.\n\n" +
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