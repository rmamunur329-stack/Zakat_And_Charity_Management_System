namespace Zakat_And_Charity_Management
{
    partial class Form13
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
            this.lblBeneficiaryFilter = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblEligibility = new System.Windows.Forms.Label();
            this.lblVerification = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbEligibility = new System.Windows.Forms.ComboBox();
            this.cmbVerification = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExporttoExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBeneficiaryFilter
            // 
            this.lblBeneficiaryFilter.AutoSize = true;
            this.lblBeneficiaryFilter.BackColor = System.Drawing.Color.White;
            this.lblBeneficiaryFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficiaryFilter.ForeColor = System.Drawing.Color.Green;
            this.lblBeneficiaryFilter.Location = new System.Drawing.Point(32, 42);
            this.lblBeneficiaryFilter.Name = "lblBeneficiaryFilter";
            this.lblBeneficiaryFilter.Size = new System.Drawing.Size(229, 23);
            this.lblBeneficiaryFilter.TabIndex = 0;
            this.lblBeneficiaryFilter.Text = "🤲✅ Eligible Beneficiaries";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(47, 97);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(129, 25);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "🏷️ Category:";
            // 
            // lblEligibility
            // 
            this.lblEligibility.AutoSize = true;
            this.lblEligibility.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEligibility.Location = new System.Drawing.Point(251, 97);
            this.lblEligibility.Name = "lblEligibility";
            this.lblEligibility.Size = new System.Drawing.Size(103, 20);
            this.lblEligibility.TabIndex = 2;
            this.lblEligibility.Text = "✅ Eligibility:";
            // 
            // lblVerification
            // 
            this.lblVerification.AutoSize = true;
            this.lblVerification.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerification.Location = new System.Drawing.Point(527, 97);
            this.lblVerification.Name = "lblVerification";
            this.lblVerification.Size = new System.Drawing.Size(119, 20);
            this.lblVerification.TabIndex = 3;
            this.lblVerification.Text = "✔️ Verification:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "All Category",
            "Widow",
            "Orphan",
            "Poor Family",
            "Disable Person",
            "Elderly"});
            this.cmbCategory.Location = new System.Drawing.Point(51, 125);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(138, 24);
            this.cmbCategory.TabIndex = 4;
            // 
            // cmbEligibility
            // 
            this.cmbEligibility.FormattingEnabled = true;
            this.cmbEligibility.Items.AddRange(new object[] {
            "All",
            "Eligible",
            "Not Eligible"});
            this.cmbEligibility.Location = new System.Drawing.Point(255, 124);
            this.cmbEligibility.Name = "cmbEligibility";
            this.cmbEligibility.Size = new System.Drawing.Size(138, 24);
            this.cmbEligibility.TabIndex = 5;
            // 
            // cmbVerification
            // 
            this.cmbVerification.FormattingEnabled = true;
            this.cmbVerification.Items.AddRange(new object[] {
            "All",
            "Verified",
            "Not Verified"});
            this.cmbVerification.Location = new System.Drawing.Point(531, 124);
            this.cmbVerification.Name = "cmbVerification";
            this.cmbVerification.Size = new System.Drawing.Size(138, 24);
            this.cmbVerification.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(779, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 51);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(905, 97);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 51);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "🔄 Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(961, 294);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnExporttoExcel
            // 
            this.btnExporttoExcel.BackColor = System.Drawing.Color.Green;
            this.btnExporttoExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExporttoExcel.ForeColor = System.Drawing.Color.White;
            this.btnExporttoExcel.Location = new System.Drawing.Point(825, 568);
            this.btnExporttoExcel.Name = "btnExporttoExcel";
            this.btnExporttoExcel.Size = new System.Drawing.Size(163, 58);
            this.btnExporttoExcel.TabIndex = 10;
            this.btnExporttoExcel.Text = "📊 Export to Excel";
            this.btnExporttoExcel.UseVisualStyleBackColor = false;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 697);
            this.Controls.Add(this.btnExporttoExcel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbVerification);
            this.Controls.Add(this.cmbEligibility);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblVerification);
            this.Controls.Add(this.lblEligibility);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblBeneficiaryFilter);
            this.Name = "Form13";
            this.Text = "Eligible Beneficiaries";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBeneficiaryFilter;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblEligibility;
        private System.Windows.Forms.Label lblVerification;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbEligibility;
        private System.Windows.Forms.ComboBox cmbVerification;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExporttoExcel;
    }
}