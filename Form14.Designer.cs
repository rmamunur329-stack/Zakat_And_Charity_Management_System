namespace Zakat_And_Charity_Management
{
    partial class Form14
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
            this.lblTopDonorLeaderBoard = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlTotalDonor = new System.Windows.Forms.Panel();
            this.pnlTotalDonation = new System.Windows.Forms.Panel();
            this.pnlZakat = new System.Windows.Forms.Panel();
            this.pnlCharity = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLeaderBoard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTopDonorLeaderBoard
            // 
            this.lblTopDonorLeaderBoard.AutoSize = true;
            this.lblTopDonorLeaderBoard.BackColor = System.Drawing.Color.Green;
            this.lblTopDonorLeaderBoard.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopDonorLeaderBoard.ForeColor = System.Drawing.Color.White;
            this.lblTopDonorLeaderBoard.Location = new System.Drawing.Point(38, 49);
            this.lblTopDonorLeaderBoard.Name = "lblTopDonorLeaderBoard";
            this.lblTopDonorLeaderBoard.Size = new System.Drawing.Size(230, 23);
            this.lblTopDonorLeaderBoard.TabIndex = 0;
            this.lblTopDonorLeaderBoard.Text = "🏆 Top Donor Leaderboard";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(834, 37);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 41);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // pnlTotalDonor
            // 
            this.pnlTotalDonor.Location = new System.Drawing.Point(42, 108);
            this.pnlTotalDonor.Name = "pnlTotalDonor";
            this.pnlTotalDonor.Size = new System.Drawing.Size(189, 88);
            this.pnlTotalDonor.TabIndex = 2;
            // 
            // pnlTotalDonation
            // 
            this.pnlTotalDonation.Location = new System.Drawing.Point(295, 108);
            this.pnlTotalDonation.Name = "pnlTotalDonation";
            this.pnlTotalDonation.Size = new System.Drawing.Size(189, 88);
            this.pnlTotalDonation.TabIndex = 3;
            // 
            // pnlZakat
            // 
            this.pnlZakat.Location = new System.Drawing.Point(558, 108);
            this.pnlZakat.Name = "pnlZakat";
            this.pnlZakat.Size = new System.Drawing.Size(189, 88);
            this.pnlZakat.TabIndex = 4;
            // 
            // pnlCharity
            // 
            this.pnlCharity.Location = new System.Drawing.Point(806, 108);
            this.pnlCharity.Name = "pnlCharity";
            this.pnlCharity.Size = new System.Drawing.Size(189, 88);
            this.pnlCharity.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 251);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnLeaderBoard
            // 
            this.btnLeaderBoard.BackColor = System.Drawing.Color.Green;
            this.btnLeaderBoard.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderBoard.ForeColor = System.Drawing.Color.White;
            this.btnLeaderBoard.Location = new System.Drawing.Point(834, 529);
            this.btnLeaderBoard.Name = "btnLeaderBoard";
            this.btnLeaderBoard.Size = new System.Drawing.Size(161, 56);
            this.btnLeaderBoard.TabIndex = 7;
            this.btnLeaderBoard.Text = "📊 Export Leaderboard";
            this.btnLeaderBoard.UseVisualStyleBackColor = false;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 616);
            this.Controls.Add(this.btnLeaderBoard);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlCharity);
            this.Controls.Add(this.pnlZakat);
            this.Controls.Add(this.pnlTotalDonation);
            this.Controls.Add(this.pnlTotalDonor);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblTopDonorLeaderBoard);
            this.Name = "Form14";
            this.Text = "Top Donor Leaderboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopDonorLeaderBoard;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlTotalDonor;
        private System.Windows.Forms.Panel pnlTotalDonation;
        private System.Windows.Forms.Panel pnlZakat;
        private System.Windows.Forms.Panel pnlCharity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLeaderBoard;
    }
}