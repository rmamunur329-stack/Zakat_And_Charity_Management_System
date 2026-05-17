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
using System.IO;
using System.Drawing.Printing;

namespace Zakat_And_Charity_Management
{
    public partial class Form15 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        string printText = "";

        public Form15()
        {
            InitializeComponent();
            lblFromDate.Text = "From Date:";
            lblToDate.Text = "To Date:";
            lblStartDate.Text = "Start Date:";
            lblEndDate.Text = "End Date:";
            lblCampaign.Text = "Campaign Report";
            lblAuditLog.Text = "Audit Log";

            btnGenerateReport.Text = "Generate Report";
            btnGenerateSummary.Text = "Generate Summary";
            btnSearch.Text = "Search";
            btnReset.Text = "Reset";
            btnExporttoExcel.Text = "Export to Excel";
            btnPrintReport.Text = "Print Report";

            this.Load += Form15_Load;

            btnGenerateReport.Click += btnGenerateReport_Click;
            btnGenerateSummary.Click += btnGenerateSummary_Click;
            btnSearch.Click += btnSearch_Click;
            btnReset.Click += btnReset_Click;
            btnExporttoExcel.Click += btnExporttoExcel_Click;
            btnPrintReport.Click += btnPrintReport_Click;
        }
        private void Form15_Load(object sender, EventArgs e)
        {
            LoadDistributionReport();
            LoadDonationSummary();
            LoadCampaignReport();
            LoadAuditLog();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            LoadDistributionReport();
        }

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            LoadDonationSummary();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAuditLog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadAuditLog();
        }

        private void LoadDistributionReport()
        {
            DateTime fromDate = dateTimePickerFromDate.Value.Date;
            DateTime toDate = dateTimePickerToDate.Value.Date.AddDays(1).AddSeconds(-1);

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT DistributionID, BeneficiaryEmail, Amount, DistributionDate, Notes
                                 FROM Distributions
                                 WHERE DistributionDate BETWEEN @FromDate AND @ToDate
                                 ORDER BY DistributionDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    DataTable dt = FillTable(cmd);
                    dataGridView1.DataSource = dt;
                    FormatGrid(dataGridView1);

                    decimal total = GetDecimal("SELECT ISNULL(SUM(Amount),0) FROM Distributions WHERE DistributionDate BETWEEN @FromDate AND @ToDate", fromDate, toDate);
                    int beneficiaries = GetInt("SELECT COUNT(DISTINCT BeneficiaryEmail) FROM Distributions WHERE DistributionDate BETWEEN @FromDate AND @ToDate", fromDate, toDate);
                    decimal average = beneficiaries == 0 ? 0 : total / beneficiaries;

                    SetPanelText(pnlTotalDistributed, "Total Distributed", total.ToString("0.00"));
                    SetPanelText(pnlTotalBeneficiaries, "Beneficiaries", beneficiaries.ToString());
                    SetPanelText(pnlAveragePerBeneficiary, "Average", average.ToString("0.00"));
                }
            }
        }

        private void LoadDonationSummary()
        {
            DateTime fromDate = dateTimePickerStartDate.Value.Date;
            DateTime toDate = dateTimePickerEndDate.Value.Date.AddDays(1).AddSeconds(-1);

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT DonationID, DonorEmail, DonationType, Amount, DonationDate
                                 FROM Donations
                                 WHERE DonationDate BETWEEN @FromDate AND @ToDate
                                 ORDER BY DonationDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    DataTable dt = FillTable(cmd);
                    dataGridViewDonationSummary.DataSource = dt;
                    FormatGrid(dataGridViewDonationSummary);

                    decimal total = GetDecimal("SELECT ISNULL(SUM(Amount),0) FROM Donations WHERE DonationDate BETWEEN @FromDate AND @ToDate", fromDate, toDate);
                    int donors = GetInt("SELECT COUNT(DISTINCT DonorEmail) FROM Donations WHERE DonationDate BETWEEN @FromDate AND @ToDate", fromDate, toDate);
                    int payments = GetInt("SELECT COUNT(*) FROM Donations WHERE DonationDate BETWEEN @FromDate AND @ToDate", fromDate, toDate);
                    decimal average = payments == 0 ? 0 : total / payments;

                    SetPanelText(pnlTotalDonation, "Total Donation", total.ToString("0.00"));
                    SetPanelText(pnlTotalDonor, "Total Donor", donors.ToString());
                    SetPanelText(pnlAveragePerDonation, "Average Donation", average.ToString("0.00"));
                }
            }
        }

        private void LoadCampaignReport()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT CampaignID, CampaignName, TargetAmount, CollectedAmount, Status, StartDate, EndDate
                                 FROM Campaigns
                                 ORDER BY CampaignID DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    DataTable dt = FillTable(cmd);
                    dataGridViewCampaign.DataSource = dt;
                    FormatGrid(dataGridViewCampaign);

                    SetPanelText(pnlTotalCampaign, "Total Campaigns", GetSimpleInt("SELECT COUNT(*) FROM Campaigns").ToString());
                    SetPanelText(pnlTotalAmount, "Campaign Amount", GetSimpleDecimal("SELECT ISNULL(SUM(CollectedAmount),0) FROM Campaigns").ToString("0.00"));
                }
            }
        }

        private void LoadAuditLog()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT LogID, ActionType, Description, UserEmail, Severity, LogDate
                                 FROM AuditLogs
                                 ORDER BY LogDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    DataTable dt = FillTable(cmd);
                    dataGridViewAuditLog.DataSource = dt;
                    FormatGrid(dataGridViewAuditLog);

                    SetPanelText(pnlAdminAction, "Admin Actions", GetSimpleInt("SELECT COUNT(*) FROM AuditLogs WHERE ActionType LIKE '%Admin%'").ToString());
                    SetPanelText(pnlTotalLogs, "Total Logs", GetSimpleInt("SELECT COUNT(*) FROM AuditLogs").ToString());
                    SetPanelText(pnlCriticalEvents, "Critical Events", GetSimpleInt("SELECT COUNT(*) FROM AuditLogs WHERE Severity='Critical'").ToString());
                }
            }
        }

        private DataTable FillTable(SqlCommand cmd)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message);
            }

            return dt;
        }

        private void FormatGrid(DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private decimal GetDecimal(string query, DateTime fromDate, DateTime toDate)
        {
            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@FromDate", fromDate);
                cmd.Parameters.AddWithValue("@ToDate", toDate);
                con.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        private int GetInt(string query, DateTime fromDate, DateTime toDate)
        {
            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@FromDate", fromDate);
                cmd.Parameters.AddWithValue("@ToDate", toDate);
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private decimal GetSimpleDecimal(string query)
        {
            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        private int GetSimpleInt(string query)
        {
            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private DataGridView CurrentGrid()
        {
            if (tabAnalysis.SelectedTab == tabDistributionReport)
            {
                return dataGridView1;
            }

            if (tabAnalysis.SelectedTab == tabDonationSummary)
            {
                return dataGridViewDonationSummary;
            }

            if (tabAnalysis.SelectedTab == tabCampaignReport)
            {
                return dataGridViewCampaign;
            }

            if (tabAnalysis.SelectedTab == tabAuditLog)
            {
                return dataGridViewAuditLog;
            }

            return dataGridView1;
        }

        private void btnExporttoExcel_Click(object sender, EventArgs e)
        {
            DataGridView grid = CurrentGrid();

            if (grid.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV File|*.csv";
            save.FileName = "Report.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < grid.Columns.Count; i++)
                {
                    sb.Append(grid.Columns[i].HeaderText);
                    if (i < grid.Columns.Count - 1) sb.Append(",");
                }

                sb.AppendLine();

                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < grid.Columns.Count; i++)
                        {
                            string value = row.Cells[i].Value == null ? "" : row.Cells[i].Value.ToString().Replace(",", " ");
                            sb.Append(value);
                            if (i < grid.Columns.Count - 1) sb.Append(",");
                        }

                        sb.AppendLine();
                    }
                }

                File.WriteAllText(save.FileName, sb.ToString());
                MessageBox.Show("Export successful.");
            }
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            DataGridView grid = CurrentGrid();

            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewColumn col in grid.Columns)
            {
                sb.Append(col.HeaderText + "\t");
            }

            sb.AppendLine();

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        sb.Append((cell.Value == null ? "" : cell.Value.ToString()) + "\t");
                    }

                    sb.AppendLine();
                }
            }

            printText = sb.ToString();

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPage;

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printText, new Font("Arial", 10), Brushes.Black, 50, 50);
        }
    }
}
