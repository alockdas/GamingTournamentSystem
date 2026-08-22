using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Windows.Forms;

namespace GamingTournamentSystem.Forms
{
    public partial class MatchAddForm : Form
    {
        private readonly MatchService matchService;
        private readonly Match? editingMatch;

        // =========================================================
        // ADD Constructor
        // =========================================================
        public MatchAddForm()
        {
            InitializeComponent();

            matchService = new MatchService();
            editingMatch = null;

            lblFormTitle.Text = "➕ Add New Match";
            lblFormSubtitle.Text =
                "Enter the information below to schedule a new match.";

            cmbStatus.SelectedItem = "Scheduled";

            UpdateWinnerFieldState();
        }

        // =========================================================
        // UPDATE Constructor
        // =========================================================
        public MatchAddForm(Match match)
        {
            InitializeComponent();

            matchService = new MatchService();
            editingMatch = match;

            lblFormTitle.Text = "✏️ Update Match";
            lblFormSubtitle.Text =
                "Update the selected match information.";

            LoadMatchInformation();
        }

        // =========================================================
        // Load Existing Match Information
        // =========================================================
        private void LoadMatchInformation()
        {
            if (editingMatch == null)
                return;

            txtTournamentID.Text =
                editingMatch.TournamentID.ToString();

            txtTeam1ID.Text =
                editingMatch.Team1ID.ToString();

            txtTeam2ID.Text =
                editingMatch.Team2ID.ToString();

            txtMatchDate.Text =
                editingMatch.MatchDate.ToString("yyyy-MM-dd");

            txtMatchTime.Text =
                editingMatch.MatchTime.ToString(@"hh\:mm");

            txtVenue.Text =
                editingMatch.Venue;

            cmbStatus.SelectedItem =
                editingMatch.Status;

            if (editingMatch.WinnerTeamID.HasValue)
            {
                txtWinnerTeamID.Text =
                    editingMatch.WinnerTeamID.Value.ToString();
            }
            else
            {
                txtWinnerTeamID.Text = "";
            }

            UpdateWinnerFieldState();
        }

        // =========================================================
        // Status Changed
        // =========================================================
        private void cmbStatus_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            UpdateWinnerFieldState();
        }

        // =========================================================
        // Winner Field State
        // =========================================================
        private void UpdateWinnerFieldState()
        {
            if (cmbStatus == null ||
                txtWinnerTeamID == null)
            {
                return;
            }

            bool completed =
                cmbStatus.SelectedItem?.ToString() == "Completed";

            txtWinnerTeamID.Enabled = completed;

            if (!completed)
            {
                txtWinnerTeamID.Text = "";
            }
        }

        // =========================================================
        // SAVE
        // =========================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------
            // Tournament ID
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(
                    txtTournamentID.Text))
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

            if (tournamentID <= 0)
            {
                MessageBox.Show(
                    "Tournament ID must be greater than 0.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTournamentID.Focus();
                return;
            }

            // -----------------------------------------------------
            // Team 1 ID
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(
                    txtTeam1ID.Text))
            {
                MessageBox.Show(
                    "Please enter Team 1 ID.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTeam1ID.Focus();
                return;
            }

            if (!int.TryParse(
                    txtTeam1ID.Text.Trim(),
                    out int team1ID))
            {
                MessageBox.Show(
                    "Team 1 ID must be a valid number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTeam1ID.Focus();
                return;
            }

            // -----------------------------------------------------
            // Team 2 ID
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(
                    txtTeam2ID.Text))
            {
                MessageBox.Show(
                    "Please enter Team 2 ID.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTeam2ID.Focus();
                return;
            }

            if (!int.TryParse(
                    txtTeam2ID.Text.Trim(),
                    out int team2ID))
            {
                MessageBox.Show(
                    "Team 2 ID must be a valid number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTeam2ID.Focus();
                return;
            }

            if (team1ID == team2ID)
            {
                MessageBox.Show(
                    "Team 1 and Team 2 cannot be the same.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTeam2ID.Focus();
                return;
            }

            // -----------------------------------------------------
            // Match Date
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(
                    txtMatchDate.Text))
            {
                MessageBox.Show(
                    "Please enter Match Date.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMatchDate.Focus();
                return;
            }

            if (!DateTime.TryParseExact(
                    txtMatchDate.Text.Trim(),
                    "yyyy-MM-dd",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out DateTime matchDate))
            {
                MessageBox.Show(
                    "Invalid date!\n\n" +
                    "Use yyyy-MM-dd format.\n" +
                    "Example: 2026-08-30",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMatchDate.Focus();
                return;
            }

            // -----------------------------------------------------
            // Match Time
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(
                    txtMatchTime.Text))
            {
                MessageBox.Show(
                    "Please enter Match Time.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMatchTime.Focus();
                return;
            }

            if (!TimeSpan.TryParseExact(
                    txtMatchTime.Text.Trim(),
                    @"hh\:mm",
                    System.Globalization.CultureInfo.InvariantCulture,
                    out TimeSpan matchTime))
            {
                MessageBox.Show(
                    "Invalid time!\n\n" +
                    "Use HH:mm format.\n" +
                    "Example: 13:00",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMatchTime.Focus();
                return;
            }

            // -----------------------------------------------------
            // Venue
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(
                    txtVenue.Text))
            {
                MessageBox.Show(
                    "Please enter Venue.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtVenue.Focus();
                return;
            }

            // -----------------------------------------------------
            // Status
            // -----------------------------------------------------

            string status =
                cmbStatus.SelectedItem?.ToString()
                ?? "";

            if (string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show(
                    "Please select Match Status.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbStatus.Focus();
                return;
            }

            // -----------------------------------------------------
            // Winner Team ID
            // -----------------------------------------------------

            int? winnerTeamID = null;

            if (status == "Completed")
            {
                if (string.IsNullOrWhiteSpace(
                        txtWinnerTeamID.Text))
                {
                    MessageBox.Show(
                        "Please enter Winner Team ID for a completed match.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtWinnerTeamID.Focus();
                    return;
                }

                if (!int.TryParse(
                        txtWinnerTeamID.Text.Trim(),
                        out int winnerID))
                {
                    MessageBox.Show(
                        "Winner Team ID must be a valid number.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtWinnerTeamID.Focus();
                    return;
                }

                if (winnerID != team1ID &&
                    winnerID != team2ID)
                {
                    MessageBox.Show(
                        "Winner Team ID must be either Team 1 ID or Team 2 ID.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtWinnerTeamID.Focus();
                    return;
                }

                winnerTeamID = winnerID;
            }

            // -----------------------------------------------------
            // Create Match Object
            // -----------------------------------------------------

            Match match = new Match(
                editingMatch?.MatchID ?? 0,
                tournamentID,
                team1ID,
                team2ID,
                matchDate,
                matchTime,
                txtVenue.Text.Trim(),
                winnerTeamID,
                status,
                editingMatch?.IsLeaderboardUpdated ?? false
            );

            // -----------------------------------------------------
            // ADD / UPDATE
            // -----------------------------------------------------

            try
            {
                if (editingMatch == null)
                {
                    matchService.AddMatch(match);

                    MessageBox.Show(
                        "Match added successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    bool updated =
                        matchService.UpdateMatch(match);

                    if (!updated)
                    {
                        MessageBox.Show(
                            "Match could not be updated.",
                            "Update Match",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    MessageBox.Show(
                        "Match updated successfully!",
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
                    "Failed to save match.\n\n" +
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