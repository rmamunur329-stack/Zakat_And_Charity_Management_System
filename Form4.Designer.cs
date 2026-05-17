namespace Zakat_And_Charity_Management
{
    partial class Form4
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
            this.llblTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnApplyforAid = new System.Windows.Forms.Button();
            this.btnAidHistory = new System.Windows.Forms.Button();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // llblTitle
            // 
            this.llblTitle.BackColor = System.Drawing.Color.Green;
            this.llblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblTitle.ForeColor = System.Drawing.Color.White;
            this.llblTitle.Location = new System.Drawing.Point(22, 9);
            this.llblTitle.Name = "llblTitle";
            this.llblTitle.Size = new System.Drawing.Size(742, 76);
            this.llblTitle.TabIndex = 0;
            this.llblTitle.Text = "Welcome,Buddy";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(652, 26);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 39);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "🔓 Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnApplyforAid
            // 
            this.btnApplyforAid.BackColor = System.Drawing.Color.White;
            this.btnApplyforAid.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyforAid.ForeColor = System.Drawing.Color.Green;
            this.btnApplyforAid.Location = new System.Drawing.Point(82, 188);
            this.btnApplyforAid.Name = "btnApplyforAid";
            this.btnApplyforAid.Size = new System.Drawing.Size(134, 153);
            this.btnApplyforAid.TabIndex = 2;
            this.btnApplyforAid.Text = "📋 Apply for Aid";
            this.btnApplyforAid.UseVisualStyleBackColor = false;
            this.btnApplyforAid.Click += new System.EventHandler(this.btnApplyforAid_Click);
            // 
            // btnAidHistory
            // 
            this.btnAidHistory.BackColor = System.Drawing.Color.White;
            this.btnAidHistory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAidHistory.ForeColor = System.Drawing.Color.Green;
            this.btnAidHistory.Location = new System.Drawing.Point(297, 188);
            this.btnAidHistory.Name = "btnAidHistory";
            this.btnAidHistory.Size = new System.Drawing.Size(135, 153);
            this.btnAidHistory.TabIndex = 3;
            this.btnAidHistory.Text = "📜 Aid History";
            this.btnAidHistory.UseVisualStyleBackColor = false;
            this.btnAidHistory.Click += new System.EventHandler(this.btnAidHistory_Click);
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.BackColor = System.Drawing.Color.White;
            this.btnMyProfile.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyProfile.ForeColor = System.Drawing.Color.Green;
            this.btnMyProfile.Location = new System.Drawing.Point(512, 193);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(116, 148);
            this.btnMyProfile.TabIndex = 4;
            this.btnMyProfile.Text = "👤My Profile";
            this.btnMyProfile.UseVisualStyleBackColor = false;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 666);
            this.Controls.Add(this.btnMyProfile);
            this.Controls.Add(this.btnAidHistory);
            this.Controls.Add(this.btnApplyforAid);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.llblTitle);
            this.Name = "Form4";
            this.Text = "Beneficiary Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label llblTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnApplyforAid;
        private System.Windows.Forms.Button btnAidHistory;
        private System.Windows.Forms.Button btnMyProfile;
    }
}