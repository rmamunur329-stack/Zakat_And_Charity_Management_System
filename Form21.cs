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
    public partial class Form21 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form21()
        {
            InitializeComponent();
            lblTitle.Text = "Zakat History";
            btnRefresh.Text = "Refresh";
            btnBack.Text = "Back";

            this.Load -= Form21_Load;
            this.Load += Form21_Load;

            btnRefresh.Click -= btnRefresh_Click;
            btnRefresh.Click += btnRefresh_Click;

            btnBack.Click -= btnBack_Click;
            btnBack.Click += btnBack_Click;
        }
        private void Form21_Load(object sender, EventArgs e)
        {
            LoadZakatHistory();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadZakatHistory();
        }

        private void LoadZakatHistory()
        {
            if (Form1.LoggedInEmail == "")
            {
                MessageBox.Show("Please login first.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT 
                                    DonationID,
                                    DonorEmail,
                                    DonationType,
                                    Amount,
                                    DonationDate
                                 FROM Donations
                                 WHERE DonorEmail = @DonorEmail
                                 AND DonationType = 'Zakat'
                                 ORDER BY DonationDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DonorEmail", Form1.LoggedInEmail);

                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dataGridViewZakatHistory.DataSource = dt;
                        dataGridViewZakatHistory.ReadOnly = true;
                        dataGridViewZakatHistory.AllowUserToAddRows = false;
                        dataGridViewZakatHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dataGridViewZakatHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
