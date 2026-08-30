namespace GamingTournamentSystem.Forms
{
    partial class TournamentAddForm
    {
        private System.ComponentModel.IContainer components = null;

        // =========================================================
        // Dispose
        // =========================================================
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // =========================================================
        // InitializeComponent
        // =========================================================
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblFormSubtitle = new Label();
            lblFormTitle = new Label();
            pnlContent = new Panel();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            txtPrizePool = new TextBox();
            lblPrizePool = new Label();
            dtpEndDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblStartDate = new Label();
            txtGameName = new TextBox();
            lblGameName = new Label();
            txtTournamentName = new TextBox();
            lblTournamentName = new Label();
            pnlButtons = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblFormSubtitle);
            pnlHeader.Controls.Add(lblFormTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 133);
            pnlHeader.TabIndex = 0;
            // 
            // lblFormSubtitle
            // 
            lblFormSubtitle.AutoSize = true;
            lblFormSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblFormSubtitle.ForeColor = Color.FromArgb(108, 117, 125);
            lblFormSubtitle.Location = new Point(38, 83);
            lblFormSubtitle.Name = "lblFormSubtitle";
            lblFormSubtitle.Size = new Size(246, 21);
            lblFormSubtitle.TabIndex = 1;
            lblFormSubtitle.Text = "Create a new gaming tournament.";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblFormTitle.Location = new Point(34, 24);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(371, 46);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Add New Tournament";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(244, 246, 249);
            pnlContent.Controls.Add(cmbStatus);
            pnlContent.Controls.Add(lblStatus);
            pnlContent.Controls.Add(txtPrizePool);
            pnlContent.Controls.Add(lblPrizePool);
            pnlContent.Controls.Add(dtpEndDate);
            pnlContent.Controls.Add(lblEndDate);
            pnlContent.Controls.Add(dtpStartDate);
            pnlContent.Controls.Add(lblStartDate);
            pnlContent.Controls.Add(txtGameName);
            pnlContent.Controls.Add(lblGameName);
            pnlContent.Controls.Add(txtTournamentName);
            pnlContent.Controls.Add(lblTournamentName);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 133);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(34, 40, 34, 40);
            pnlContent.Size = new Size(800, 560);
            pnlContent.TabIndex = 1;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Upcoming", "Running", "Completed", "Cancelled" });
            cmbStatus.Location = new Point(423, 316);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(342, 31);
            cmbStatus.TabIndex = 11;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(33, 37, 41);
            lblStatus.Location = new Point(423, 285);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(55, 21);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            // 
            // txtPrizePool
            // 
            txtPrizePool.BackColor = Color.White;
            txtPrizePool.BorderStyle = BorderStyle.FixedSingle;
            txtPrizePool.Font = new Font("Segoe UI", 10F);
            txtPrizePool.Location = new Point(34, 316);
            txtPrizePool.Margin = new Padding(3, 4, 3, 4);
            txtPrizePool.Name = "txtPrizePool";
            txtPrizePool.Size = new Size(343, 30);
            txtPrizePool.TabIndex = 9;
            txtPrizePool.Text = "0.00";
            // 
            // lblPrizePool
            // 
            lblPrizePool.AutoSize = true;
            lblPrizePool.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblPrizePool.ForeColor = Color.FromArgb(33, 37, 41);
            lblPrizePool.Location = new Point(34, 285);
            lblPrizePool.Name = "lblPrizePool";
            lblPrizePool.Size = new Size(81, 21);
            lblPrizePool.TabIndex = 8;
            lblPrizePool.Text = "Prize Pool";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 10F);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(423, 232);
            dtpEndDate.Margin = new Padding(3, 4, 3, 4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(342, 30);
            dtpEndDate.TabIndex = 7;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblEndDate.ForeColor = Color.FromArgb(33, 37, 41);
            lblEndDate.Location = new Point(423, 201);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(75, 21);
            lblEndDate.TabIndex = 6;
            lblEndDate.Text = "End Date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 10F);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(34, 232);
            dtpStartDate.Margin = new Padding(3, 4, 3, 4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(342, 30);
            dtpStartDate.TabIndex = 5;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblStartDate.ForeColor = Color.FromArgb(33, 37, 41);
            lblStartDate.Location = new Point(34, 201);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(83, 21);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "Start Date";
            // 
            // txtGameName
            // 
            txtGameName.BackColor = Color.White;
            txtGameName.BorderStyle = BorderStyle.FixedSingle;
            txtGameName.Font = new Font("Segoe UI", 10F);
            txtGameName.Location = new Point(34, 148);
            txtGameName.Margin = new Padding(3, 4, 3, 4);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(731, 30);
            txtGameName.TabIndex = 3;
            // 
            // lblGameName
            // 
            lblGameName.AutoSize = true;
            lblGameName.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblGameName.ForeColor = Color.FromArgb(33, 37, 41);
            lblGameName.Location = new Point(34, 117);
            lblGameName.Name = "lblGameName";
            lblGameName.Size = new Size(99, 21);
            lblGameName.TabIndex = 2;
            lblGameName.Text = "Game Name";
            // 
            // txtTournamentName
            // 
            txtTournamentName.BackColor = Color.White;
            txtTournamentName.BorderStyle = BorderStyle.FixedSingle;
            txtTournamentName.Font = new Font("Segoe UI", 10F);
            txtTournamentName.Location = new Point(34, 64);
            txtTournamentName.Margin = new Padding(3, 4, 3, 4);
            txtTournamentName.Name = "txtTournamentName";
            txtTournamentName.Size = new Size(731, 30);
            txtTournamentName.TabIndex = 1;
            // 
            // lblTournamentName
            // 
            lblTournamentName.AutoSize = true;
            lblTournamentName.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblTournamentName.ForeColor = Color.FromArgb(33, 37, 41);
            lblTournamentName.Location = new Point(34, 33);
            lblTournamentName.Name = "lblTournamentName";
            lblTournamentName.Size = new Size(144, 21);
            lblTournamentName.TabIndex = 0;
            lblTournamentName.Text = "Tournament Name";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.White;
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnSave);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 693);
            pnlButtons.Margin = new Padding(3, 4, 3, 4);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(800, 107);
            pnlButtons.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.LightGray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(33, 37, 41);
            btnCancel.Location = new Point(651, 27);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 56);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(30, 109, 235);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(423, 27);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(217, 56);
            btnSave.TabIndex = 0;
            btnSave.Text = "➕  CREATE TOURNAMENT";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // TournamentAddForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 800);
            Controls.Add(pnlContent);
            Controls.Add(pnlButtons);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TournamentAddForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tournament";
            Load += TournamentAddForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        // =========================================================
        // Fields
        // =========================================================

        private System.Windows.Forms.Panel pnlHeader;

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFormSubtitle;

        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.TextBox txtTournamentName;

        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.TextBox txtGameName;

        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;

        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;

        private System.Windows.Forms.Label lblPrizePool;
        private System.Windows.Forms.TextBox txtPrizePool;

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;

        private System.Windows.Forms.Panel pnlButtons;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}