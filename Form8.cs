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
    public partial class Form8 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form8()
        {
            InitializeComponent();
            lblAllUsers.Text = "All Users";
            btnRefresh.Text = "Refresh";
            btnToggleActive.Text = "Active / Inactive";

            this.Load -= Form8_Load;
            this.Load += Form8_Load;

            btnRefresh.Click -= btnRefresh_Click;
            btnRefresh.Click += btnRefresh_Click;

            btnToggleActive.Click -= btnToggleActive_Click;
            btnToggleActive.Click += btnToggleActive_Click;
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT 
                                    UserID,
                                    FullName,
                                    Email,
                                    Phone,
                                    LoginAs,
                                    Verified,
                                    Eligible,
                                    IsActive
                                 FROM Users
                                 ORDER BY UserID DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dataGridView.DataSource = dt;
                        dataGridView.ReadOnly = true;
                        dataGridView.AllowUserToAddRows = false;
                        dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }

        private void btnToggleActive_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            int userId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["UserID"].Value);
            string email = dataGridView.SelectedRows[0].Cells["Email"].Value.ToString();
            string role = dataGridView.SelectedRows[0].Cells["LoginAs"].Value.ToString();
            bool isActive = Convert.ToBoolean(dataGridView.SelectedRows[0].Cells["IsActive"].Value);

            if (role == "Admin" && email == Form1.LoggedInEmail)
            {
                MessageBox.Show("You cannot deactivate your own admin account.");
                return;
            }

            bool newStatus = !isActive;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "UPDATE Users SET IsActive = @IsActive WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IsActive", newStatus);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show(newStatus ? "User activated." : "User deactivated.");

                        LoadUsers();
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
