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
    public partial class Form12 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form12()
        {
            InitializeComponent();
            btnRefresh.Text = "Refresh";
            lblEligible.Text = "Eligible Beneficiaries";
            lblTotalAmount.Text = "Total Amount:";
            btnClearSelection.Text = "Clear Selection";
            btnDistributeSelected.Text = "Distribute\nSelected";

            dataGridView.MultiSelect = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.Load -= Form12_Load;
            this.Load += Form12_Load;

            btnRefresh.Click -= btnRefresh_Click;
            btnRefresh.Click += btnRefresh_Click;

            btnClearSelection.Click -= btnClearSelection_Click;
            btnClearSelection.Click += btnClearSelection_Click;

            btnDistributeSelected.Click -= btnDistributeSelected_Click;
            btnDistributeSelected.Click += btnDistributeSelected_Click;
        }
        private void Form12_Load(object sender, EventArgs e)
        {
            LoadSummary();
            LoadEligibleBeneficiaries();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSummary();
            LoadEligibleBeneficiaries();
        }
        private void LoadSummary()
        {
            decimal totalCollected = GetAmount("SELECT ISNULL(SUM(Amount), 0) FROM Donations");
            int eligibleCount = GetCount("SELECT COUNT(*) FROM Users WHERE LoginAs = 'Beneficiary' AND Verified = 'Yes' AND Eligible = 'Yes'");
            decimal totalDistributed = GetAmount("SELECT ISNULL(SUM(Amount), 0) FROM Distributions");
            decimal remainingAmount = totalCollected - totalDistributed;

            SetPanelText(pnlTotalVerifiedPayments, "Total Collected", totalCollected.ToString("0.00"));
            SetPanelText(pnlTotalEligibleBeneficiaries, "Eligible Beneficiaries", eligibleCount.ToString());
            SetPanelText(pnlTotalDistributed, "Total Distributed", totalDistributed.ToString("0.00"));
            SetPanelText(pnlRemainingAmount, "Remaining Amount", remainingAmount.ToString("0.00"));
        }

        private void SetPanelText(Panel panel, string title, string value)
        {
            panel.Controls.Clear();

            Label lbl = new Label();
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font("Arial", 10, FontStyle.Bold);
            lbl.Text = title + "\n" + value;

            panel.Controls.Add(lbl);
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

        private decimal GetAmount(string query)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
            catch
            {
                return 0;
            }
        }

        private void LoadEligibleBeneficiaries()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT 
                                    UserID,
                                    FullName,
                                    Email,
                                    Phone,
                                    Category,
                                    Address,
                                    MonthlyIncome,
                                    FamilyMembers,
                                    NID,
                                    Verified,
                                    Eligible
                                 FROM Users
                                 WHERE LoginAs = 'Beneficiary'
                                 AND Verified = 'Yes'
                                 AND Eligible = 'Yes'
                                 ORDER BY UserID DESC";

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
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
            txtTotalAmount.Clear();
        }

        private void btnDistributeSelected_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one beneficiary.");
                return;
            }

            decimal totalAmount;

            if (!decimal.TryParse(txtTotalAmount.Text.Trim(), out totalAmount))
            {
                MessageBox.Show("Please enter valid total amount.");
                return;
            }

            if (totalAmount <= 0)
            {
                MessageBox.Show("Amount must be greater than 0.");
                return;
            }

            decimal remainingAmount = GetAmount("SELECT ISNULL(SUM(Amount), 0) FROM Donations")
                                    - GetAmount("SELECT ISNULL(SUM(Amount), 0) FROM Distributions");

            if (totalAmount > remainingAmount)
            {
                MessageBox.Show("Not enough remaining amount to distribute.");
                return;
            }

            decimal amountPerBeneficiary = totalAmount / dataGridView.SelectedRows.Count;

            DialogResult result = MessageBox.Show(
                "Distribute " + totalAmount.ToString("0.00") + " among " + dataGridView.SelectedRows.Count + " beneficiaries?",
                "Confirm Distribution",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        string email = row.Cells["Email"].Value.ToString();

                        string query = @"INSERT INTO Distributions
                                         (BeneficiaryEmail, Amount, DistributionDate, Notes)
                                         VALUES
                                         (@BeneficiaryEmail, @Amount, GETDATE(), @Notes)";

                        using (SqlCommand cmd = new SqlCommand(query, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@BeneficiaryEmail", email);
                            cmd.Parameters.AddWithValue("@Amount", amountPerBeneficiary);
                            cmd.Parameters.AddWithValue("@Notes", "Distributed from admin dashboard");

                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();

                    MessageBox.Show("Distribution completed successfully.");

                    txtTotalAmount.Clear();
                    LoadSummary();
                    LoadEligibleBeneficiaries();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Database error:\n" + ex.Message);
                }
            }
        }











    }
}
