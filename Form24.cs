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
    public partial class Form24 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form24()
        {
            InitializeComponent();

            lblTitle.Text = "Donation History";
            btnRefresh.Text = "Refresh";
            btnBack.Text = "Back";

            this.Load -= Form24_Load;
            this.Load += Form24_Load;

            btnRefresh.Click -= btnRefresh_Click;
            btnRefresh.Click += btnRefresh_Click;

            btnBack.Click -= btnBack_Click;
            btnBack.Click += btnBack_Click;
        }
        private void Form24_Load(object sender, EventArgs e)
        {
            LoadDonationHistory();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDonationHistory();
        }

        private void LoadDonationHistory()
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
                                    DonationType,
                                    Amount,
                                    PaymentMethod,
                                    TransactionNo,
                                    Note,
                                    DonationDate
                                 FROM Donations
                                 WHERE DonorEmail = @DonorEmail
                                 ORDER BY DonationDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DonorEmail", Form1.LoggedInEmail);

                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dgvDonationHistory.DataSource = dt;
                        dgvDonationHistory.ReadOnly = true;
                        dgvDonationHistory.AllowUserToAddRows = false;
                        dgvDonationHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvDonationHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
