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
    
    public partial class Form6 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form6()
        {
            InitializeComponent();
            lblApplyForAID.Text = "Aid History";
            btnRefresh.Text = "Refresh";

            this.Load += Form6_Load;
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            LoadAidHistory();
        }

        private void LoadAidHistory()
        {
            if (Form1.LoggedInEmail == "")
            {
                MessageBox.Show("Please login first.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT 
                                    ApplicationID,
                                    Category,
                                    Address,
                                    MonthlyIncome,
                                    FamilyMembers,
                                    Status,
                                    ApplicationDate
                                 FROM AidApplications
                                 WHERE Email = @Email
                                 ORDER BY ApplicationDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", Form1.LoggedInEmail);

                    try
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dataGridView1.DataSource = dt;
                        }

                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.ReadOnly = true;
                        dataGridView1.AllowUserToAddRows = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAidHistory();
        }
    }
}
