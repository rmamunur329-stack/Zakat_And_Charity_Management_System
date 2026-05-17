namespace Zakat_And_Charity_Management
{
    partial class Form17
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
            this.lblNISABCALCULATOR = new System.Windows.Forms.Label();
            this.lblGoldPrice = new System.Windows.Forms.Label();
            this.lblGoldValue = new System.Windows.Forms.Label();
            this.lblSilverPrice = new System.Windows.Forms.Label();
            this.lblSilverValue = new System.Windows.Forms.Label();
            this.lblNisabSilverValue = new System.Windows.Forms.Label();
            this.lblNisabGold = new System.Windows.Forms.Label();
            this.lblAssets = new System.Windows.Forms.Label();
            this.lblNisabSilver = new System.Windows.Forms.Label();
            this.lblNisab = new System.Windows.Forms.Label();
            this.txtAssets = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNISABCALCULATOR
            // 
            this.lblNISABCALCULATOR.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNISABCALCULATOR.ForeColor = System.Drawing.Color.Green;
            this.lblNISABCALCULATOR.Location = new System.Drawing.Point(35, 23);
            this.lblNISABCALCULATOR.Name = "lblNISABCALCULATOR";
            this.lblNISABCALCULATOR.Size = new System.Drawing.Size(245, 54);
            this.lblNISABCALCULATOR.TabIndex = 0;
            this.lblNISABCALCULATOR.Text = "📊 Nisab Calculator";
            // 
            // lblGoldPrice
            // 
            this.lblGoldPrice.AutoSize = true;
            this.lblGoldPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoldPrice.Location = new System.Drawing.Point(125, 105);
            this.lblGoldPrice.Name = "lblGoldPrice";
            this.lblGoldPrice.Size = new System.Drawing.Size(199, 28);
            this.lblGoldPrice.TabIndex = 1;
            this.lblGoldPrice.Text = "Gold price per gram:";
            // 
            // lblGoldValue
            // 
            this.lblGoldValue.AutoSize = true;
            this.lblGoldValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoldValue.Location = new System.Drawing.Point(429, 105);
            this.lblGoldValue.Name = "lblGoldValue";
            this.lblGoldValue.Size = new System.Drawing.Size(72, 28);
            this.lblGoldValue.TabIndex = 2;
            this.lblGoldValue.Text = "৳0.00";
            // 
            // lblSilverPrice
            // 
            this.lblSilverPrice.AutoSize = true;
            this.lblSilverPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSilverPrice.Location = new System.Drawing.Point(119, 170);
            this.lblSilverPrice.Name = "lblSilverPrice";
            this.lblSilverPrice.Size = new System.Drawing.Size(205, 28);
            this.lblSilverPrice.TabIndex = 3;
            this.lblSilverPrice.Text = "Silver price per gram:";
            // 
            // lblSilverValue
            // 
            this.lblSilverValue.AutoSize = true;
            this.lblSilverValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSilverValue.Location = new System.Drawing.Point(429, 170);
            this.lblSilverValue.Name = "lblSilverValue";
            this.lblSilverValue.Size = new System.Drawing.Size(72, 28);
            this.lblSilverValue.TabIndex = 4;
            this.lblSilverValue.Text = "৳0.00";
            // 
            // lblNisabSilverValue
            // 
            this.lblNisabSilverValue.AutoSize = true;
            this.lblNisabSilverValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNisabSilverValue.Location = new System.Drawing.Point(431, 240);
            this.lblNisabSilverValue.Name = "lblNisabSilverValue";
            this.lblNisabSilverValue.Size = new System.Drawing.Size(90, 35);
            this.lblNisabSilverValue.TabIndex = 5;
            this.lblNisabSilverValue.Text = "৳0.00";
            // 
            // lblNisabGold
            // 
            this.lblNisabGold.AutoSize = true;
            this.lblNisabGold.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNisabGold.Location = new System.Drawing.Point(155, 240);
            this.lblNisabGold.Name = "lblNisabGold";
            this.lblNisabGold.Size = new System.Drawing.Size(169, 28);
            this.lblNisabGold.TabIndex = 6;
            this.lblNisabGold.Text = "Nisab (85g gold):";
            // 
            // lblAssets
            // 
            this.lblAssets.AutoSize = true;
            this.lblAssets.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssets.Location = new System.Drawing.Point(62, 373);
            this.lblAssets.Name = "lblAssets";
            this.lblAssets.Size = new System.Drawing.Size(262, 28);
            this.lblAssets.TabIndex = 7;
            this.lblAssets.Text = "Enter your total assets (৳):";
            // 
            // lblNisabSilver
            // 
            this.lblNisabSilver.AutoSize = true;
            this.lblNisabSilver.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNisabSilver.Location = new System.Drawing.Point(137, 291);
            this.lblNisabSilver.Name = "lblNisabSilver";
            this.lblNisabSilver.Size = new System.Drawing.Size(186, 28);
            this.lblNisabSilver.TabIndex = 8;
            this.lblNisabSilver.Text = "Nisab (595g silver):";
            // 
            // lblNisab
            // 
            this.lblNisab.AutoSize = true;
            this.lblNisab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNisab.Location = new System.Drawing.Point(429, 291);
            this.lblNisab.Name = "lblNisab";
            this.lblNisab.Size = new System.Drawing.Size(72, 28);
            this.lblNisab.TabIndex = 10;
            this.lblNisab.Text = "৳0.00";
            // 
            // txtAssets
            // 
            this.txtAssets.Location = new System.Drawing.Point(330, 380);
            this.txtAssets.Name = "txtAssets";
            this.txtAssets.Size = new System.Drawing.Size(281, 22);
            this.txtAssets.TabIndex = 11;
            this.txtAssets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Green;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(98, 474);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(513, 45);
            this.btnCheck.TabIndex = 12;
            this.btnCheck.Text = "✅ Check Nisab";
            this.btnCheck.UseVisualStyleBackColor = false;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Green;
            this.lblResult.Location = new System.Drawing.Point(158, 558);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(363, 35);
            this.lblResult.TabIndex = 13;
            this.lblResult.Text = "✅ Nisab MET — Zakat is obligatory";
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 602);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtAssets);
            this.Controls.Add(this.lblNisab);
            this.Controls.Add(this.lblNisabSilver);
            this.Controls.Add(this.lblAssets);
            this.Controls.Add(this.lblNisabGold);
            this.Controls.Add(this.lblNisabSilverValue);
            this.Controls.Add(this.lblSilverValue);
            this.Controls.Add(this.lblSilverPrice);
            this.Controls.Add(this.lblGoldValue);
            this.Controls.Add(this.lblGoldPrice);
            this.Controls.Add(this.lblNISABCALCULATOR);
            this.Name = "Form17";
            this.Text = "Nisab Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNISABCALCULATOR;
        private System.Windows.Forms.Label lblGoldPrice;
        private System.Windows.Forms.Label lblGoldValue;
        private System.Windows.Forms.Label lblSilverPrice;
        private System.Windows.Forms.Label lblSilverValue;
        private System.Windows.Forms.Label lblNisabSilverValue;
        private System.Windows.Forms.Label lblNisabGold;
        private System.Windows.Forms.Label lblAssets;
        private System.Windows.Forms.Label lblNisabSilver;
        private System.Windows.Forms.Label lblNisab;
        private System.Windows.Forms.TextBox txtAssets;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;
    }
}