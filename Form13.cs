using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Zakat_And_Charity_Management
{
    public partial class Form13 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form13()
        {
            InitializeComponent();
            lblCategory.Text = "Category:";
            lblEligibility.Text = "Eligibility:";
            lblVerification.Text = "Verification:";

            btnSearch.Text = "Search";
            btnReset.Text = "Reset";
            btnExporttoExcel.Text = "Export to\nExcel";

            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All Category");
            cmbCategory.Items.Add("Widow");
            cmbCategory.Items.Add("Orphan");
            cmbCategory.Items.Add("Poor Family");
            cmbCategory.Items.Add("Disable Person");
            cmbCategory.Items.Add("Elderly");
            cmbCategory.SelectedIndex = 0;

            cmbEligibility.Items.Clear();
            cmbEligibility.Items.Add("All");
            cmbEligibility.Items.Add("Eligible");
            cmbEligibility.Items.Add("Not Eligible");
            cmbEligibility.SelectedIndex = 0;

            cmbVerification.Items.Clear();
            cmbVerification.Items.Add("All");
            cmbVerification.Items.Add("Verified");
            cmbVerification.Items.Add("Not Verified");
            cmbVerification.SelectedIndex = 0;

            this.Load -= Form13_Load;
            this.Load += Form13_Load;

            btnSearch.Click -= btnSearch_Click;
            btnSearch.Click += btnSearch_Click;

            btnReset.Click -= btnReset_Click;
            btnReset.Click += btnReset_Click;

            btnExporttoExcel.Click -= btnExporttoExcel_Click;
            btnExporttoExcel.Click += btnExporttoExcel_Click;
        }
        private void Form13_Load(object sender, EventArgs e)
        {
            LoadBeneficiaries();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadBeneficiaries();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbCategory.SelectedIndex = 0;
            cmbEligibility.SelectedIndex = 0;
            cmbVerification.SelectedIndex = 0;

            LoadBeneficiaries();
        }

        private void LoadBeneficiaries()
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
                                 WHERE LoginAs = 'Beneficiary'";

                if (cmbCategory.Text != "All Category")
                {
                    query += " AND Category = @Category";
                }

                if (cmbEligibility.Text == "Eligible")
                {
                    query += " AND Eligible = 'Yes'";
                }
                else if (cmbEligibility.Text == "Not Eligible")
                {
                    query += " AND Eligible = 'No'";
                }

                if (cmbVerification.Text == "Verified")
                {
                    query += " AND Verified = 'Yes'";
                }
                else if (cmbVerification.Text == "Not Verified")
                {
                    query += " AND Verified = 'No'";
                }

                query += " ORDER BY UserID DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (cmbCategory.Text != "All Category")
                    {
                        cmd.Parameters.AddWithValue("@Category", cmbCategory.Text);
                    }

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

        private void btnExporttoExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV File|*.csv";
            save.Title = "Export to Excel";
            save.FileName = "EligibleBeneficiaries.csv";

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

                    MessageBox.Show("Export successful. You can open the file in Excel.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export error:\n" + ex.Message);
                }
            }
        }
    }
}
