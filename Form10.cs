using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Zakat_And_Charity_Management
{
    public partial class Form10 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form10()
        {
            InitializeComponent();
            tabZakatPayments.Text = "Zakat Payments";
            tabCharity.Text = "Charity Donations";

            lblZakatPayment.Text = "Zakat Payments";
            lblCharity.Text = "Charity Donations";

            btnRefresh.Text = "Refresh";
            btnRefresh11.Text = "Refresh";
            btnRefreshMain.Text = "Refresh";
            btnDeleteSelected.Text = "Delete Selected";

            this.Load -= Form10_Load;
            this.Load += Form10_Load;

            btnRefresh.Click -= btnRefresh_Click;
            btnRefresh.Click += btnRefresh_Click;

            btnRefresh11.Click -= btnRefresh11_Click;
            btnRefresh11.Click += btnRefresh11_Click;

            btnRefreshMain.Click -= btnRefreshMain_Click;
            btnRefreshMain.Click += btnRefreshMain_Click;

            btnDeleteSelected.Click -= btnDeleteSelected_Click;
            btnDeleteSelected.Click += btnDeleteSelected_Click;
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            LoadZakatPayments();
            LoadCharityDonations();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadZakatPayments();
        }
        private void btnRefresh11_Click(object sender, EventArgs e)
        {
            LoadCharityDonations();
        }
        private void btnRefreshMain_Click(object sender, EventArgs e)
        {
            LoadZakatPayments();
            LoadCharityDonations();
        }
        private void LoadZakatPayments()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT 
                                    DonationID,
                                    DonorEmail,
                                    DonationType,
                                    Amount,
                                    DonationDate
                                 FROM Donations
                                 WHERE DonationType = 'Zakat'
                                 ORDER BY DonationDate DESC";

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
        private void LoadCharityDonations()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT 
                                    DonationID,
                                    DonorEmail,
                                    DonationType,
                                    Amount,
                                    DonationDate
                                 FROM Donations
                                 WHERE DonationType = 'Charity'
                                 ORDER BY DonationDate DESC";

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


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            int donationId = 0;

            if (tabControl1.SelectedTab == tabZakatPayments)
            {
                if (dataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Zakat payment first.");
                    return;
                }

                donationId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["DonationID"].Value);
            }
            else if (tabControl1.SelectedTab == tabCharity)
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Charity donation first.");
                    return;
                }

                donationId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DonationID"].Value);
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this donation?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "DELETE FROM Donations WHERE DonationID = @DonationID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DonationID", donationId);

                    try
                    {
                        con.Open();

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Donation deleted successfully.");
                            LoadZakatPayments();
                            LoadCharityDonations();
                        }
                        else
                        {
                            MessageBox.Show("Delete failed.");
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
