using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Zakat_And_Charity_Management
{
    public partial class Form9 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form9()
        {
            InitializeComponent();
            lblAllBeneficiaries.Text = "All Beneficiaries";
            btnVerify.Text = "Verify / Make Eligible";
            btnRevoke.Text = "Revoke Eligibility";

            this.Load -= Form9_Load;
            this.Load += Form9_Load;

            btnVerify.Click -= btnVerify_Click;
            btnVerify.Click += btnVerify_Click;

            btnRevoke.Click -= btnRevoke_Click;
            btnRevoke.Click += btnRevoke_Click;
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            LoadBeneficiaries();
        }
        private void LoadBeneficiaries()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT 
                                    UserID,
                                    FullName,
                                    Email,
                                    Phone,
                                    Category,
                                    Address,
                                    MonthlyIncome,
                                    FamilyMembers,
                                    NID,
                                    Verified,
                                    Eligible
                                 FROM Users
                                 WHERE LoginAs = 'Beneficiary'
                                 ORDER BY UserID DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dataGridView1.DataSource = dt;
                        dataGridView1.ReadOnly = true;
                        dataGridView1.AllowUserToAddRows = false;
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a beneficiary first.");
                return;
            }

            int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value);

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"UPDATE Users
                                 SET Verified = 'Yes',
                                     Eligible = 'Yes'
                                 WHERE UserID = @UserID
                                 AND LoginAs = 'Beneficiary'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Beneficiary verified and marked eligible.");
                        LoadBeneficiaries();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a beneficiary first.");
                return;
            }

            int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value);

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"UPDATE Users
                                 SET Eligible = 'No'
                                 WHERE UserID = @UserID
                                 AND LoginAs = 'Beneficiary'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Beneficiary eligibility revoked.");
                        LoadBeneficiaries();
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
