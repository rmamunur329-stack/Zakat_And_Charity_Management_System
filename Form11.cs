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
    public partial class Form11 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        int selectedCampaignId = 0;

        public Form11()
        {
            InitializeComponent();
            lblManageCampaigns.Text = "Manage Campaigns";
            btnNewCampaigns.Text = "Add New\nCampaign";
            btnRefresh.Text = "Refresh";

            lblCampaignName.Text = "Campaign Name:";
            lblTargetAmount.Text = "Target Amount:";
            lblDescription.Text = "Description:";
            lblCollectedAmount.Text = "Collected Amount:";
            lblStartDate.Text = "Start Date:";
            lblEndDate.Text = "End Date:";
            chkActive.Text = "Active";

            btnEditCampaigns.Text = "Edit Campaign";
            btnDeleteCampaign.Text = "Delete Campaign";

            this.Load -= Form11_Load;
            this.Load += Form11_Load;

            btnNewCampaigns.Click -= btnNewCampaigns_Click;
            btnNewCampaigns.Click += btnNewCampaigns_Click;

            btnRefresh.Click -= btnRefresh_Click;
            btnRefresh.Click += btnRefresh_Click;

            btnEditCampaigns.Click -= btnEditCampaigns_Click;
            btnEditCampaigns.Click += btnEditCampaigns_Click;

            btnDeleteCampaign.Click -= btnDeleteCampaign_Click;
            btnDeleteCampaign.Click += btnDeleteCampaign_Click;

            dataGridView1.CellClick -= dataGridView1_CellClick;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        private void Form11_Load(object sender, EventArgs e)
        {
            LoadCampaigns();
            ClearFields();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCampaigns();
        }
        private void LoadCampaigns()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT 
                                    CampaignID,
                                    CampaignName,
                                    Description,
                                    TargetAmount,
                                    CollectedAmount,
                                    Status,
                                    StartDate,
                                    EndDate
                                 FROM Campaigns
                                 ORDER BY CampaignID DESC";

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

        private void btnNewCampaigns_Click(object sender, EventArgs e)
        {
            string campaignName = txtCampaignName.Text.Trim();
            string description = txtDescription.Text.Trim();
            decimal targetAmount;
            decimal collectedAmount;

            if (campaignName == "")
            {
                MessageBox.Show("Please enter campaign name.");
                return;
            }

            if (!decimal.TryParse(txtTargetAmount.Text.Trim(), out targetAmount))
            {
                MessageBox.Show("Please enter valid target amount.");
                return;
            }

            if (!decimal.TryParse(txtCollectedAmount.Text.Trim(), out collectedAmount))
            {
                collectedAmount = 0;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"INSERT INTO Campaigns
                                 (CampaignName, Description, TargetAmount, CollectedAmount, Status, StartDate, EndDate)
                                 VALUES
                                 (@CampaignName, @Description, @TargetAmount, @CollectedAmount, @Status, @StartDate, @EndDate)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CampaignName", campaignName);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@TargetAmount", targetAmount);
                    cmd.Parameters.AddWithValue("@CollectedAmount", collectedAmount);
                    cmd.Parameters.AddWithValue("@Status", chkActive.Checked ? "Active" : "Inactive");
                    cmd.Parameters.AddWithValue("@StartDate", dateTimePickerStartDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", dateTimePickerEndDate.Value);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Campaign added successfully.");
                        LoadCampaigns();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            selectedCampaignId = Convert.ToInt32(row.Cells["CampaignID"].Value);
            txtCampaignName.Text = row.Cells["CampaignName"].Value.ToString();
            txtDescription.Text = row.Cells["Description"].Value.ToString();
            txtTargetAmount.Text = row.Cells["TargetAmount"].Value.ToString();
            txtCollectedAmount.Text = row.Cells["CollectedAmount"].Value.ToString();

            chkActive.Checked = row.Cells["Status"].Value.ToString() == "Active";

            if (row.Cells["StartDate"].Value != DBNull.Value)
            {
                dateTimePickerStartDate.Value = Convert.ToDateTime(row.Cells["StartDate"].Value);
            }

            if (row.Cells["EndDate"].Value != DBNull.Value)
            {
                dateTimePickerEndDate.Value = Convert.ToDateTime(row.Cells["EndDate"].Value);
            }
        }
        private void btnEditCampaigns_Click(object sender, EventArgs e)
        {
            if (selectedCampaignId == 0)
            {
                MessageBox.Show("Please select a campaign first.");
                return;
            }

            string campaignName = txtCampaignName.Text.Trim();
            string description = txtDescription.Text.Trim();
            decimal targetAmount;
            decimal collectedAmount;

            if (campaignName == "")
            {
                MessageBox.Show("Please enter campaign name.");
                return;
            }

            if (!decimal.TryParse(txtTargetAmount.Text.Trim(), out targetAmount))
            {
                MessageBox.Show("Please enter valid target amount.");
                return;
            }

            if (!decimal.TryParse(txtCollectedAmount.Text.Trim(), out collectedAmount))
            {
                MessageBox.Show("Please enter valid collected amount.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"UPDATE Campaigns SET
                                    CampaignName = @CampaignName,
                                    Description = @Description,
                                    TargetAmount = @TargetAmount,
                                    CollectedAmount = @CollectedAmount,
                                    Status = @Status,
                                    StartDate = @StartDate,
                                    EndDate = @EndDate
                                 WHERE CampaignID = @CampaignID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CampaignName", campaignName);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@TargetAmount", targetAmount);
                    cmd.Parameters.AddWithValue("@CollectedAmount", collectedAmount);
                    cmd.Parameters.AddWithValue("@Status", chkActive.Checked ? "Active" : "Inactive");
                    cmd.Parameters.AddWithValue("@StartDate", dateTimePickerStartDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", dateTimePickerEndDate.Value);
                    cmd.Parameters.AddWithValue("@CampaignID", selectedCampaignId);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Campaign updated successfully.");
                        LoadCampaigns();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }
        private void btnDeleteCampaign_Click(object sender, EventArgs e)
        {
            if (selectedCampaignId == 0)
            {
                MessageBox.Show("Please select a campaign first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this campaign?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "DELETE FROM Campaigns WHERE CampaignID = @CampaignID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CampaignID", selectedCampaignId);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Campaign deleted successfully.");
                        LoadCampaigns();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }
        private void ClearFields()
        {
            selectedCampaignId = 0;

            txtCampaignName.Clear();
            txtTargetAmount.Clear();
            txtDescription.Clear();
            txtCollectedAmount.Text = "0";
            dateTimePickerStartDate.Value = DateTime.Now;
            dateTimePickerEndDate.Value = DateTime.Now;
            chkActive.Checked = true;
        }
    }
}
