namespace Zakat_And_Charity_Management
{
    partial class Form11
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
            this.lblManageCampaigns = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNewCampaigns = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCampaignName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTargetAmount = new System.Windows.Forms.Label();
            this.lblCollectedAmount = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtCampaignName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTargetAmount = new System.Windows.Forms.TextBox();
            this.txtCollectedAmount = new System.Windows.Forms.TextBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnEditCampaigns = new System.Windows.Forms.Button();
            this.btnDeleteCampaign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManageCampaigns
            // 
            this.lblManageCampaigns.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCampaigns.ForeColor = System.Drawing.Color.Green;
            this.lblManageCampaigns.Location = new System.Drawing.Point(12, 63);
            this.lblManageCampaigns.Name = "lblManageCampaigns";
            this.lblManageCampaigns.Size = new System.Drawing.Size(212, 38);
            this.lblManageCampaigns.TabIndex = 0;
            this.lblManageCampaigns.Text = "📢 Manage Campaigns";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(19, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(896, 243);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnNewCampaigns
            // 
            this.btnNewCampaigns.BackColor = System.Drawing.Color.Green;
            this.btnNewCampaigns.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCampaigns.ForeColor = System.Drawing.Color.White;
            this.btnNewCampaigns.Location = new System.Drawing.Point(585, 55);
            this.btnNewCampaigns.Name = "btnNewCampaigns";
            this.btnNewCampaigns.Size = new System.Drawing.Size(121, 57);
            this.btnNewCampaigns.TabIndex = 2;
            this.btnNewCampaigns.Text = "➕ Add New Campaign";
            this.btnNewCampaigns.UseVisualStyleBackColor = false;
            this.btnNewCampaigns.Click += new System.EventHandler(this.btnNewCampaigns_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Green;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(747, 63);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 49);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.dateTimePickerEndDate);
            this.groupBox1.Controls.Add(this.dateTimePickerStartDate);
            this.groupBox1.Controls.Add(this.txtCollectedAmount);
            this.groupBox1.Controls.Add(this.txtTargetAmount);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtCampaignName);
            this.groupBox1.Controls.Add(this.lblEndDate);
            this.groupBox1.Controls.Add(this.lblStartDate);
            this.groupBox1.Controls.Add(this.lblCollectedAmount);
            this.groupBox1.Controls.Add(this.lblTargetAmount);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblCampaignName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campaign Details";
            // 
            // lblCampaignName
            // 
            this.lblCampaignName.AutoSize = true;
            this.lblCampaignName.Location = new System.Drawing.Point(6, 60);
            this.lblCampaignName.Name = "lblCampaignName";
            this.lblCampaignName.Size = new System.Drawing.Size(127, 20);
            this.lblCampaignName.TabIndex = 0;
            this.lblCampaignName.Text = "Campaign Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 103);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(95, 20);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description :";
            // 
            // lblTargetAmount
            // 
            this.lblTargetAmount.AutoSize = true;
            this.lblTargetAmount.Location = new System.Drawing.Point(260, 60);
            this.lblTargetAmount.Name = "lblTargetAmount";
            this.lblTargetAmount.Size = new System.Drawing.Size(115, 20);
            this.lblTargetAmount.TabIndex = 2;
            this.lblTargetAmount.Text = "Target Amount:";
            // 
            // lblCollectedAmount
            // 
            this.lblCollectedAmount.AutoSize = true;
            this.lblCollectedAmount.Location = new System.Drawing.Point(240, 104);
            this.lblCollectedAmount.Name = "lblCollectedAmount";
            this.lblCollectedAmount.Size = new System.Drawing.Size(135, 20);
            this.lblCollectedAmount.TabIndex = 3;
            this.lblCollectedAmount.Text = "Collected Amount:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(515, 64);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(81, 20);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(519, 104);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(75, 20);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date:";
            // 
            // txtCampaignName
            // 
            this.txtCampaignName.Location = new System.Drawing.Point(129, 55);
            this.txtCampaignName.Name = "txtCampaignName";
            this.txtCampaignName.Size = new System.Drawing.Size(125, 27);
            this.txtCampaignName.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(107, 97);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(125, 27);
            this.txtDescription.TabIndex = 7;
            // 
            // txtTargetAmount
            // 
            this.txtTargetAmount.Location = new System.Drawing.Point(381, 57);
            this.txtTargetAmount.Name = "txtTargetAmount";
            this.txtTargetAmount.Size = new System.Drawing.Size(125, 27);
            this.txtTargetAmount.TabIndex = 8;
            // 
            // txtCollectedAmount
            // 
            this.txtCollectedAmount.Location = new System.Drawing.Point(381, 100);
            this.txtCollectedAmount.Name = "txtCollectedAmount";
            this.txtCollectedAmount.Size = new System.Drawing.Size(125, 27);
            this.txtCollectedAmount.TabIndex = 9;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(598, 59);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(280, 27);
            this.dateTimePickerStartDate.TabIndex = 10;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(598, 100);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(280, 27);
            this.dateTimePickerEndDate.TabIndex = 11;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(536, 147);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(91, 30);
            this.chkActive.TabIndex = 12;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnEditCampaigns
            // 
            this.btnEditCampaigns.BackColor = System.Drawing.Color.Green;
            this.btnEditCampaigns.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCampaigns.ForeColor = System.Drawing.Color.White;
            this.btnEditCampaigns.Location = new System.Drawing.Point(457, 648);
            this.btnEditCampaigns.Name = "btnEditCampaigns";
            this.btnEditCampaigns.Size = new System.Drawing.Size(171, 46);
            this.btnEditCampaigns.TabIndex = 5;
            this.btnEditCampaigns.Text = "✏️ Edit Campaign";
            this.btnEditCampaigns.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCampaign
            // 
            this.btnDeleteCampaign.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCampaign.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCampaign.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCampaign.Location = new System.Drawing.Point(670, 648);
            this.btnDeleteCampaign.Name = "btnDeleteCampaign";
            this.btnDeleteCampaign.Size = new System.Drawing.Size(182, 46);
            this.btnDeleteCampaign.TabIndex = 6;
            this.btnDeleteCampaign.Text = "🗑️ Delete Campaign";
            this.btnDeleteCampaign.UseVisualStyleBackColor = false;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 724);
            this.Controls.Add(this.btnDeleteCampaign);
            this.Controls.Add(this.btnEditCampaigns);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNewCampaigns);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblManageCampaigns);
            this.Name = "Form11";
            this.Text = "Manage Campaigns";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblManageCampaigns;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNewCampaigns;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.TextBox txtCollectedAmount;
        private System.Windows.Forms.TextBox txtTargetAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCampaignName;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblCollectedAmount;
        private System.Windows.Forms.Label lblTargetAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCampaignName;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnEditCampaigns;
        private System.Windows.Forms.Button btnDeleteCampaign;
    }
}