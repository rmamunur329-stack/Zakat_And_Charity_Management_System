using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Zakat_And_Charity_Management
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public static string LoggedInEmail = "";
        public static string LoggedInRole = "";
        public Form1()
        {
            InitializeComponent();
            lblEmail.Text = "Email:";
            lblPassword.Text = "Password:";
            lblLoginas.Text = "Login as:";

            chkPassword.Text = "Show";
            chkRememberMe.Text = "Remember Me";

            txtPassword.UseSystemPasswordChar = true;

            cmbLoginas.Items.Clear();
            cmbLoginas.Items.Add("Admin");
            cmbLoginas.Items.Add("Donor");
            cmbLoginas.Items.Add("Beneficiary");
            cmbLoginas.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkPassword.Checked;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();// hides Form
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string loginAs = cmbLoginas.Text.Trim();

            if (email == "" || password == "" || loginAs == "")
            {
                MessageBox.Show("Please fill the form.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT * FROM Users
                                 WHERE Email = @Email
                                 AND Password = @Password
                                 AND LoginAs = @LoginAs";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@LoginAs", loginAs);

                    try
                    {
                        con.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                MessageBox.Show("Login successful.");

                                LoggedInEmail = email;
                                LoggedInRole = loginAs;

                                if (loginAs == "Admin")
                                {
                                    Form3 admin = new Form3();
                                    admin.Show();
                                    this.Hide();
                                }
                                else if (loginAs == "Beneficiary")
                                {
                                    Form4 beneficiary = new Form4();
                                    beneficiary.Show();
                                    this.Hide();
                                }
                                else if (loginAs == "Donor")
                                {
                                    Form16 donor = new Form16();
                                    donor.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid email, password, or login type.");
                            }
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
}