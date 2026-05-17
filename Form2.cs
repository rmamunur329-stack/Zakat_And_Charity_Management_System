using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zakat_And_Charity_Management
{
    public partial class Form2 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form2()
        { 
            InitializeComponent();

            lblFullName.Text = "Full Name :";
            lblEmail.Text = "Email :";
            lblPhone.Text = "Phone :";
            lblPassword.Text = "Password :";
            lblConfirmPassword.Text = "Confirm Password :";
            lblRegisteras.Text = "Register As :";

            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

            cmbResisteras.Items.Clear();
            cmbResisteras.Items.Add("Donor");
            cmbResisteras.Items.Add("Beneficiary");
            cmbResisteras.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string registerAs = cmbResisteras.Text.Trim();

            if (fullName == "" || email == "" || phone == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password and confirm password do not match.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";

                string insertQuery = @"INSERT INTO Users
                                       (FullName, Email, Phone, Password, LoginAs, Verified, Eligible)
                                       VALUES
                                       (@FullName, @Email, @Phone, @Password, @LoginAs, 'No', 'No')";

                try
                {
                    con.Open();

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);

                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (exists > 0)
                        {
                            MessageBox.Show("This email is already registered.");
                            return;
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@LoginAs", registerAs);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registration successful.");

                        Form1 login = new Form1();
                        login.Show();

                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error:\n" + ex.Message);
                }
            }
        }
    }
}
