namespace Zakat_And_Charity_Management
{
    partial class Form15
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
            this.tabAnalysis = new System.Windows.Forms.TabControl();
            this.tabDistributionReport = new System.Windows.Forms.TabPage();
            this.tabDonationSummary = new System.Windows.Forms.TabPage();
            this.tabCampaignReport = new System.Windows.Forms.TabPage();
            this.tabAuditLog = new System.Windows.Forms.TabPage();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.pnlTotalDistributed = new System.Windows.Forms.Panel();
            this.pnlTotalBeneficiaries = new System.Windows.Forms.Panel();
            this.pnlAveragePerBeneficiary = new System.Windows.Forms.Panel();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExporttoExcel = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.pnlTotalDonation = new System.Windows.Forms.Panel();
            this.pnlTotalDonor = new System.Windows.Forms.Panel();
            this.pnlAveragePerDonation = new System.Windows.Forms.Panel();
            this.btnGenerateSummary = new System.Windows.Forms.Button();
            this.dataGridViewDonationSummary = new System.Windows.Forms.DataGridView();
            this.dataGridViewCampaign = new System.Windows.Forms.DataGridView();
            this.pnlTotalCampaign = new System.Windows.Forms.Panel();
            this.pnlTotalAmount = new System.Windows.Forms.Panel();
            this.lblCampaign = new System.Windows.Forms.Label();
            this.pnlAdminAction = new System.Windows.Forms.Panel();
            this.pnlTotalLogs = new System.Windows.Forms.Panel();
            this.pnlCriticalEvents = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataGridViewAuditLog = new System.Windows.Forms.DataGridView();
            this.lblAuditLog = new System.Windows.Forms.Label();
            this.tabAnalysis.SuspendLayout();
            this.tabDistributionReport.SuspendLayout();
            this.tabDonationSummary.SuspendLayout();
            this.tabCampaignReport.SuspendLayout();
            this.tabAuditLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonationSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCampaign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuditLog)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAnalysis
            // 
            this.tabAnalysis.Controls.Add(this.tabDistributionReport);
            this.tabAnalysis.Controls.Add(this.tabDonationSummary);
            this.tabAnalysis.Controls.Add(this.tabCampaignReport);
            this.tabAnalysis.Controls.Add(this.tabAuditLog);
            this.tabAnalysis.Location = new System.Drawing.Point(12, 41);
            this.tabAnalysis.Name = "tabAnalysis";
            this.tabAnalysis.SelectedIndex = 0;
            this.tabAnalysis.Size = new System.Drawing.Size(1134, 647);
            this.tabAnalysis.TabIndex = 0;
            // 
            // tabDistributionReport
            // 
            this.tabDistributionReport.Controls.Add(this.dataGridView1);
            this.tabDistributionReport.Controls.Add(this.dateTimePickerToDate);
            this.tabDistributionReport.Controls.Add(this.dateTimePickerFromDate);
            this.tabDistributionReport.Controls.Add(this.btnGenerateReport);
            this.tabDistributionReport.Controls.Add(this.pnlAveragePerBeneficiary);
            this.tabDistributionReport.Controls.Add(this.pnlTotalBeneficiaries);
            this.tabDistributionReport.Controls.Add(this.pnlTotalDistributed);
            this.tabDistributionReport.Controls.Add(this.lblToDate);
            this.tabDistributionReport.Controls.Add(this.lblFromDate);
            this.tabDistributionReport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDistributionReport.ForeColor = System.Drawing.Color.Black;
            this.tabDistributionReport.Location = new System.Drawing.Point(4, 25);
            this.tabDistributionReport.Name = "tabDistributionReport";
            this.tabDistributionReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabDistributionReport.Size = new System.Drawing.Size(1126, 618);
            this.tabDistributionReport.TabIndex = 0;
            this.tabDistributionReport.Text = "Distribution Report";
            this.tabDistributionReport.UseVisualStyleBackColor = true;
            // 
            // tabDonationSummary
            // 
            this.tabDonationSummary.Controls.Add(this.dataGridViewDonationSummary);
            this.tabDonationSummary.Controls.Add(this.btnGenerateSummary);
            this.tabDonationSummary.Controls.Add(this.pnlAveragePerDonation);
            this.tabDonationSummary.Controls.Add(this.pnlTotalDonor);
            this.tabDonationSummary.Controls.Add(this.pnlTotalDonation);
            this.tabDonationSummary.Controls.Add(this.dateTimePickerEndDate);
            this.tabDonationSummary.Controls.Add(this.dateTimePickerStartDate);
            this.tabDonationSummary.Controls.Add(this.lblEndDate);
            this.tabDonationSummary.Controls.Add(this.lblStartDate);
            this.tabDonationSummary.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDonationSummary.Location = new System.Drawing.Point(4, 25);
            this.tabDonationSummary.Name = "tabDonationSummary";
            this.tabDonationSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabDonationSummary.Size = new System.Drawing.Size(1126, 618);
            this.tabDonationSummary.TabIndex = 1;
            this.tabDonationSummary.Text = "Donation Summary";
            this.tabDonationSummary.UseVisualStyleBackColor = true;
            // 
            // tabCampaignReport
            // 
            this.tabCampaignReport.Controls.Add(this.lblCampaign);
            this.tabCampaignReport.Controls.Add(this.pnlTotalAmount);
            this.tabCampaignReport.Controls.Add(this.pnlTotalCampaign);
            this.tabCampaignReport.Controls.Add(this.dataGridViewCampaign);
            this.tabCampaignReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCampaignReport.Location = new System.Drawing.Point(4, 25);
            this.tabCampaignReport.Name = "tabCampaignReport";
            this.tabCampaignReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabCampaignReport.Size = new System.Drawing.Size(1126, 618);
            this.tabCampaignReport.TabIndex = 2;
            this.tabCampaignReport.Text = "Campaign Report";
            this.tabCampaignReport.UseVisualStyleBackColor = true;
            // 
            // tabAuditLog
            // 
            this.tabAuditLog.Controls.Add(this.lblAuditLog);
            this.tabAuditLog.Controls.Add(this.dataGridViewAuditLog);
            this.tabAuditLog.Controls.Add(this.btnReset);
            this.tabAuditLog.Controls.Add(this.btnSearch);
            this.tabAuditLog.Controls.Add(this.pnlCriticalEvents);
            this.tabAuditLog.Controls.Add(this.pnlTotalLogs);
            this.tabAuditLog.Controls.Add(this.pnlAdminAction);
            this.tabAuditLog.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAuditLog.Location = new System.Drawing.Point(4, 25);
            this.tabAuditLog.Name = "tabAuditLog";
            this.tabAuditLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuditLog.Size = new System.Drawing.Size(1126, 618);
            this.tabAuditLog.TabIndex = 3;
            this.tabAuditLog.Text = "Audit Log";
            this.tabAuditLog.UseVisualStyleBackColor = true;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(25, 37);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(106, 25);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "From Date:";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(28, 102);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(81, 25);
            this.lblToDate.TabIndex = 1;
            this.lblToDate.Text = "To Date:";
            // 
            // pnlTotalDistributed
            // 
            this.pnlTotalDistributed.Location = new System.Drawing.Point(430, 37);
            this.pnlTotalDistributed.Name = "pnlTotalDistributed";
            this.pnlTotalDistributed.Size = new System.Drawing.Size(167, 95);
            this.pnlTotalDistributed.TabIndex = 2;
            // 
            // pnlTotalBeneficiaries
            // 
            this.pnlTotalBeneficiaries.Location = new System.Drawing.Point(665, 37);
            this.pnlTotalBeneficiaries.Name = "pnlTotalBeneficiaries";
            this.pnlTotalBeneficiaries.Size = new System.Drawing.Size(167, 95);
            this.pnlTotalBeneficiaries.TabIndex = 3;
            // 
            // pnlAveragePerBeneficiary
            // 
            this.pnlAveragePerBeneficiary.Location = new System.Drawing.Point(884, 37);
            this.pnlAveragePerBeneficiary.Name = "pnlAveragePerBeneficiary";
            this.pnlAveragePerBeneficiary.Size = new System.Drawing.Size(167, 95);
            this.pnlAveragePerBeneficiary.TabIndex = 4;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(42, 183);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(194, 36);
            this.btnGenerateReport.TabIndex = 5;
            this.btnGenerateReport.Text = "📊 Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(145, 46);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerFromDate.TabIndex = 6;
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(147, 107);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerToDate.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 371);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnExporttoExcel
            // 
            this.btnExporttoExcel.BackColor = System.Drawing.Color.Green;
            this.btnExporttoExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExporttoExcel.ForeColor = System.Drawing.Color.White;
            this.btnExporttoExcel.Location = new System.Drawing.Point(576, 746);
            this.btnExporttoExcel.Name = "btnExporttoExcel";
            this.btnExporttoExcel.Size = new System.Drawing.Size(178, 48);
            this.btnExporttoExcel.TabIndex = 1;
            this.btnExporttoExcel.Text = "📤 Export to Excel";
            this.btnExporttoExcel.UseVisualStyleBackColor = false;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Location = new System.Drawing.Point(867, 746);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(176, 43);
            this.btnPrintReport.TabIndex = 2;
            this.btnPrintReport.Text = "🖨️ Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(37, 51);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(101, 25);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(39, 123);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(94, 25);
            this.lblEndDate.TabIndex = 1;
            this.lblEndDate.Text = "End Date:";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(120, 50);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(250, 34);
            this.dateTimePickerStartDate.TabIndex = 2;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(120, 120);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(250, 34);
            this.dateTimePickerEndDate.TabIndex = 3;
            // 
            // pnlTotalDonation
            // 
            this.pnlTotalDonation.Location = new System.Drawing.Point(414, 51);
            this.pnlTotalDonation.Name = "pnlTotalDonation";
            this.pnlTotalDonation.Size = new System.Drawing.Size(166, 94);
            this.pnlTotalDonation.TabIndex = 4;
            // 
            // pnlTotalDonor
            // 
            this.pnlTotalDonor.Location = new System.Drawing.Point(627, 51);
            this.pnlTotalDonor.Name = "pnlTotalDonor";
            this.pnlTotalDonor.Size = new System.Drawing.Size(166, 94);
            this.pnlTotalDonor.TabIndex = 5;
            // 
            // pnlAveragePerDonation
            // 
            this.pnlAveragePerDonation.Location = new System.Drawing.Point(840, 51);
            this.pnlAveragePerDonation.Name = "pnlAveragePerDonation";
            this.pnlAveragePerDonation.Size = new System.Drawing.Size(166, 94);
            this.pnlAveragePerDonation.TabIndex = 6;
            // 
            // btnGenerateSummary
            // 
            this.btnGenerateSummary.BackColor = System.Drawing.Color.Green;
            this.btnGenerateSummary.ForeColor = System.Drawing.Color.White;
            this.btnGenerateSummary.Location = new System.Drawing.Point(70, 212);
            this.btnGenerateSummary.Name = "btnGenerateSummary";
            this.btnGenerateSummary.Size = new System.Drawing.Size(161, 36);
            this.btnGenerateSummary.TabIndex = 7;
            this.btnGenerateSummary.Text = "Generate Summary";
            this.btnGenerateSummary.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDonationSummary
            // 
            this.dataGridViewDonationSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonationSummary.Location = new System.Drawing.Point(0, 284);
            this.dataGridViewDonationSummary.Name = "dataGridViewDonationSummary";
            this.dataGridViewDonationSummary.RowHeadersWidth = 51;
            this.dataGridViewDonationSummary.RowTemplate.Height = 24;
            this.dataGridViewDonationSummary.Size = new System.Drawing.Size(1126, 334);
            this.dataGridViewDonationSummary.TabIndex = 8;
            // 
            // dataGridViewCampaign
            // 
            this.dataGridViewCampaign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCampaign.Location = new System.Drawing.Point(0, 187);
            this.dataGridViewCampaign.Name = "dataGridViewCampaign";
            this.dataGridViewCampaign.RowHeadersWidth = 51;
            this.dataGridViewCampaign.RowTemplate.Height = 24;
            this.dataGridViewCampaign.Size = new System.Drawing.Size(1130, 435);
            this.dataGridViewCampaign.TabIndex = 0;
            // 
            // pnlTotalCampaign
            // 
            this.pnlTotalCampaign.Location = new System.Drawing.Point(394, 35);
            this.pnlTotalCampaign.Name = "pnlTotalCampaign";
            this.pnlTotalCampaign.Size = new System.Drawing.Size(200, 128);
            this.pnlTotalCampaign.TabIndex = 1;
            // 
            // pnlTotalAmount
            // 
            this.pnlTotalAmount.Location = new System.Drawing.Point(667, 35);
            this.pnlTotalAmount.Name = "pnlTotalAmount";
            this.pnlTotalAmount.Size = new System.Drawing.Size(200, 128);
            this.pnlTotalAmount.TabIndex = 2;
            // 
            // lblCampaign
            // 
            this.lblCampaign.AutoSize = true;
            this.lblCampaign.BackColor = System.Drawing.Color.Green;
            this.lblCampaign.ForeColor = System.Drawing.Color.White;
            this.lblCampaign.Location = new System.Drawing.Point(104, 81);
            this.lblCampaign.Name = "lblCampaign";
            this.lblCampaign.Size = new System.Drawing.Size(240, 25);
            this.lblCampaign.TabIndex = 3;
            this.lblCampaign.Text = "Generate Campaign Report";
            // 
            // pnlAdminAction
            // 
            this.pnlAdminAction.Location = new System.Drawing.Point(259, 77);
            this.pnlAdminAction.Name = "pnlAdminAction";
            this.pnlAdminAction.Size = new System.Drawing.Size(145, 100);
            this.pnlAdminAction.TabIndex = 0;
            // 
            // pnlTotalLogs
            // 
            this.pnlTotalLogs.Location = new System.Drawing.Point(474, 77);
            this.pnlTotalLogs.Name = "pnlTotalLogs";
            this.pnlTotalLogs.Size = new System.Drawing.Size(145, 100);
            this.pnlTotalLogs.TabIndex = 1;
            // 
            // pnlCriticalEvents
            // 
            this.pnlCriticalEvents.Location = new System.Drawing.Point(698, 77);
            this.pnlCriticalEvents.Name = "pnlCriticalEvents";
            this.pnlCriticalEvents.Size = new System.Drawing.Size(145, 100);
            this.pnlCriticalEvents.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(949, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 50);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(949, 117);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 46);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "🔄 Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // dataGridViewAuditLog
            // 
            this.dataGridViewAuditLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuditLog.Location = new System.Drawing.Point(0, 235);
            this.dataGridViewAuditLog.Name = "dataGridViewAuditLog";
            this.dataGridViewAuditLog.RowHeadersWidth = 51;
            this.dataGridViewAuditLog.RowTemplate.Height = 24;
            this.dataGridViewAuditLog.Size = new System.Drawing.Size(1125, 382);
            this.dataGridViewAuditLog.TabIndex = 5;
            // 
            // lblAuditLog
            // 
            this.lblAuditLog.BackColor = System.Drawing.Color.Green;
            this.lblAuditLog.ForeColor = System.Drawing.Color.White;
            this.lblAuditLog.Location = new System.Drawing.Point(37, 61);
            this.lblAuditLog.Name = "lblAuditLog";
            this.lblAuditLog.Size = new System.Drawing.Size(154, 63);
            this.lblAuditLog.TabIndex = 6;
            this.lblAuditLog.Text = "Audit Log ";
            this.lblAuditLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 861);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnExporttoExcel);
            this.Controls.Add(this.tabAnalysis);
            this.Name = "Form15";
            this.Text = "Report & Analysis";
            this.tabAnalysis.ResumeLayout(false);
            this.tabDistributionReport.ResumeLayout(false);
            this.tabDistributionReport.PerformLayout();
            this.tabDonationSummary.ResumeLayout(false);
            this.tabDonationSummary.PerformLayout();
            this.tabCampaignReport.ResumeLayout(false);
            this.tabCampaignReport.PerformLayout();
            this.tabAuditLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonationSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCampaign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuditLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAnalysis;
        private System.Windows.Forms.TabPage tabDistributionReport;
        private System.Windows.Forms.TabPage tabDonationSummary;
        private System.Windows.Forms.TabPage tabCampaignReport;
        private System.Windows.Forms.TabPage tabAuditLog;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Panel pnlAveragePerBeneficiary;
        private System.Windows.Forms.Panel pnlTotalBeneficiaries;
        private System.Windows.Forms.Panel pnlTotalDistributed;
        private System.Windows.Forms.Button btnExporttoExcel;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.DataGridView dataGridViewDonationSummary;
        private System.Windows.Forms.Button btnGenerateSummary;
        private System.Windows.Forms.Panel pnlAveragePerDonation;
        private System.Windows.Forms.Panel pnlTotalDonor;
        private System.Windows.Forms.Panel pnlTotalDonation;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblCampaign;
        private System.Windows.Forms.Panel pnlTotalAmount;
        private System.Windows.Forms.Panel pnlTotalCampaign;
        private System.Windows.Forms.DataGridView dataGridViewCampaign;
        private System.Windows.Forms.Panel pnlCriticalEvents;
        private System.Windows.Forms.Panel pnlTotalLogs;
        private System.Windows.Forms.Panel pnlAdminAction;
        private System.Windows.Forms.Label lblAuditLog;
        private System.Windows.Forms.DataGridView dataGridViewAuditLog;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
    }
}