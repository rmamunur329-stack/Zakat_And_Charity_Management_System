namespace Zakat_And_Charity_Management
{
    partial class Form20
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
            this.lblCalculations = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblPaymentYear = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.txtAwaitingPayment = new System.Windows.Forms.TextBox();
            this.cmbYourCalculation = new System.Windows.Forms.ComboBox();
            this.cmbPaymentYear = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Green;
            this.lblTitle.Location = new System.Drawing.Point(46, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "💳 Pay Zakat";
            // 
            // lblCalculations
            // 
            this.lblCalculations.AutoSize = true;
            this.lblCalculations.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculations.Location = new System.Drawing.Point(50, 150);
            this.lblCalculations.Name = "lblCalculations";
            this.lblCalculations.Size = new System.Drawing.Size(196, 25);
            this.lblCalculations.TabIndex = 1;
            this.lblCalculations.Text = "📋 Your Calculations:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(458, 153);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(160, 25);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "💰 Amount (৳):";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(50, 205);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(157, 20);
            this.lblPaymentMethod.TabIndex = 3;
            this.lblPaymentMethod.Text = "💳 Payment Method:";
            // 
            // lblPaymentYear
            // 
            this.lblPaymentYear.AutoSize = true;
            this.lblPaymentYear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentYear.Location = new System.Drawing.Point(478, 208);
            this.lblPaymentYear.Name = "lblPaymentYear";
            this.lblPaymentYear.Size = new System.Drawing.Size(108, 20);
            this.lblPaymentYear.TabIndex = 4;
            this.lblPaymentYear.Text = "Payment Year:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(41, 260);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(167, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "⏳ Awaiting payment: ";
            // 
            // cmbMethod
            // 
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "1.Bikash",
            "2.Nogod",
            "3.Rocket",
            "4.Upay",
            "5.DebitCard"});
            this.cmbMethod.Location = new System.Drawing.Point(217, 205);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(161, 24);
            this.cmbMethod.TabIndex = 6;
            // 
            // txtAwaitingPayment
            // 
            this.txtAwaitingPayment.Location = new System.Drawing.Point(217, 260);
            this.txtAwaitingPayment.Name = "txtAwaitingPayment";
            this.txtAwaitingPayment.Size = new System.Drawing.Size(161, 22);
            this.txtAwaitingPayment.TabIndex = 7;
            // 
            // cmbYourCalculation
            // 
            this.cmbYourCalculation.FormattingEnabled = true;
            this.cmbYourCalculation.Items.AddRange(new object[] {
            "1 - Zakat: ৳20,000.00:",
            "2 - Zakat: ৳12,500.00",
            "3 - Zakat: ৳8,750.00",
            "4 - Zakat: ৳5,000.00",
            "5 - Zakat: ৳2,500.00"});
            this.cmbYourCalculation.Location = new System.Drawing.Point(217, 150);
            this.cmbYourCalculation.Name = "cmbYourCalculation";
            this.cmbYourCalculation.Size = new System.Drawing.Size(161, 24);
            this.cmbYourCalculation.TabIndex = 8;
            // 
            // cmbPaymentYear
            // 
            this.cmbPaymentYear.FormattingEnabled = true;
            this.cmbPaymentYear.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbPaymentYear.Location = new System.Drawing.Point(600, 208);
            this.cmbPaymentYear.Name = "cmbPaymentYear";
            this.cmbPaymentYear.Size = new System.Drawing.Size(161, 24);
            this.cmbPaymentYear.TabIndex = 9;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(600, 156);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(161, 22);
            this.txtAmount.TabIndex = 10;
            // 
            // btnPayNow
            // 
            this.btnPayNow.BackColor = System.Drawing.Color.Green;
            this.btnPayNow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayNow.ForeColor = System.Drawing.Color.White;
            this.btnPayNow.Location = new System.Drawing.Point(95, 411);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(129, 51);
            this.btnPayNow.TabIndex = 11;
            this.btnPayNow.Text = "💳 Pay Now";
            this.btnPayNow.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(336, 411);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 51);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "🧹 Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Fuchsia;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(561, 411);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 51);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "⬅ Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 716);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPayNow);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cmbPaymentYear);
            this.Controls.Add(this.cmbYourCalculation);
            this.Controls.Add(this.txtAwaitingPayment);
            this.Controls.Add(this.cmbMethod);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPaymentYear);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblCalculations);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form20";
            this.Text = "Pay Zakat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCalculations;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblPaymentYear;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.TextBox txtAwaitingPayment;
        private System.Windows.Forms.ComboBox cmbYourCalculation;
        private System.Windows.Forms.ComboBox cmbPaymentYear;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
    }
}