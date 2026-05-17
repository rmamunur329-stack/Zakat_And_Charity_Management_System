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
    public partial class Form18 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        decimal nisabValue = 680000;
        decimal totalAssets = 0;
        decimal zakatAmount = 0;
        string nisabMet = "No";
        public Form18()
        {
            InitializeComponent();
            lblTitle.Text = "Zakat Calculator (2.5%)";

            lblCash.Text = "Cash_Bank Balance (৳):";
            lblGold.Text = "Gold Value (৳):";
            lblSilver.Text = "Silver Value (৳):";
            lblBusiness.Text = "Business Assets (৳):";
            lblInvestment.Text = "Investments (৳):";

            lblTotalAssetsTitle.Text = "Total Assets (৳)";
            lblNisabTitle.Text = "Nisab Value (Gold)";
            lblNisabMetTitle.Text = "Nisab Met";
            lblZakatTitle.Text = "Zakat Amount (2.5%)";

            lblTotalAssetsValue.Text = "৳ 0.00";
            lblNisabValue.Text = "৳ " + nisabValue.ToString("0.00");
            lblNisabMetValue.Text = "-";
            lblZakatAmount.Text = "৳ 0.00";

            btnCalculate.Text = "Calculate\nZakat";
            btnSave.Text = "Save\nProceed to";
            btnClear.Text = "Clear";

            btnCalculate.Click -= btnCalculate_Click;
            btnCalculate.Click += btnCalculate_Click;

            btnSave.Click -= btnSave_Click;
            btnSave.Click += btnSave_Click;

            btnClear.Click -= btnClear_Click;
            btnClear.Click += btnClear_Click;
        }
        private decimal GetValue(TextBox txt)
        {
            decimal value;

            if (txt.Text.Trim() == "")
            {
                return 0;
            }

            if (!decimal.TryParse(txt.Text.Trim(), out value))
            {
                MessageBox.Show("Please enter valid number only.");
                txt.Focus();
                return -1;
            }

            return value;
        }
        private bool CalculateZakat()
        {
            decimal cash = GetValue(txtCash);
            if (cash < 0) return false;

            decimal gold = GetValue(txtGold);
            if (gold < 0) return false;

            decimal silver = GetValue(txtSilver);
            if (silver < 0) return false;

            decimal business = GetValue(txtBusiness);
            if (business < 0) return false;

            decimal investment = GetValue(txtInvestment);
            if (investment < 0) return false;

            totalAssets = cash + gold + silver + business + investment;

            if (totalAssets >= nisabValue)
            {
                nisabMet = "Yes";
                zakatAmount = totalAssets * 0.025m;
            }
            else
            {
                nisabMet = "No";
                zakatAmount = 0;
            }

            lblTotalAssetsValue.Text = "৳ " + totalAssets.ToString("0.00");
            lblNisabValue.Text = "৳ " + nisabValue.ToString("0.00");
            lblNisabMetValue.Text = nisabMet;
            lblZakatAmount.Text = "৳ " + zakatAmount.ToString("0.00");

            return true;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateZakat();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CalculateZakat())
            {
                return;
            }

            if (Form1.LoggedInEmail == "")
            {
                MessageBox.Show("Please login first.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"INSERT INTO ZakatCalculations
                                 (DonorEmail, CashAmount, GoldValue, SilverValue, BusinessAssets,
                                  InvestmentAmount, TotalAssets, NisabValue, NisabMet, ZakatAmount)
                                 VALUES
                                 (@DonorEmail, @CashAmount, @GoldValue, @SilverValue, @BusinessAssets,
                                  @InvestmentAmount, @TotalAssets, @NisabValue, @NisabMet, @ZakatAmount)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DonorEmail", Form1.LoggedInEmail);
                    cmd.Parameters.AddWithValue("@CashAmount", GetValue(txtCash));
                    cmd.Parameters.AddWithValue("@GoldValue", GetValue(txtGold));
                    cmd.Parameters.AddWithValue("@SilverValue", GetValue(txtSilver));
                    cmd.Parameters.AddWithValue("@BusinessAssets", GetValue(txtBusiness));
                    cmd.Parameters.AddWithValue("@InvestmentAmount", GetValue(txtInvestment));
                    cmd.Parameters.AddWithValue("@TotalAssets", totalAssets);
                    cmd.Parameters.AddWithValue("@NisabValue", nisabValue);
                    cmd.Parameters.AddWithValue("@NisabMet", nisabMet);
                    cmd.Parameters.AddWithValue("@ZakatAmount", zakatAmount);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Zakat calculation saved successfully.");
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
            txtCash.Clear();
            txtGold.Clear();
            txtSilver.Clear();
            txtBusiness.Clear();
            txtInvestment.Clear();

            totalAssets = 0;
            zakatAmount = 0;
            nisabMet = "No";

            lblTotalAssetsValue.Text = "৳ 0.00";
            lblNisabValue.Text = "৳ " + nisabValue.ToString("0.00");
            lblNisabMetValue.Text = "-";
            lblZakatAmount.Text = "৳ 0.00";
        }

        private void Form18_Load(object sender, EventArgs e)
        {

        }
    }
}
