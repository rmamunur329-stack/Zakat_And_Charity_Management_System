namespace Zakat_And_Charity_Management
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSystemOverview = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuickAction = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnManageBeneficiaries = new System.Windows.Forms.Button();
            this.btnManageDonations = new System.Windows.Forms.Button();
            this.btnManageCampaigns = new System.Windows.Forms.Button();
            this.btnDistribution = new System.Windows.Forms.Button();
            this.btnEligibleFilter = new System.Windows.Forms.Button();
            this.btnDonorLeaderboard = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.lblTotalDonors = new System.Windows.Forms.Label();
            this.lblBeneficiaries = new System.Windows.Forms.Label();
            this.lblZakatCollected = new System.Windows.Forms.Label();
            this.lblCharityCollected = new System.Windows.Forms.Label();
            this.lblDistributed = new System.Windows.Forms.Label();
            this.lblActiveCampaigns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSystemOverview
            // 
            this.lblSystemOverview.AutoSize = true;
            this.lblSystemOverview.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemOverview.Location = new System.Drawing.Point(12, 68);
            this.lblSystemOverview.Name = "lblSystemOverview";
            this.lblSystemOverview.Size = new System.Drawing.Size(185, 25);
            this.lblSystemOverview.TabIndex = 1;
            this.lblSystemOverview.Text = "📊System Overview";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Green;
            this.lblTitle.Location = new System.Drawing.Point(106, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(572, 38);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "🕌 Zakat And Charity Mangement System";
            // 
            // lblQuickAction
            // 
            this.lblQuickAction.AutoSize = true;
            this.lblQuickAction.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickAction.Location = new System.Drawing.Point(12, 239);
            this.lblQuickAction.Name = "lblQuickAction";
            this.lblQuickAction.Size = new System.Drawing.Size(178, 25);
            this.lblQuickAction.TabIndex = 3;
            this.lblQuickAction.Text = "⚡QUICK ACTIONS";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(724, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 35);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "🔓Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUser.ForeColor = System.Drawing.Color.Green;
            this.btnManageUser.Location = new System.Drawing.Point(40, 311);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(150, 119);
            this.btnManageUser.TabIndex = 5;
            this.btnManageUser.Text = "   👥    Manage Users";
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click_1);
            // 
            // btnManageBeneficiaries
            // 
            this.btnManageBeneficiaries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBeneficiaries.ForeColor = System.Drawing.Color.Green;
            this.btnManageBeneficiaries.Location = new System.Drawing.Point(249, 311);
            this.btnManageBeneficiaries.Name = "btnManageBeneficiaries";
            this.btnManageBeneficiaries.Size = new System.Drawing.Size(150, 119);
            this.btnManageBeneficiaries.TabIndex = 6;
            this.btnManageBeneficiaries.Text = "🤲 Manage Beneficiaries";
            this.btnManageBeneficiaries.UseVisualStyleBackColor = true;
            // 
            // btnManageDonations
            // 
            this.btnManageDonations.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDonations.ForeColor = System.Drawing.Color.Green;
            this.btnManageDonations.Location = new System.Drawing.Point(448, 311);
            this.btnManageDonations.Name = "btnManageDonations";
            this.btnManageDonations.Size = new System.Drawing.Size(150, 119);
            this.btnManageDonations.TabIndex = 7;
            this.btnManageDonations.Text = " 💰 Manage Donations";
            this.btnManageDonations.UseVisualStyleBackColor = true;
            // 
            // btnManageCampaigns
            // 
            this.btnManageCampaigns.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCampaigns.ForeColor = System.Drawing.Color.Green;
            this.btnManageCampaigns.Location = new System.Drawing.Point(644, 311);
            this.btnManageCampaigns.Name = "btnManageCampaigns";
            this.btnManageCampaigns.Size = new System.Drawing.Size(150, 119);
            this.btnManageCampaigns.TabIndex = 8;
            this.btnManageCampaigns.Text = "📢 Manage Campaigns";
            this.btnManageCampaigns.UseVisualStyleBackColor = true;
            // 
            // btnDistribution
            // 
            this.btnDistribution.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistribution.ForeColor = System.Drawing.Color.Green;
            this.btnDistribution.Location = new System.Drawing.Point(40, 502);
            this.btnDistribution.Name = "btnDistribution";
            this.btnDistribution.Size = new System.Drawing.Size(150, 119);
            this.btnDistribution.TabIndex = 9;
            this.btnDistribution.Text = "📦 Distribution";
            this.btnDistribution.UseVisualStyleBackColor = true;
            // 
            // btnEligibleFilter
            // 
            this.btnEligibleFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEligibleFilter.ForeColor = System.Drawing.Color.Green;
            this.btnEligibleFilter.Location = new System.Drawing.Point(249, 502);
            this.btnEligibleFilter.Name = "btnEligibleFilter";
            this.btnEligibleFilter.Size = new System.Drawing.Size(150, 119);
            this.btnEligibleFilter.TabIndex = 10;
            this.btnEligibleFilter.Text = "✅         Eligible Filter";
            this.btnEligibleFilter.UseVisualStyleBackColor = true;
            // 
            // btnDonorLeaderboard
            // 
            this.btnDonorLeaderboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonorLeaderboard.ForeColor = System.Drawing.Color.Green;
            this.btnDonorLeaderboard.Location = new System.Drawing.Point(448, 502);
            this.btnDonorLeaderboard.Name = "btnDonorLeaderboard";
            this.btnDonorLeaderboard.Size = new System.Drawing.Size(150, 119);
            this.btnDonorLeaderboard.TabIndex = 11;
            this.btnDonorLeaderboard.Text = "🏆 Donor Leaderboard";
            this.btnDonorLeaderboard.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.Green;
            this.btnReports.Location = new System.Drawing.Point(644, 502);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(150, 119);
            this.btnReports.TabIndex = 12;
            this.btnReports.Text = "📊 Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // lblTotalDonors
            // 
            this.lblTotalDonors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblTotalDonors.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDonors.Location = new System.Drawing.Point(14, 103);
            this.lblTotalDonors.Name = "lblTotalDonors";
            this.lblTotalDonors.Size = new System.Drawing.Size(125, 108);
            this.lblTotalDonors.TabIndex = 13;
            this.lblTotalDonors.Text = "Total Donors";
            this.lblTotalDonors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBeneficiaries
            // 
            this.lblBeneficiaries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.lblBeneficiaries.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficiaries.Location = new System.Drawing.Point(153, 103);
            this.lblBeneficiaries.Name = "lblBeneficiaries";
            this.lblBeneficiaries.Size = new System.Drawing.Size(125, 108);
            this.lblBeneficiaries.TabIndex = 14;
            this.lblBeneficiaries.Text = "Beneficiaries";
            this.lblBeneficiaries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZakatCollected
            // 
            this.lblZakatCollected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.lblZakatCollected.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZakatCollected.Location = new System.Drawing.Point(290, 103);
            this.lblZakatCollected.Name = "lblZakatCollected";
            this.lblZakatCollected.Size = new System.Drawing.Size(125, 108);
            this.lblZakatCollected.TabIndex = 15;
            this.lblZakatCollected.Text = "Zakat Collected";
            this.lblZakatCollected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCharityCollected
            // 
            this.lblCharityCollected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.lblCharityCollected.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharityCollected.Location = new System.Drawing.Point(429, 103);
            this.lblCharityCollected.Name = "lblCharityCollected";
            this.lblCharityCollected.Size = new System.Drawing.Size(125, 108);
            this.lblCharityCollected.TabIndex = 16;
            this.lblCharityCollected.Text = "Charity Collected";
            this.lblCharityCollected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDistributed
            // 
            this.lblDistributed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblDistributed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistributed.ForeColor = System.Drawing.Color.Black;
            this.lblDistributed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDistributed.Location = new System.Drawing.Point(567, 103);
            this.lblDistributed.Name = "lblDistributed";
            this.lblDistributed.Size = new System.Drawing.Size(125, 108);
            this.lblDistributed.TabIndex = 17;
            this.lblDistributed.Text = "Distributed";
            this.lblDistributed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActiveCampaigns
            // 
            this.lblActiveCampaigns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.lblActiveCampaigns.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveCampaigns.Location = new System.Drawing.Point(703, 103);
            this.lblActiveCampaigns.Name = "lblActiveCampaigns";
            this.lblActiveCampaigns.Size = new System.Drawing.Size(125, 108);
            this.lblActiveCampaigns.TabIndex = 18;
            this.lblActiveCampaigns.Text = "Active Campains";
            this.lblActiveCampaigns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblActiveCampaigns.Click += new System.EventHandler(this.lblActiveCampaigns_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 700);
            this.Controls.Add(this.lblActiveCampaigns);
            this.Controls.Add(this.lblDistributed);
            this.Controls.Add(this.lblCharityCollected);
            this.Controls.Add(this.lblZakatCollected);
            this.Controls.Add(this.lblBeneficiaries);
            this.Controls.Add(this.lblTotalDonors);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnDonorLeaderboard);
            this.Controls.Add(this.btnEligibleFilter);
            this.Controls.Add(this.btnDistribution);
            this.Controls.Add(this.btnManageCampaigns);
            this.Controls.Add(this.btnManageDonations);
            this.Controls.Add(this.btnManageBeneficiaries);
            this.Controls.Add(this.btnManageUser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblQuickAction);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSystemOverview);
            this.Name = "Form3";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSystemOverview;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuickAction;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnManageBeneficiaries;
        private System.Windows.Forms.Button btnManageDonations;
        private System.Windows.Forms.Button btnManageCampaigns;
        private System.Windows.Forms.Button btnDistribution;
        private System.Windows.Forms.Button btnEligibleFilter;
        private System.Windows.Forms.Button btnDonorLeaderboard;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label lblTotalDonors;
        private System.Windows.Forms.Label lblBeneficiaries;
        private System.Windows.Forms.Label lblZakatCollected;
        private System.Windows.Forms.Label lblCharityCollected;
        private System.Windows.Forms.Label lblDistributed;
        private System.Windows.Forms.Label lblActiveCampaigns;
    }
}