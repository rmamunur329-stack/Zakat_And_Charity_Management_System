using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace Zakat_And_Charity_Management
{
    public partial class Form14 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form14()
        {
            InitializeComponent();
            btnLeaderBoard.Text = "Export\nLeaderboard";

            this.Load -= Form14_Load;
            this.Load += Form14_Load;

            btnLeaderBoard.Click -= btnLeaderBoard_Click;
            btnLeaderBoard.Click += btnLeaderBoard_Click;
        }
        private void Form14_Load(object sender, EventArgs e)
        {
            LoadSummary();
            LoadLeaderboard();
        }

        private void LoadSummary()
        {
            int totalDonors = GetCount("SELECT COUNT(*) FROM Users WHERE LoginAs = 'Donor'");
            decimal totalDonation = GetAmount("SELECT ISNULL(SUM(Amount), 0) FROM Donations");
            decimal totalZakat = GetAmount("SELECT ISNULL(SUM(Amount), 0) FROM Donations WHERE DonationType = 'Zakat'");
            decimal totalCharity = GetAmount("SELECT ISNULL(SUM(Amount), 0) FROM Donations WHERE DonationType = 'Charity'");

            SetPanelText(pnlTotalDonor, "Total Donors", totalDonors.ToString());
            SetPanelText(pnlTotalDonation, "Total Donation", totalDonation.ToString("0.00"));
            SetPanelText(pnlZakat, "Total Zakat", totalZakat.ToString("0.00"));
            SetPanelText(pnlCharity, "Total Charity", totalCharity.ToString("0.00"));
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

        private void LoadLeaderboard()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT 
                                    U.FullName,
                                    U.Email,
                                    U.Phone,
                                    COUNT(D.DonationID) AS TotalPayments,
                                    ISNULL(SUM(D.Amount), 0) AS TotalDonated,
                                    ISNULL(SUM(CASE WHEN D.DonationType = 'Zakat' THEN D.Amount ELSE 0 END), 0) AS ZakatAmount,
                                    ISNULL(SUM(CASE WHEN D.DonationType = 'Charity' THEN D.Amount ELSE 0 END), 0) AS CharityAmount
                                 FROM Users U
                                 LEFT JOIN Donations D ON U.Email = D.DonorEmail
                                 WHERE U.LoginAs = 'Donor'
                                 GROUP BY U.FullName, U.Email, U.Phone
                                 ORDER BY TotalDonated DESC";

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

        private void btnLeaderBoard_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV File|*.csv";
            save.Title = "Export Leaderboard";
            save.FileName = "TopDonorLeaderboard.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        sb.Append(dataGridView1.Columns[i].HeaderText);

                        if (i < dataGridView1.Columns.Count - 1)
                        {
                            sb.Append(",");
                        }
                    }

                    sb.AppendLine();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                string value = "";

                                if (row.Cells[i].Value != null)
                                {
                                    value = row.Cells[i].Value.ToString();
                                    value = value.Replace(",", " ");
                                }

                                sb.Append(value);

                                if (i < dataGridView1.Columns.Count - 1)
                                {
                                    sb.Append(",");
                                }
                            }

                            sb.AppendLine();
                        }
                    }

                    File.WriteAllText(save.FileName, sb.ToString());

                    MessageBox.Show("Leaderboard exported successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export error:\n" + ex.Message);
                }
            }
        }
    }
}
