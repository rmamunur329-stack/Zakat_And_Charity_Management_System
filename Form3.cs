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
    
    public partial class Form3 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form3()
        {
            InitializeComponent();
            this.Load -= Form3_Load;
            this.Load += Form3_Load;

            btnManageUser.Click -= btnManageUser_Click;
            btnManageUser.Click += btnManageUser_Click;

            btnManageBeneficiaries.Click -= btnManageBeneficiaries_Click;
            btnManageBeneficiaries.Click += btnManageBeneficiaries_Click;

            btnManageDonations.Click -= btnManageDonations_Click;
            btnManageDonations.Click += btnManageDonations_Click;

            btnManageCampaigns.Click -= btnManageCampaigns_Click;
            btnManageCampaigns.Click += btnManageCampaigns_Click;

            btnDistribution.Click -= btnDistribution_Click;
            btnDistribution.Click += btnDistribution_Click;

            btnEligibleFilter.Click -= btnEligibleFilter_Click;
            btnEligibleFilter.Click += btnEligibleFilter_Click;

            btnDonorLeaderboard.Click -= btnDonorLeaderboard_Click;
            btnDonorLeaderboard.Click += btnDonorLeaderboard_Click;

            btnReports.Click -= btnReports_Click;
            btnReports.Click += btnReports_Click;

            btnLogout.Click -= btnLogout_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }
        private void LoadDashboardData()
        {
            lblTotalDonors.Text = "Total\nDonors\n" + GetCount("SELECT COUNT(*) FROM Users WHERE LoginAs = 'Donor'");
            lblBeneficiaries.Text = "Beneficiaries\n" + GetCount("SELECT COUNT(*) FROM Users WHERE LoginAs = 'Beneficiary'");
            lblZakatCollected.Text = "Zakat\nCollected\n" + GetAmount("SELECT ISNULL(SUM(Amount), 0) FROM Donations WHERE DonationType = 'Zakat'");
            lblCharityCollected.Text = "Charity\nCollected\n" + GetAmount("SELECT ISNULL(SUM(Amount), 0) FROM Donations WHERE DonationType = 'Charity'");
            lblDistributed.Text = "Distributed\n" + GetAmount("SELECT ISNULL(SUM(Amount), 0) FROM Distributions");
            lblActiveCampaigns.Text = "Active\nCampaigns\n" + GetCount("SELECT COUNT(*) FROM Campaigns WHERE Status = 'Active'");
        }

        private int GetCount(string query)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch
            {
                return 0;
            }
        }

        private string GetAmount(string query)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    decimal amount = Convert.ToDecimal(cmd.ExecuteScalar());
                    return amount.ToString("0.00");
                }
            }
            catch
            {
                return "0.00";
            }
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            Form8 users = new Form8();
            users.Show();
        }

        private void btnManageBeneficiaries_Click(object sender, EventArgs e)
        {
            Form9 beneficiaries = new Form9();
            beneficiaries.Show();
        }

        private void btnManageDonations_Click(object sender, EventArgs e)
        {
            Form10 donations = new Form10();
            donations.Show();
        }

        private void btnManageCampaigns_Click(object sender, EventArgs e)
        {
            Form11 campaigns = new Form11();
            campaigns.Show();
        }

        private void btnDistribution_Click(object sender, EventArgs e)
        {
            Form12 distribution = new Form12();
            distribution.Show();
        }

        private void btnEligibleFilter_Click(object sender, EventArgs e)
        {
            Form13 eligible = new Form13();
            eligible.Show();
        }

        private void btnDonorLeaderboard_Click(object sender, EventArgs e)
        {
            Form14 leaderboard = new Form14();
            leaderboard.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Form15 reports = new Form15();
            reports.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1.LoggedInEmail = "";
            Form1.LoggedInRole = "";

            Form1 login = new Form1();
            login.Show();

            this.Hide();
        }

        private void btnManageUser_Click_1(object sender, EventArgs e)
        {

        }

        private void lblActiveCampaigns_Click(object sender, EventArgs e)
        {

        }
    }
}
