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
    public partial class Form5 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form5()
        {
            InitializeComponent();

            lblCatagory.Text = "Catagory(Select your situation):";
            lblYourAddress.Text = "Your Address:";
            lblMonthlyIncome.Text = "Monthly Income(BDT):";
            lblNumberOfFamilyMembers.Text = "Number Of Family Members:";
            btnSUBMITAPPLICATION.Text = "SUBMIT\nAPPLICATION";

            textBox1.Text = "";
            txtNumberOfFamilyMembers.Text = "";

            cmbCatagory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCatagory.Items.Clear();
            cmbCatagory.Items.Add("Poor");
            cmbCatagory.Items.Add("Needy");
            cmbCatagory.Items.Add("Orphan");
            cmbCatagory.Items.Add("Widow");
            cmbCatagory.Items.Add("Student");
            cmbCatagory.Items.Add("Medical Aid");
            cmbCatagory.Items.Add("Shelter Support");
            cmbCatagory.SelectedIndex = 0;
        }

        private void lblNumberOfFamilyMembers_Click(object sender, EventArgs e)
        {

        }

        private void btnSUBMITAPPLICATION_Click(object sender, EventArgs e)
        {
            string email = Form1.LoggedInEmail;
            string category = cmbCatagory.Text.Trim();
            string address = txtYourAddress.Text.Trim();

            decimal monthlyIncome;
            int familyMembers;

            if (email == "")
            {
                MessageBox.Show("Please login first.");
                return;
            }

            if (category == "")
            {
                MessageBox.Show("Please select category.");
                cmbCatagory.Focus();
                return;
            }

            if (address == "")
            {
                MessageBox.Show("Please enter address.");
                txtYourAddress.Focus();
                return;
            }

            if (!decimal.TryParse(textBox1.Text.Trim(), out monthlyIncome))
            {
                MessageBox.Show("Please enter valid monthly income.");
                textBox1.Focus();
                return;
            }

            if (!int.TryParse(txtNumberOfFamilyMembers.Text.Trim(), out familyMembers))
            {
                MessageBox.Show("Please enter valid number of family members.");
                txtNumberOfFamilyMembers.Focus();
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"INSERT INTO AidApplications
                                 (Email, Category, Address, MonthlyIncome, FamilyMembers, Status, ApplicationDate)
                                 VALUES
                                 (@Email, @Category, @Address, @MonthlyIncome, @FamilyMembers, @Status, @ApplicationDate)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@MonthlyIncome", monthlyIncome);
                    cmd.Parameters.AddWithValue("@FamilyMembers", familyMembers);
                    cmd.Parameters.AddWithValue("@Status", "Pending");
                    cmd.Parameters.AddWithValue("@ApplicationDate", DateTime.Now);

                    try
                    {
                        con.Open();

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Application submitted successfully.");

                            txtYourAddress.Clear();
                            textBox1.Clear();
                            txtNumberOfFamilyMembers.Clear();
                            cmbCatagory.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Application submit failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }
    }
    
}
