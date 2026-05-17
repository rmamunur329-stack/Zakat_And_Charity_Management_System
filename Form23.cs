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
    public partial class Form23 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form23()
        {
            InitializeComponent();

            lblTitle.Text = "OPEN DONATION";
            lblAmount.Text = "Amount (৳):";
            lblPaymentMethod.Text = "Payment Method:";
            lblTransactionNo.Text = "Transaction No:";
            lblNote.Text = "Note (Optional):";

            btnDonateNow.Text = "DONATE\nNOW";
            btnReset.Text = "RESET";
            btnBack.Text = "Back";

            cmbPaymentMethod.Items.Clear();
            cmbPaymentMethod.Items.Add("Bikash");
            cmbPaymentMethod.Items.Add("Nogod");
            cmbPaymentMethod.Items.Add("Rocket");
            cmbPaymentMethod.Items.Add("Upay");
            cmbPaymentMethod.Items.Add("DebitCard");
            cmbPaymentMethod.SelectedIndex = 0;

            btnDonateNow.Click -= btnDonateNow_Click;
            btnDonateNow.Click += btnDonateNow_Click;

            btnReset.Click -= btnReset_Click;
            btnReset.Click += btnReset_Click;

            btnBack.Click -= btnBack_Click;
            btnBack.Click += btnBack_Click;
        }
        private void btnDonateNow_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (Form1.LoggedInEmail == "")
            {
                MessageBox.Show("Please login first.");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text.Trim(), out amount))
            {
                MessageBox.Show("Please enter valid amount.");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Amount must be greater than 0.");
                return;
            }

            if (cmbPaymentMethod.Text == "")
            {
                MessageBox.Show("Please select payment method.");
                return;
            }

            if (txtTransactionNo.Text.Trim() == "")
            {
                MessageBox.Show("Please enter transaction number.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"INSERT INTO Donations
                                 (DonorEmail, DonationType, Amount, DonationDate, PaymentMethod, TransactionNo, Note)
                                 VALUES
                                 (@DonorEmail, 'Charity', @Amount, GETDATE(), @PaymentMethod, @TransactionNo, @Note)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DonorEmail", Form1.LoggedInEmail);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.Text);
                    cmd.Parameters.AddWithValue("@TransactionNo", txtTransactionNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@Note", txtNote.Text.Trim());

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Donation successful. Thank you.");

                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtAmount.Clear();
            txtTransactionNo.Clear();
            txtNote.Clear();

            if (cmbPaymentMethod.Items.Count > 0)
            {
                cmbPaymentMethod.SelectedIndex = 0;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNote_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {

        }
    }
}
