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
    public partial class Form19 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form19()
        {
            InitializeComponent();
            lblStartDate.Text = "Start Date:";
            lblEndDate.Text = "End Date (After 1 Year):";
            lblDaysRemaining.Text = "Days Remaining:";
            lblStatus.Text = "Status:";
            lblZakatDue.Text = "Zakat Due:";
            btnStartNewHawl.Text = "START\nNEW HAWL";

            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddYears(1);

            dtpStartDate.ValueChanged -= dtpStartDate_ValueChanged;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;

            dtpEndDate.ValueChanged -= dtpEndDate_ValueChanged;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;

            btnStartNewHawl.Click -= btnStartNewHawl_Click;
            btnStartNewHawl.Click += btnStartNewHawl_Click;

            pnlProgressCircle.Paint -= pnlProgressCircle_Paint;
            pnlProgressCircle.Paint += pnlProgressCircle_Paint;

            CalculateHawl();
        }
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.Value = dtpStartDate.Value.AddYears(1);
            CalculateHawl();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateHawl();
        }

        private void CalculateHawl()
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;
            DateTime today = DateTime.Today;

            int totalDays = Math.Max(1, (endDate - startDate).Days);
            int daysPassed = (today - startDate).Days;
            int daysRemaining = (endDate - today).Days;

            if (daysRemaining < 0)
            {
                daysRemaining = 0;
            }

            int progress = (int)((daysPassed * 100.0) / totalDays);

            if (progress < 0)
            {
                progress = 0;
            }

            if (progress > 100)
            {
                progress = 100;
            }

            lblDaysValue.Text = daysRemaining.ToString();

            if (today >= endDate)
            {
                lblStatusValue.Text = "Completed";
                lblZakatDueValue.Text = "Yes";
                lblProgressText.Text = "Hawl Completed";
            }
            else
            {
                lblStatusValue.Text = "Running";
                lblZakatDueValue.Text = "No";
                lblProgressText.Text = "Hawl Running";
            }

            lblProgressPercent.Text = progress.ToString() + "%";

            pnlProgressCircle.Tag = progress;
            pnlProgressCircle.Invalidate();
        }

        private void btnStartNewHawl_Click(object sender, EventArgs e)
        {
            if (Form1.LoggedInEmail == "")
            {
                MessageBox.Show("Please login first.");
                return;
            }

            CalculateHawl();

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"INSERT INTO HawlTrackers
                                 (DonorEmail, StartDate, EndDate, Status, ZakatDue)
                                 VALUES
                                 (@DonorEmail, @StartDate, @EndDate, @Status, @ZakatDue)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DonorEmail", Form1.LoggedInEmail);
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", lblStatusValue.Text);
                    cmd.Parameters.AddWithValue("@ZakatDue", lblZakatDueValue.Text);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Hawl tracker saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }

        private void pnlProgressCircle_Paint(object sender, PaintEventArgs e)
        {
            int progress = 0;

            if (pnlProgressCircle.Tag != null)
            {
                progress = Convert.ToInt32(pnlProgressCircle.Tag);
            }

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(20, 20, pnlProgressCircle.Width - 40, pnlProgressCircle.Height - 40);

            using (Pen backgroundPen = new Pen(Color.LightGray, 12))
            using (Pen progressPen = new Pen(Color.Green, 12))
            {
                e.Graphics.DrawArc(backgroundPen, rect, -90, 360);
                e.Graphics.DrawArc(progressPen, rect, -90, progress * 360 / 100);
            }
        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form19_Load(object sender, EventArgs e)
        {

        }
    }
}
