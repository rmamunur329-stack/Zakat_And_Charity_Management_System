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
using System.Drawing.Printing;
using System.IO;

namespace Zakat_And_Charity_Management
{
    public partial class Form22 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        string certificateText = "";
        int selectedDonationId = 0;
        public Form22()
        {
            InitializeComponent();

            lblTitle.Text = "Zakat Certificates";
            lblPayment.Text = "Your Verified Payments:";
            lblDonorName.Text = "Donor Name:";
            lblAmount.Text = "Amount (BDT):";
            lblIssuedAt.Text = "Issued At:";
            lblCertificateNo.Text = "Certificate No:";

            txtDonorName.ReadOnly = true;
            txtAmount.ReadOnly = true;
            txtIssuedAt.ReadOnly = true;
            txtCertificateNo.ReadOnly = true;

            btnViewCertificate.Text = "View Certificate";
            btnPrint.Text = "Print";
            btnExportPDF.Text = "Export";
            btnBack.Text = "Back";

            this.Load -= Form22_Load;
            this.Load += Form22_Load;

            dgvVerifiedPayments.CellClick -= dgvVerifiedPayments_CellClick;
            dgvVerifiedPayments.CellClick += dgvVerifiedPayments_CellClick;

            btnViewCertificate.Click -= btnViewCertificate_Click;
            btnViewCertificate.Click += btnViewCertificate_Click;

            btnPrint.Click -= btnPrint_Click;
            btnPrint.Click += btnPrint_Click;

            btnExportPDF.Click -= btnExportPDF_Click;
            btnExportPDF.Click += btnExportPDF_Click;

            btnBack.Click -= btnBack_Click;
            btnBack.Click += btnBack_Click;


        }
        private void Form22_Load(object sender, EventArgs e)
        {
            LoadVerifiedPayments();
        }

        private void LoadVerifiedPayments()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT DonationID, DonorEmail, Amount, DonationDate
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

                        dgvVerifiedPayments.DataSource = dt;
                        dgvVerifiedPayments.ReadOnly = true;
                        dgvVerifiedPayments.AllowUserToAddRows = false;
                        dgvVerifiedPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvVerifiedPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }

        private void dgvVerifiedPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            selectedDonationId = Convert.ToInt32(dgvVerifiedPayments.Rows[e.RowIndex].Cells["DonationID"].Value);
            txtAmount.Text = Convert.ToDecimal(dgvVerifiedPayments.Rows[e.RowIndex].Cells["Amount"].Value).ToString("0.00");
            txtIssuedAt.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            txtCertificateNo.Text = GenerateCertificateNo();

            LoadDonorName();
        }

        private void LoadDonorName()
        {
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

                        txtDonorName.Text = result == null ? "" : result.ToString();
                    }
                    catch
                    {
                        txtDonorName.Text = "";
                    }
                }
            }
        }

        private string GenerateCertificateNo()
        {
            Random random = new Random();

            string year = DateTime.Now.ToString("yy");
            string middle = random.Next(100000, 999999).ToString();
            string last = random.Next(10, 99).ToString();

            return year + "-" + middle + "-" + last;
        }

        private void btnViewCertificate_Click(object sender, EventArgs e)
        {
            if (selectedDonationId == 0)
            {
                MessageBox.Show("Please select a payment first.");
                return;
            }

            certificateText =
                "ZAKAT CERTIFICATE\n\n" +
                "Certificate No: " + txtCertificateNo.Text + "\n" +
                "Donor Name: " + txtDonorName.Text + "\n" +
                "Donor Email: " + Form1.LoggedInEmail + "\n" +
                "Amount: BDT " + txtAmount.Text + "\n" +
                "Issued At: " + txtIssuedAt.Text + "\n\n" +
                "This certificate confirms that the donor has paid Zakat through the system.";

            dgvCertificates.Rows.Clear();
            dgvCertificates.Columns.Clear();

            dgvCertificates.Columns.Add("Certificate", "Generated Certificate");
            dgvCertificates.Rows.Add(certificateText);

            SaveCertificate();
        }

        private void SaveCertificate()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"INSERT INTO ZakatCertificates
                                 (CertificateNo, DonorEmail, DonorName, Amount, IssuedAt, DonationID)
                                 VALUES
                                 (@CertificateNo, @DonorEmail, @DonorName, @Amount, @IssuedAt, @DonationID)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CertificateNo", txtCertificateNo.Text);
                    cmd.Parameters.AddWithValue("@DonorEmail", Form1.LoggedInEmail);
                    cmd.Parameters.AddWithValue("@DonorName", txtDonorName.Text);
                    cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtAmount.Text));
                    cmd.Parameters.AddWithValue("@IssuedAt", DateTime.Now);
                    cmd.Parameters.AddWithValue("@DonationID", selectedDonationId);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Certificate generated successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (certificateText == "")
            {
                MessageBox.Show("Please view certificate first.");
                return;
            }

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPage;

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(certificateText, new Font("Arial", 14), Brushes.Black, 80, 80);
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (certificateText == "")
            {
                MessageBox.Show("Please view certificate first.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File|*.txt";
            save.FileName = "ZakatCertificate_" + txtCertificateNo.Text + ".txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, certificateText);
                MessageBox.Show("Certificate exported successfully.");
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
