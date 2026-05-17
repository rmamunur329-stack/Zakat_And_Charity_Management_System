namespace Zakat_And_Charity_Management
{
    partial class Form19
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblDaysRemaining = new System.Windows.Forms.Label();
            this.lblDaysValue = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblZakatDue = new System.Windows.Forms.Label();
            this.lblZakatDueValue = new System.Windows.Forms.Label();
            this.pnlProgressCircle = new System.Windows.Forms.Panel();
            this.lblProgressPercent = new System.Windows.Forms.Label();
            this.lblProgressText = new System.Windows.Forms.Label();
            this.btnStartNewHawl = new System.Windows.Forms.Button();
            this.pnlProgressCircle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Green;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(63, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📅 HAWL TRACKER";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(113, 130);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(141, 28);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "📅 Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(297, 125);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(284, 38);
            this.dtpStartDate.TabIndex = 2;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(-2, 179);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(256, 28);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "📆 End Date (After 1 Year):";
            this.lblEndDate.Click += new System.EventHandler(this.lblEndDate_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(297, 178);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(284, 30);
            this.dtpEndDate.TabIndex = 4;
            // 
            // lblDaysRemaining
            // 
            this.lblDaysRemaining.AutoSize = true;
            this.lblDaysRemaining.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysRemaining.Location = new System.Drawing.Point(74, 238);
            this.lblDaysRemaining.Name = "lblDaysRemaining";
            this.lblDaysRemaining.Size = new System.Drawing.Size(180, 25);
            this.lblDaysRemaining.TabIndex = 5;
            this.lblDaysRemaining.Text = "⏳ Days Remaining:";
            this.lblDaysRemaining.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDaysValue
            // 
            this.lblDaysValue.Location = new System.Drawing.Point(297, 242);
            this.lblDaysValue.Name = "lblDaysValue";
            this.lblDaysValue.Size = new System.Drawing.Size(227, 22);
            this.lblDaysValue.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(156, 295);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(98, 25);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "📌 Status:";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusValue.Location = new System.Drawing.Point(302, 297);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(104, 25);
            this.lblStatusValue.TabIndex = 8;
            this.lblStatusValue.Text = "Completed";
            // 
            // lblZakatDue
            // 
            this.lblZakatDue.AutoSize = true;
            this.lblZakatDue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZakatDue.Location = new System.Drawing.Point(123, 350);
            this.lblZakatDue.Name = "lblZakatDue";
            this.lblZakatDue.Size = new System.Drawing.Size(131, 25);
            this.lblZakatDue.TabIndex = 9;
            this.lblZakatDue.Text = "💰 Zakat Due:";
            // 
            // lblZakatDueValue
            // 
            this.lblZakatDueValue.AutoSize = true;
            this.lblZakatDueValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZakatDueValue.Location = new System.Drawing.Point(332, 350);
            this.lblZakatDueValue.Name = "lblZakatDueValue";
            this.lblZakatDueValue.Size = new System.Drawing.Size(38, 25);
            this.lblZakatDueValue.TabIndex = 10;
            this.lblZakatDueValue.Text = "Yes";
            // 
            // pnlProgressCircle
            // 
            this.pnlProgressCircle.Controls.Add(this.lblProgressText);
            this.pnlProgressCircle.Controls.Add(this.lblProgressPercent);
            this.pnlProgressCircle.Location = new System.Drawing.Point(670, 129);
            this.pnlProgressCircle.Name = "pnlProgressCircle";
            this.pnlProgressCircle.Size = new System.Drawing.Size(231, 246);
            this.pnlProgressCircle.TabIndex = 11;
            // 
            // lblProgressPercent
            // 
            this.lblProgressPercent.AutoSize = true;
            this.lblProgressPercent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressPercent.Location = new System.Drawing.Point(86, 125);
            this.lblProgressPercent.Name = "lblProgressPercent";
            this.lblProgressPercent.Size = new System.Drawing.Size(68, 31);
            this.lblProgressPercent.TabIndex = 0;
            this.lblProgressPercent.Text = "100%";
            // 
            // lblProgressText
            // 
            this.lblProgressText.AutoSize = true;
            this.lblProgressText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressText.Location = new System.Drawing.Point(40, 201);
            this.lblProgressText.Name = "lblProgressText";
            this.lblProgressText.Size = new System.Drawing.Size(150, 25);
            this.lblProgressText.TabIndex = 1;
            this.lblProgressText.Text = "Hawl Completed";
            // 
            // btnStartNewHawl
            // 
            this.btnStartNewHawl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStartNewHawl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartNewHawl.ForeColor = System.Drawing.Color.White;
            this.btnStartNewHawl.Location = new System.Drawing.Point(378, 476);
            this.btnStartNewHawl.Name = "btnStartNewHawl";
            this.btnStartNewHawl.Size = new System.Drawing.Size(132, 98);
            this.btnStartNewHawl.TabIndex = 12;
            this.btnStartNewHawl.Text = "▶ START NEW HAWL";
            this.btnStartNewHawl.UseVisualStyleBackColor = false;
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 739);
            this.Controls.Add(this.btnStartNewHawl);
            this.Controls.Add(this.pnlProgressCircle);
            this.Controls.Add(this.lblZakatDueValue);
            this.Controls.Add(this.lblZakatDue);
            this.Controls.Add(this.lblStatusValue);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDaysValue);
            this.Controls.Add(this.lblDaysRemaining);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form19";
            this.Text = "Hawl Tracker";
            this.Load += new System.EventHandler(this.Form19_Load);
            this.pnlProgressCircle.ResumeLayout(false);
            this.pnlProgressCircle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblDaysRemaining;
        private System.Windows.Forms.TextBox lblDaysValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblZakatDue;
        private System.Windows.Forms.Label lblZakatDueValue;
        private System.Windows.Forms.Panel pnlProgressCircle;
        private System.Windows.Forms.Label lblProgressText;
        private System.Windows.Forms.Label lblProgressPercent;
        private System.Windows.Forms.Button btnStartNewHawl;
    }
}