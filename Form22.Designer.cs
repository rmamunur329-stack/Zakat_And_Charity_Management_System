namespace Zakat_And_Charity_Management
{
    partial class Form22
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
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblDonorName = new System.Windows.Forms.Label();
            this.dgvVerifiedPayments = new System.Windows.Forms.DataGridView();
            this.dgvCertificates = new System.Windows.Forms.DataGridView();
            this.btnViewCertificate = new System.Windows.Forms.Button();
            this.txtDonorName = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblIssuedAt = new System.Windows.Forms.Label();
            this.txtIssuedAt = new System.Windows.Forms.TextBox();
            this.lblCertificateNo = new System.Windows.Forms.Label();
            this.txtCertificateNo = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerifiedPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificates)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Green;
            this.lblTitle.Location = new System.Drawing.Point(54, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(301, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🏅 Zakat Certificates";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(54, 240);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(248, 25);
            this.lblPayment.TabIndex = 1;
            this.lblPayment.Text = "✅ Your Verified Payments:";
            // 
            // lblDonorName
            // 
            this.lblDonorName.AutoSize = true;
            this.lblDonorName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorName.Location = new System.Drawing.Point(148, 282);
            this.lblDonorName.Name = "lblDonorName";
            this.lblDonorName.Size = new System.Drawing.Size(102, 20);
            this.lblDonorName.TabIndex = 2;
            this.lblDonorName.Text = "Donor Name:";
            // 
            // dgvVerifiedPayments
            // 
            this.dgvVerifiedPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvVerifiedPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerifiedPayments.Location = new System.Drawing.Point(263, 226);
            this.dgvVerifiedPayments.Name = "dgvVerifiedPayments";
            this.dgvVerifiedPayments.RowHeadersWidth = 51;
            this.dgvVerifiedPayments.RowTemplate.Height = 24;
            this.dgvVerifiedPayments.Size = new System.Drawing.Size(180, 39);
            this.dgvVerifiedPayments.TabIndex = 3;
            // 
            // dgvCertificates
            // 
            this.dgvCertificates.BackgroundColor = System.Drawing.Color.White;
            this.dgvCertificates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCertificates.Location = new System.Drawing.Point(586, 209);
            this.dgvCertificates.Name = "dgvCertificates";
            this.dgvCertificates.RowHeadersWidth = 51;
            this.dgvCertificates.RowTemplate.Height = 24;
            this.dgvCertificates.Size = new System.Drawing.Size(246, 279);
            this.dgvCertificates.TabIndex = 4;
            // 
            // btnViewCertificate
            // 
            this.btnViewCertificate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCertificate.Location = new System.Drawing.Point(641, 134);
            this.btnViewCertificate.Name = "btnViewCertificate";
            this.btnViewCertificate.Size = new System.Drawing.Size(138, 44);
            this.btnViewCertificate.TabIndex = 5;
            this.btnViewCertificate.Text = "View Certificate";
            this.btnViewCertificate.UseVisualStyleBackColor = true;
            // 
            // txtDonorName
            // 
            this.txtDonorName.Location = new System.Drawing.Point(263, 282);
            this.txtDonorName.Name = "txtDonorName";
            this.txtDonorName.Size = new System.Drawing.Size(180, 25);
            this.txtDonorName.TabIndex = 6;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(137, 333);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(113, 20);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount (BDT) :";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(263, 333);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(180, 25);
            this.txtAmount.TabIndex = 8;
            // 
            // lblIssuedAt
            // 
            this.lblIssuedAt.AutoSize = true;
            this.lblIssuedAt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedAt.Location = new System.Drawing.Point(178, 383);
            this.lblIssuedAt.Name = "lblIssuedAt";
            this.lblIssuedAt.Size = new System.Drawing.Size(74, 20);
            this.lblIssuedAt.TabIndex = 9;
            this.lblIssuedAt.Text = "Issued At:";
            // 
            // txtIssuedAt
            // 
            this.txtIssuedAt.Location = new System.Drawing.Point(263, 383);
            this.txtIssuedAt.Name = "txtIssuedAt";
            this.txtIssuedAt.Size = new System.Drawing.Size(180, 25);
            this.txtIssuedAt.TabIndex = 10;
            // 
            // lblCertificateNo
            // 
            this.lblCertificateNo.AutoSize = true;
            this.lblCertificateNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertificateNo.Location = new System.Drawing.Point(148, 438);
            this.lblCertificateNo.Name = "lblCertificateNo";
            this.lblCertificateNo.Size = new System.Drawing.Size(107, 20);
            this.lblCertificateNo.TabIndex = 11;
            this.lblCertificateNo.Text = "Certificate No:";
            // 
            // txtCertificateNo
            // 
            this.txtCertificateNo.Location = new System.Drawing.Point(263, 438);
            this.txtCertificateNo.Name = "txtCertificateNo";
            this.txtCertificateNo.Size = new System.Drawing.Size(180, 25);
            this.txtCertificateNo.TabIndex = 12;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(214, 597);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 42);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPDF.Location = new System.Drawing.Point(394, 597);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(114, 42);
            this.btnExportPDF.TabIndex = 14;
            this.btnExportPDF.Text = "Export PDF";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(569, 597);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 42);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 794);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtCertificateNo);
            this.Controls.Add(this.lblCertificateNo);
            this.Controls.Add(this.txtIssuedAt);
            this.Controls.Add(this.lblIssuedAt);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtDonorName);
            this.Controls.Add(this.btnViewCertificate);
            this.Controls.Add(this.dgvCertificates);
            this.Controls.Add(this.dgvVerifiedPayments);
            this.Controls.Add(this.lblDonorName);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form22";
            this.Text = "Zakat Certificate";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerifiedPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblDonorName;
        private System.Windows.Forms.DataGridView dgvVerifiedPayments;
        private System.Windows.Forms.DataGridView dgvCertificates;
        private System.Windows.Forms.Button btnViewCertificate;
        private System.Windows.Forms.TextBox txtDonorName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblIssuedAt;
        private System.Windows.Forms.TextBox txtIssuedAt;
        private System.Windows.Forms.Label lblCertificateNo;
        private System.Windows.Forms.TextBox txtCertificateNo;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnBack;
    }
}