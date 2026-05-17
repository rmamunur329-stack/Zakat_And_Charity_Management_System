namespace Zakat_And_Charity_Management
{
    partial class Form7
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
            this.lblMyProfile = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblMonthlyIncome = new System.Windows.Forms.Label();
            this.txtMonthlyIncome = new System.Windows.Forms.TextBox();
            this.lblFamilyMembers = new System.Windows.Forms.Label();
            this.txtFamilyMembers = new System.Windows.Forms.TextBox();
            this.lblNID = new System.Windows.Forms.Label();
            this.txtNID = new System.Windows.Forms.TextBox();
            this.lblVerified = new System.Windows.Forms.Label();
            this.cmbVerified = new System.Windows.Forms.ComboBox();
            this.lblEligible = new System.Windows.Forms.Label();
            this.cmbEligible = new System.Windows.Forms.ComboBox();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMyProfile
            // 
            this.lblMyProfile.AutoSize = true;
            this.lblMyProfile.BackColor = System.Drawing.Color.Green;
            this.lblMyProfile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyProfile.ForeColor = System.Drawing.Color.White;
            this.lblMyProfile.Location = new System.Drawing.Point(68, 52);
            this.lblMyProfile.Name = "lblMyProfile";
            this.lblMyProfile.Size = new System.Drawing.Size(122, 23);
            this.lblMyProfile.TabIndex = 0;
            this.lblMyProfile.Text = "👤 My Profile";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(95, 141);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(89, 20);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(95, 194);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(211, 140);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(129, 22);
            this.txtFullName.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(211, 191);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(129, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(95, 243);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(49, 16);
            this.lblphone.TabIndex = 5;
            this.lblphone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(211, 240);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(125, 22);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Location = new System.Drawing.Point(95, 297);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(81, 20);
            this.lblCatagory.TabIndex = 7;
            this.lblCatagory.Text = "Catagory:";
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.FormattingEnabled = true;
            this.cmbCatagory.Items.AddRange(new object[] {
            "1.💸 Poor",
            "2.🤲 Needy",
            "3.👶 Orphan",
            "4.👩 Widow",
            "5.🎓 Student",
            "6.💊 Medical Aid",
            "7.🏠 Shelter Support"});
            this.cmbCatagory.Location = new System.Drawing.Point(211, 295);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(129, 24);
            this.cmbCatagory.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(95, 356);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 16);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(211, 350);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(129, 22);
            this.txtAddress.TabIndex = 10;
            // 
            // lblMonthlyIncome
            // 
            this.lblMonthlyIncome.AutoSize = true;
            this.lblMonthlyIncome.Location = new System.Drawing.Point(502, 141);
            this.lblMonthlyIncome.Name = "lblMonthlyIncome";
            this.lblMonthlyIncome.Size = new System.Drawing.Size(154, 16);
            this.lblMonthlyIncome.TabIndex = 11;
            this.lblMonthlyIncome.Text = "Monthly Income (💵BDT):";
            // 
            // txtMonthlyIncome
            // 
            this.txtMonthlyIncome.Location = new System.Drawing.Point(698, 141);
            this.txtMonthlyIncome.Name = "txtMonthlyIncome";
            this.txtMonthlyIncome.Size = new System.Drawing.Size(135, 22);
            this.txtMonthlyIncome.TabIndex = 12;
            // 
            // lblFamilyMembers
            // 
            this.lblFamilyMembers.AutoSize = true;
            this.lblFamilyMembers.Location = new System.Drawing.Point(502, 191);
            this.lblFamilyMembers.Name = "lblFamilyMembers";
            this.lblFamilyMembers.Size = new System.Drawing.Size(110, 16);
            this.lblFamilyMembers.TabIndex = 13;
            this.lblFamilyMembers.Text = "Family Members:";
            // 
            // txtFamilyMembers
            // 
            this.txtFamilyMembers.Location = new System.Drawing.Point(698, 194);
            this.txtFamilyMembers.Name = "txtFamilyMembers";
            this.txtFamilyMembers.Size = new System.Drawing.Size(135, 22);
            this.txtFamilyMembers.TabIndex = 14;
            // 
            // lblNID
            // 
            this.lblNID.AutoSize = true;
            this.lblNID.Location = new System.Drawing.Point(502, 243);
            this.lblNID.Name = "lblNID";
            this.lblNID.Size = new System.Drawing.Size(110, 16);
            this.lblNID.TabIndex = 15;
            this.lblNID.Text = "NID (National ID):";
            // 
            // txtNID
            // 
            this.txtNID.Location = new System.Drawing.Point(698, 240);
            this.txtNID.Name = "txtNID";
            this.txtNID.Size = new System.Drawing.Size(135, 22);
            this.txtNID.TabIndex = 16;
            // 
            // lblVerified
            // 
            this.lblVerified.AutoSize = true;
            this.lblVerified.Location = new System.Drawing.Point(502, 297);
            this.lblVerified.Name = "lblVerified";
            this.lblVerified.Size = new System.Drawing.Size(59, 16);
            this.lblVerified.TabIndex = 17;
            this.lblVerified.Text = "Verified :";
            // 
            // cmbVerified
            // 
            this.cmbVerified.FormattingEnabled = true;
            this.cmbVerified.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbVerified.Location = new System.Drawing.Point(698, 293);
            this.cmbVerified.Name = "cmbVerified";
            this.cmbVerified.Size = new System.Drawing.Size(135, 24);
            this.cmbVerified.TabIndex = 18;
            // 
            // lblEligible
            // 
            this.lblEligible.AutoSize = true;
            this.lblEligible.Location = new System.Drawing.Point(502, 350);
            this.lblEligible.Name = "lblEligible";
            this.lblEligible.Size = new System.Drawing.Size(73, 20);
            this.lblEligible.TabIndex = 19;
            this.lblEligible.Text = "Eligible :";
            // 
            // cmbEligible
            // 
            this.cmbEligible.FormattingEnabled = true;
            this.cmbEligible.Items.AddRange(new object[] {
            "Yes ",
            "No"});
            this.cmbEligible.Location = new System.Drawing.Point(692, 348);
            this.cmbEligible.Name = "cmbEligible";
            this.cmbEligible.Size = new System.Drawing.Size(141, 24);
            this.cmbEligible.TabIndex = 20;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.Green;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProfile.Location = new System.Drawing.Point(220, 468);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(143, 69);
            this.btnUpdateProfile.TabIndex = 21;
            this.btnUpdateProfile.Text = "✏Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(547, 468);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 69);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "❌Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 623);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.cmbEligible);
            this.Controls.Add(this.lblEligible);
            this.Controls.Add(this.cmbVerified);
            this.Controls.Add(this.lblVerified);
            this.Controls.Add(this.txtNID);
            this.Controls.Add(this.lblNID);
            this.Controls.Add(this.txtFamilyMembers);
            this.Controls.Add(this.lblFamilyMembers);
            this.Controls.Add(this.txtMonthlyIncome);
            this.Controls.Add(this.lblMonthlyIncome);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.cmbCatagory);
            this.Controls.Add(this.lblCatagory);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblMyProfile);
            this.Name = "Form7";
            this.Text = "My Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMyProfile;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblMonthlyIncome;
        private System.Windows.Forms.TextBox txtMonthlyIncome;
        private System.Windows.Forms.Label lblFamilyMembers;
        private System.Windows.Forms.TextBox txtFamilyMembers;
        private System.Windows.Forms.Label lblNID;
        private System.Windows.Forms.TextBox txtNID;
        private System.Windows.Forms.Label lblVerified;
        private System.Windows.Forms.ComboBox cmbVerified;
        private System.Windows.Forms.Label lblEligible;
        private System.Windows.Forms.ComboBox cmbEligible;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnClose;
    }
}