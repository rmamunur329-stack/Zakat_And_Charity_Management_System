namespace Zakat_And_Charity_Management
{
    partial class Form10
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabZakatPayments = new System.Windows.Forms.TabPage();
            this.tabCharity = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblZakatPayment = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnRefreshMain = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh11 = new System.Windows.Forms.Button();
            this.lblCharity = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabZakatPayments.SuspendLayout();
            this.tabCharity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabZakatPayments);
            this.tabControl1.Controls.Add(this.tabCharity);
            this.tabControl1.Location = new System.Drawing.Point(28, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 624);
            this.tabControl1.TabIndex = 0;
            // 
            // tabZakatPayments
            // 
            this.tabZakatPayments.BackColor = System.Drawing.Color.Transparent;
            this.tabZakatPayments.Controls.Add(this.dataGridView);
            this.tabZakatPayments.Controls.Add(this.lblZakatPayment);
            this.tabZakatPayments.Controls.Add(this.btnRefresh);
            this.tabZakatPayments.ForeColor = System.Drawing.Color.Green;
            this.tabZakatPayments.Location = new System.Drawing.Point(4, 25);
            this.tabZakatPayments.Name = "tabZakatPayments";
            this.tabZakatPayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabZakatPayments.Size = new System.Drawing.Size(903, 595);
            this.tabZakatPayments.TabIndex = 0;
            this.tabZakatPayments.Text = "Zakat Payments";
            // 
            // tabCharity
            // 
            this.tabCharity.Controls.Add(this.lblCharity);
            this.tabCharity.Controls.Add(this.btnRefresh11);
            this.tabCharity.Controls.Add(this.dataGridView1);
            this.tabCharity.Location = new System.Drawing.Point(4, 25);
            this.tabCharity.Name = "tabCharity";
            this.tabCharity.Padding = new System.Windows.Forms.Padding(3);
            this.tabCharity.Size = new System.Drawing.Size(903, 595);
            this.tabCharity.TabIndex = 1;
            this.tabCharity.Text = "Charity Donations";
            this.tabCharity.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Green;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(719, 61);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 40);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblZakatPayment
            // 
            this.lblZakatPayment.AutoSize = true;
            this.lblZakatPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZakatPayment.ForeColor = System.Drawing.Color.Green;
            this.lblZakatPayment.Location = new System.Drawing.Point(32, 84);
            this.lblZakatPayment.Name = "lblZakatPayment";
            this.lblZakatPayment.Size = new System.Drawing.Size(216, 31);
            this.lblZakatPayment.TabIndex = 1;
            this.lblZakatPayment.Text = "💵 Zakat Payments";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView.Location = new System.Drawing.Point(0, 154);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(903, 327);
            this.dataGridView.TabIndex = 2;
            // 
            // btnRefreshMain
            // 
            this.btnRefreshMain.BackColor = System.Drawing.Color.Green;
            this.btnRefreshMain.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshMain.ForeColor = System.Drawing.Color.White;
            this.btnRefreshMain.Location = new System.Drawing.Point(540, 747);
            this.btnRefreshMain.Name = "btnRefreshMain";
            this.btnRefreshMain.Size = new System.Drawing.Size(143, 40);
            this.btnRefreshMain.TabIndex = 1;
            this.btnRefreshMain.Text = "🔄 Refresh";
            this.btnRefreshMain.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.BackColor = System.Drawing.Color.Red;
            this.btnDeleteSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelected.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSelected.Location = new System.Drawing.Point(725, 747);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(191, 40);
            this.btnDeleteSelected.TabIndex = 2;
            this.btnDeleteSelected.Text = "🗑️ Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = false;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(903, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnRefresh11
            // 
            this.btnRefresh11.BackColor = System.Drawing.Color.Green;
            this.btnRefresh11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh11.ForeColor = System.Drawing.Color.White;
            this.btnRefresh11.Location = new System.Drawing.Point(721, 91);
            this.btnRefresh11.Name = "btnRefresh11";
            this.btnRefresh11.Size = new System.Drawing.Size(136, 44);
            this.btnRefresh11.TabIndex = 1;
            this.btnRefresh11.Text = "🔄 Refresh";
            this.btnRefresh11.UseVisualStyleBackColor = false;
            // 
            // lblCharity
            // 
            this.lblCharity.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharity.ForeColor = System.Drawing.Color.Green;
            this.lblCharity.Location = new System.Drawing.Point(82, 91);
            this.lblCharity.Name = "lblCharity";
            this.lblCharity.Size = new System.Drawing.Size(170, 33);
            this.lblCharity.TabIndex = 2;
            this.lblCharity.Text = "Charity Donations";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 808);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnRefreshMain);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form10";
            this.Text = "Manage Donations";
            this.tabControl1.ResumeLayout(false);
            this.tabZakatPayments.ResumeLayout(false);
            this.tabZakatPayments.PerformLayout();
            this.tabCharity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabZakatPayments;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblZakatPayment;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabPage tabCharity;
        private System.Windows.Forms.Button btnRefreshMain;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnRefresh11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCharity;
    }
}