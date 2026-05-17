using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zakat_And_Charity_Management
{
    public partial class Form17 : Form
    {
        decimal goldPricePerGram = 8000;
        decimal silverPricePerGram = 120;

        decimal goldNisabValue;
        decimal silverNisabValue;
        public Form17()
        {
            InitializeComponent();

            lblNISABCALCULATOR.Text = "Nisab Calculator";

            lblGoldPrice.Text = "Gold price per gram:";
            lblGoldValue.Text = "৳0.00";

            lblSilverPrice.Text = "Silver price per gram:";
            lblSilverValue.Text = "৳0.00";

            lblNisabGold.Text = "Nisab (85g gold):";
            lblNisabSilverValue.Text = "৳0.00";

            lblNisab.Text = "Nisab (595g silver):";
            lblNisabSilverValue.Text = "৳0.00";

            lblAssets.Text = "Enter your total assets (৳):";
            btnCheck.Text = "Check Nisab";
            lblResult.Text = "";

            goldNisabValue = goldPricePerGram * 85;
            silverNisabValue = silverPricePerGram * 595;

            lblGoldValue.Text = "৳" + goldPricePerGram.ToString("0.00");
            lblSilverValue.Text = "৳" + silverPricePerGram.ToString("0.00");

            lblNisabSilverValue.Text = "৳" + goldNisabValue.ToString("0.00");
            lblNisabSilverValue.Text = "৳" + silverNisabValue.ToString("0.00");

            btnCheck.Click -= btnCheck_Click;
            btnCheck.Click += btnCheck_Click;
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            decimal assets;

            if (!decimal.TryParse(txtAssets.Text.Trim(), out assets))
            {
                MessageBox.Show("Please enter valid asset amount.");
                txtAssets.Focus();
                return;
            }

            decimal nisabLimit = silverNisabValue;

            if (assets >= nisabLimit)
            {
                lblResult.Text = "Nisab MET - Zakat is obligatory";
            }
            else
            {
                lblResult.Text = "Nisab NOT met - Zakat is not obligatory";
            }
        }
    }
}