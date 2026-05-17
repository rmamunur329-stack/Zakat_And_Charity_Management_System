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
    public partial class Form4 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form4()
        {
            InitializeComponent();
            btnLogout.Text = "Logout";
            btnApplyforAid.Text = "Apply\nfor Aid";
            btnAidHistory.Text = "Aid\nHistory";
            btnMyProfile.Text = "My\nProfile";

            this.Load -= Form4_Load;
            this.Load += Form4_Load;

            btnApplyforAid.Click -= btnApplyforAid_Click;
            btnApplyforAid.Click += btnApplyforAid_Click;

            btnAidHistory.Click -= btnAidHistory_Click;
            btnAidHistory.Click += btnAidHistory_Click;

            btnMyProfile.Click -= btnMyProfile_Click;
            btnMyProfile.Click += btnMyProfile_Click;

            btnLogout.Click -= btnLogout_Click;
            btnLogout.Click += btnLogout_Click;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            LoadBeneficiaryName();
        }
        private void LoadBeneficiaryName()
        {
            if (Form1.LoggedInEmail == "")
            {
                llblTitle.Text = "Welcome, Beneficiary";
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT FullName FROM Users WHERE Email = @Email";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", Form1.LoggedInEmail);

                    try
                    {
                        con.Open();

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            llblTitle.Text = "Welcome, " + result.ToString();
                        }
                        else
                        {
                            llblTitle.Text = "Welcome, Beneficiary";
                        }
                    }
                    catch
                    {
                        llblTitle.Text = "Welcome, Beneficiary";
                    }
                }
            }
        }

        private void btnApplyforAid_Click(object sender, EventArgs e)
        {
            {
                Form5 form5 = new Form5();
                form5.Show();
            }
        }

        private void btnAidHistory_Click(object sender, EventArgs e)
        {
            {
                Form6 form6 = new Form6();
                form6.Show();
            }
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            {
                Form7 form7 = new Form7();
                form7.Show();
            }

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Form1.LoggedInEmail = "";
                Form1.LoggedInRole = "";

                Form1 login = new Form1();
                login.Show();

                this.Close();
            }
        }
    }
}
