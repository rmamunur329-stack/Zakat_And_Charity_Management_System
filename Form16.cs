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
    public partial class Form16 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form16()
        {
            InitializeComponent();
            btnLogout.Text = "Logout";
            btnNishabCalculator.Text = "Nisab\nCalculator";
            btnZakatCalculator.Text = "Zakat\nCalculator";
            btnHawlTracker.Text = "Hawl\nTracker";
            btnPayZakat.Text = "Pay Zakat";
            btnZakatHistory.Text = "Zakat\nHistory";
            btnZakatCertificate.Text = "Zakat\nCertificate";
            btnOpenDonation.Text = "Open\nDonation";
            btnDonationHistory.Text = "Donation\nHistory";

            this.Load -= Form16_Load;
            this.Load += Form16_Load;

            btnLogout.Click -= btnLogout_Click;
            btnLogout.Click += btnLogout_Click;

            btnNishabCalculator.Click -= btnNishabCalculator_Click;
            btnNishabCalculator.Click += btnNishabCalculator_Click;

            btnZakatCalculator.Click -= btnZakatCalculator_Click;
            btnZakatCalculator.Click += btnZakatCalculator_Click;

            btnHawlTracker.Click -= btnHawlTracker_Click;
            btnHawlTracker.Click += btnHawlTracker_Click;

            btnPayZakat.Click -= btnPayZakat_Click;
            btnPayZakat.Click += btnPayZakat_Click;

            btnZakatHistory.Click -= btnZakatHistory_Click;
            btnZakatHistory.Click += btnZakatHistory_Click;

            btnZakatCertificate.Click -= btnZakatCertificate_Click;
            btnZakatCertificate.Click += btnZakatCertificate_Click;

            btnOpenDonation.Click -= btnOpenDonation_Click;
            btnOpenDonation.Click += btnOpenDonation_Click;

            btnDonationHistory.Click -= btnDonationHistory_Click;
            btnDonationHistory.Click += btnDonationHistory_Click;
        }
        private void Form16_Load(object sender, EventArgs e)
        {
            LoadDonorName();
        }
        private void LoadDonorName()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT FullName FROM Users WHERE Email = @Email AND LoginAs = 'Donor'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", Form1.LoggedInEmail);

                    try
                    {
                        con.Open();

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            lbltitle.Text = "Welcome, " + result.ToString();
                        }
                        else
                        {
                            lbltitle.Text = "Welcome, Donor";
                        }
                    }
                    catch
                    {
                        lbltitle.Text = "Welcome, Donor";
                    }
                }
            }
        }

        private void btnNishabCalculator_Click(object sender, EventArgs e)
        {
            Form17 nisab = new Form17();
            nisab.Show();
        }

        private void btnZakatCalculator_Click(object sender, EventArgs e)
        {
            Form18 zakat = new Form18();
            zakat.Show();
        }

        private void btnHawlTracker_Click(object sender, EventArgs e)
        {
            Form19 hawl = new Form19();
            hawl.Show();
        }

        private void btnPayZakat_Click(object sender, EventArgs e)
        {
            Form20 payZakat = new Form20();
            payZakat.Show();
        }

        private void btnZakatHistory_Click(object sender, EventArgs e)
        {
            Form21 history = new Form21();
            history.Show();
        }

        private void btnZakatCertificate_Click(object sender, EventArgs e)
        {
            Form22 certificate = new Form22();
            certificate.Show();
        }

        private void btnOpenDonation_Click(object sender, EventArgs e)
        {
            Form23 openDonation = new Form23();
            openDonation.Show();
        }
         private void btnDonationHistory_Click(object sender, EventArgs e)
        {
            Form24 donationHistory = new Form24();
            donationHistory.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1.LoggedInEmail = "";
            Form1.LoggedInRole = "";

            Form1 login = new Form1();
            login.Show();

            this.Close();
        }

    }
}
