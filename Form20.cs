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
    public partial class Form20 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form20()
        {
            InitializeComponent();
            lblTitle.Text = "Pay Zakat";
            lblCalculations.Text = "Your Calculations:";
            lblAmount.Text = "Amount (৳):";
            lblPaymentMethod.Text = "Payment Method:";
            lblPaymentYear.Text = "Payment Year:";
            lblStatus.Text = "Awaiting payment:";

            txtAwaitingPayment.ReadOnly = true;
            txtAwaitingPayment.Text = "Pending";

            btnPayNow.Text = "Pay Now";
            btnClear.Text = "Clear";
            btnBack.Text = "Back";

            cmbMethod.Items.Clear();
            cmbMethod.Items.Add("Bikash");
            cmbMethod.Items.Add("Nogod");
            cmbMethod.Items.Add("Rocket");
            cmbMethod.Items.Add("Upay");
            cmbMethod.Items.Add("DebitCard");
            cmbMethod.SelectedIndex = 0;

            cmbPaymentYear.Items.Clear();
            for (int year = 2000; year <= 2030; year++)
            {
                cmbPaymentYear.Items.Add(year.ToString());
            }
            cmbPaymentYear.Text = DateTime.Now.Year.ToString();

            this.Load -= Form20_Load;
            this.Load += Form20_Load;

            cmbYourCalculation.SelectedIndexChanged -= cmbYourCalculation_SelectedIndexChanged;
            cmbYourCalculation.SelectedIndexChanged += cmbYourCalculation_SelectedIndexChanged;

            btnPayNow.Click -= btnPayNow_Click;
            btnPayNow.Click += btnPayNow_Click;

            btnClear.Click -= btnClear_Click;
            btnClear.Click += btnClear_Click;

            btnBack.Click -= btnBack_Click;
            btnBack.Click += btnBack_Click;
        }
        private void Form20_Load(object sender, EventArgs e)
        {
            LoadCalculations();
        }

        private void LoadCalculations()
        {
            cmbYourCalculation.Items.Clear();

            if (Form1.LoggedInEmail == "")
            {
                MessageBox.Show("Please login first.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT CalculationID, ZakatAmount
                                 FROM ZakatCalculations
                                 WHERE DonorEmail = @DonorEmail
                                 AND ZakatAmount > 0
                                 ORDER BY CalculationDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DonorEmail", Form1.LoggedInEmail);

                    try
                    {
                        con.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string item = dr["CalculationID"].ToString()
                                    + " - Zakat: ৳"
                                    + Convert.ToDecimal(dr["ZakatAmount"]).ToString("0.00");

                                cmbYourCalculation.Items.Add(item);
                            }
                        }

                        if (cmbYourCalculation.Items.Count > 0)
                        {
                            cmbYourCalculation.SelectedIndex = 0;
                        }
                        else
                        {
                            cmbYourCalculation.Items.Add("No saved zakat calculation found");
                            cmbYourCalculation.SelectedIndex = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }

        private void cmbYourCalculation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbYourCalculation.Text;

            if (selected.Contains("৳"))
            {
                string amountText = selected.Substring(selected.IndexOf("৳") + 1);
                txtAmount.Text = amountText.Trim();
            }
            else
            {
                txtAmount.Clear();
            }
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            decimal amount;

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

            if (cmbMethod.Text == "")
            {
                MessageBox.Show("Please select payment method.");
                return;
            }

            if (cmbPaymentYear.Text == "")
            {
                MessageBox.Show("Please select payment year.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"INSERT INTO Donations
                                 (DonorEmail, DonationType, Amount, DonationDate)
                                 VALUES
                                 (@DonorEmail, 'Zakat', @Amount, GETDATE())";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DonorEmail", Form1.LoggedInEmail);
                    cmd.Parameters.AddWithValue("@Amount", amount);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        txtAwaitingPayment.Text = "Paid";

                        MessageBox.Show("Zakat payment successful.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            txtAwaitingPayment.Text = "Pending";

            if (cmbMethod.Items.Count > 0)
            {
                cmbMethod.SelectedIndex = 0;
            }

            cmbPaymentYear.Text = DateTime.Now.Year.ToString();

            if (cmbYourCalculation.Items.Count > 0)
            {
                cmbYourCalculation.SelectedIndex = 0;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
