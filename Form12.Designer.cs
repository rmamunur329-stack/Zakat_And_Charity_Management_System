namespace Zakat_And_Charity_Management
{
    partial class Form12
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
            this.pnlTotalVerifiedPayments = new System.Windows.Forms.Panel();
            this.pnlTotalEligibleBeneficiaries = new System.Windows.Forms.Panel();
            this.pnlTotalDistributed = new System.Windows.Forms.Panel();
            this.pnlRemainingAmount = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblEligible = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.btnDistributeSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Green;
            this.lblTitle.Location = new System.Drawing.Point(12, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(281, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📦 Distribution of Zakat/Charity";
            // 
            // pnlTotalVerifiedPayments
            // 
            this.pnlTotalVerifiedPayments.Location = new System.Drawing.Point(30, 101);
            this.pnlTotalVerifiedPayments.Name = "pnlTotalVerifiedPayments";
            this.pnlTotalVerifiedPayments.Size = new System.Drawing.Size(192, 103);
            this.pnlTotalVerifiedPayments.TabIndex = 1;
            // 
            // pnlTotalEligibleBeneficiaries
            // 
            this.pnlTotalEligibleBeneficiaries.Location = new System.Drawing.Point(264, 101);
            this.pnlTotalEligibleBeneficiaries.Name = "pnlTotalEligibleBeneficiaries";
            this.pnlTotalEligibleBeneficiaries.Size = new System.Drawing.Size(192, 103);
            this.pnlTotalEligibleBeneficiaries.TabIndex = 2;
            // 
            // pnlTotalDistributed
            // 
            this.pnlTotalDistributed.Location = new System.Drawing.Point(501, 101);
            this.pnlTotalDistributed.Name = "pnlTotalDistributed";
            this.pnlTotalDistributed.Size = new System.Drawing.Size(192, 103);
            this.pnlTotalDistributed.TabIndex = 3;
            // 
            // pnlRemainingAmount
            // 
            this.pnlRemainingAmount.Location = new System.Drawing.Point(741, 101);
            this.pnlRemainingAmount.Name = "pnlRemainingAmount";
            this.pnlRemainingAmount.Size = new System.Drawing.Size(192, 103);
            this.pnlRemainingAmount.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Green;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(834, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 43);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblEligible
            // 
            this.lblEligible.AutoSize = true;
            this.lblEligible.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEligible.ForeColor = System.Drawing.Color.Green;
            this.lblEligible.Location = new System.Drawing.Point(26, 245);
            this.lblEligible.Name = "lblEligible";
            this.lblEligible.Size = new System.Drawing.Size(295, 20);
            this.lblEligible.TabIndex = 6;
            this.lblEligible.Text = "Eligible Beneficiaries (Verified Payments)";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(30, 301);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(903, 318);
            this.dataGridView.TabIndex = 7;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(834, 636);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(99, 22);
            this.txtTotalAmount.TabIndex = 8;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(659, 636);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(168, 20);
            this.lblTotalAmount.TabIndex = 9;
            this.lblTotalAmount.Text = "Total Selected Account";
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSelection.Location = new System.Drawing.Point(58, 684);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(164, 47);
            this.btnClearSelection.TabIndex = 10;
            this.btnClearSelection.Text = "❌ Clear Selection";
            this.btnClearSelection.UseVisualStyleBackColor = true;
            // 
            // btnDistributeSelected
            // 
            this.btnDistributeSelected.BackColor = System.Drawing.Color.Green;
            this.btnDistributeSelected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistributeSelected.ForeColor = System.Drawing.Color.White;
            this.btnDistributeSelected.Location = new System.Drawing.Point(786, 687);
            this.btnDistributeSelected.Name = "btnDistributeSelected";
            this.btnDistributeSelected.Size = new System.Drawing.Size(147, 56);
            this.btnDistributeSelected.TabIndex = 11;
            this.btnDistributeSelected.Text = "✅ Distribute Selected";
            this.btnDistributeSelected.UseVisualStyleBackColor = false;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 773);
            this.Controls.Add(this.btnDistributeSelected);
            this.Controls.Add(this.btnClearSelection);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblEligible);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pnlRemainingAmount);
            this.Controls.Add(this.pnlTotalDistributed);
            this.Controls.Add(this.pnlTotalEligibleBeneficiaries);
            this.Controls.Add(this.pnlTotalVerifiedPayments);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form12";
            this.Text = "Distribution of Zakat/Charity";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTotalVerifiedPayments;
        private System.Windows.Forms.Panel pnlTotalEligibleBeneficiaries;
        private System.Windows.Forms.Panel pnlTotalDistributed;
        private System.Windows.Forms.Panel pnlRemainingAmount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblEligible;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.Button btnDistributeSelected;
    }
}