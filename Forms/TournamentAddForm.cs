using System;
using System.Drawing;
using System.Windows.Forms;
using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Forms
{
    public partial class TournamentAddForm : Form
    {
        private readonly TournamentService tournamentService;
        private readonly Tournament? editingTournament;

        // =========================================================
        // ADD CONSTRUCTOR
        // =========================================================
        public TournamentAddForm()
        {
            InitializeComponent();

            tournamentService = new TournamentService();
            editingTournament = null;

            lblFormTitle.Text = "Add New Tournament";
            lblFormSubtitle.Text =
                "Create a new gaming tournament.";

            btnSave.Text = "➕  CREATE TOURNAMENT";

            LoadDefaultValues();
        }

        // =========================================================
        // UPDATE CONSTRUCTOR
        // =========================================================
        public TournamentAddForm(Tournament tournament)
        {
            InitializeComponent();

            tournamentService = new TournamentService();
            editingTournament = tournament;

            lblFormTitle.Text = "Update Tournament";
            lblFormSubtitle.Text =
                "Update tournament information.";

            btnSave.Text = "💾  UPDATE TOURNAMENT";

            LoadTournamentData();
        }

        // =========================================================
        // Default Values
        // =========================================================
        private void LoadDefaultValues()
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddDays(1);

            txtPrizePool.Text = "0.00";

            cmbStatus.SelectedIndex = 0;
        }

        // =========================================================
        // Load Existing Tournament
        // =========================================================
        private void LoadTournamentData()
        {
            if (editingTournament == null)
            {
                return;
            }

            txtTournamentName.Text =
                editingTournament.TournamentName;

            txtGameName.Text =
                editingTournament.GameName;

            dtpStartDate.Value =
                editingTournament.StartDate;

            dtpEndDate.Value =
                editingTournament.EndDate;

            txtPrizePool.Text =
                editingTournament.PrizePool.ToString("0.00");

            int statusIndex =
                cmbStatus.Items.IndexOf(
                    editingTournament.Status);

            if (statusIndex >= 0)
            {
                cmbStatus.SelectedIndex = statusIndex;
            }
            else
            {
                cmbStatus.SelectedIndex = 0;
            }
        }

        // =========================================================
        // Form Load
        // =========================================================
        private void TournamentAddForm_Load(object sender, EventArgs e)
        {
            if (editingTournament == null)
            {
                txtTournamentName.Focus();
            }
        }

        // =========================================================
        // SAVE / UPDATE
        // =========================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------
            // Validate Tournament Name
            // -----------------------------------------------------
            string tournamentName =
                txtTournamentName.Text.Trim();

            if (string.IsNullOrWhiteSpace(tournamentName))
            {
                MessageBox.Show(
                    "Please enter tournament name.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTournamentName.Focus();
                return;
            }

            // -----------------------------------------------------
            // Validate Game Name
            // -----------------------------------------------------
            string gameName =
                txtGameName.Text.Trim();

            if (string.IsNullOrWhiteSpace(gameName))
            {
                MessageBox.Show(
                    "Please enter game name.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtGameName.Focus();
                return;
            }

            // -----------------------------------------------------
            // Validate Dates
            // -----------------------------------------------------
            DateTime startDate =
                dtpStartDate.Value.Date;

            DateTime endDate =
                dtpEndDate.Value.Date;

            if (endDate < startDate)
            {
                MessageBox.Show(
                    "End date cannot be earlier than start date.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dtpEndDate.Focus();
                return;
            }

            // -----------------------------------------------------
            // Validate Prize Pool
            // -----------------------------------------------------
            if (!decimal.TryParse(
                    txtPrizePool.Text.Trim(),
                    out decimal prizePool))
            {
                MessageBox.Show(
                    "Please enter a valid prize pool.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrizePool.Focus();
                return;
            }

            if (prizePool < 0)
            {
                MessageBox.Show(
                    "Prize pool cannot be negative.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrizePool.Focus();
                return;
            }

            // -----------------------------------------------------
            // Validate Status
            // -----------------------------------------------------
            if (cmbStatus.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select tournament status.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbStatus.Focus();
                return;
            }

            string status =
                cmbStatus.SelectedItem?.ToString()
                ?? "Upcoming";

            try
            {
                // =================================================
                // UPDATE EXISTING TOURNAMENT
                // =================================================
                if (editingTournament != null)
                {
                    editingTournament.TournamentName =
                        tournamentName;

                    editingTournament.GameName =
                        gameName;

                    editingTournament.StartDate =
                        startDate;

                    editingTournament.EndDate =
                        endDate;

                    editingTournament.PrizePool =
                        prizePool;

                    editingTournament.Status =
                        status;

                    bool updated =
                        tournamentService.UpdateTournament(
                            editingTournament);

                    if (updated)
                    {
                        MessageBox.Show(
                            "Tournament updated successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.DialogResult =
                            DialogResult.OK;

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Tournament could not be updated.",
                            "Update Tournament",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }

                // =================================================
                // CREATE NEW TOURNAMENT
                // =================================================
                else
                {
                    Tournament tournament =
                        new Tournament
                        {
                            TournamentName =
                                tournamentName,

                            GameName =
                                gameName,

                            StartDate =
                                startDate,

                            EndDate =
                                endDate,

                            PrizePool =
                                prizePool,

                            Status =
                                status
                        };

                    bool created =
                        tournamentService.AddTournament(
                            tournament);

                    if (created)
                    {
                        MessageBox.Show(
                            "Tournament created successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.DialogResult =
                            DialogResult.OK;

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Tournament could not be created.",
                            "Add Tournament",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database operation failed.\n\n" +
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
            this.DialogResult =
                DialogResult.Cancel;

            this.Close();
        }
    }
}