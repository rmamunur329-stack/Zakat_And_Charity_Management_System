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
    public partial class Form7 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form7()
        {
            InitializeComponent();
            lblFullName.Text = "Full Name:";
            lblEmail.Text = "Email:";
            lblphone.Text = "Phone:";
            lblCatagory.Text = "Catagory:";
            lblAddress.Text = "Address:";
            lblMonthlyIncome.Text = "Monthly Income (BDT):";
            lblFamilyMembers.Text = "Family Members:";
            lblNID.Text = "NID (National ID):";
            lblVerified.Text = "Verified:";
            lblEligible.Text = "Eligible:";

            btnUpdateProfile.Text = "Update\nProfile";
            btnClose.Text = "Close";

            txtEmail.ReadOnly = true;

            cmbCatagory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVerified.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEligible.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbCatagory.Items.Clear();
            cmbCatagory.Items.Add("Poor");
            cmbCatagory.Items.Add("Needy");
            cmbCatagory.Items.Add("Orphan");
            cmbCatagory.Items.Add("Widow");
            cmbCatagory.Items.Add("Student");
            cmbCatagory.Items.Add("Medical Aid");
            cmbCatagory.Items.Add("Shelter Support");

            cmbVerified.Items.Clear();
            cmbVerified.Items.Add("Yes");
            cmbVerified.Items.Add("No");

            cmbEligible.Items.Clear();
            cmbEligible.Items.Add("Yes");
            cmbEligible.Items.Add("No");

            cmbVerified.SelectedIndex = 1;
            cmbEligible.SelectedIndex = 1;

            this.Load += Form7_Load;
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void LoadProfile()
        {
            if (Form1.LoggedInEmail == "")
            {
                MessageBox.Show("Please login first.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT FullName, Email, Phone, Category, Address,
                                        MonthlyIncome, FamilyMembers, NID, Verified, Eligible
                                 FROM Users
                                 WHERE Email = @Email";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", Form1.LoggedInEmail);

                    try
                    {
                        con.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txtFullName.Text = dr["FullName"].ToString();
                                txtEmail.Text = dr["Email"].ToString();
                                txtPhone.Text = dr["Phone"].ToString();
                                cmbCatagory.Text = dr["Category"].ToString();
                                txtAddress.Text = dr["Address"].ToString();
                                txtMonthlyIncome.Text = dr["MonthlyIncome"].ToString();
                                txtFamilyMembers.Text = dr["FamilyMembers"].ToString();
                                txtNID.Text = dr["NID"].ToString();

                                if (dr["Verified"].ToString() == "")
                                {
                                    cmbVerified.Text = "No";
                                }
                                else
                                {
                                    cmbVerified.Text = dr["Verified"].ToString();
                                }

                                if (dr["Eligible"].ToString() == "")
                                {
                                    cmbEligible.Text = "No";
                                }
                                else
                                {
                                    cmbEligible.Text = dr["Eligible"].ToString();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string category = cmbCatagory.Text.Trim();
            string address = txtAddress.Text.Trim();
            string nid = txtNID.Text.Trim();

            decimal monthlyIncome;
            int familyMembers;

            if (fullName == "")
            {
                MessageBox.Show("Please enter full name.");
                txtFullName.Focus();
                return;
            }

            if (phone == "")
            {
                MessageBox.Show("Please enter phone.");
                txtPhone.Focus();
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
                txtAddress.Focus();
                return;
            }

            if (!decimal.TryParse(txtMonthlyIncome.Text.Trim(), out monthlyIncome))
            {
                MessageBox.Show("Please enter valid monthly income.");
                txtMonthlyIncome.Focus();
                return;
            }

            if (!int.TryParse(txtFamilyMembers.Text.Trim(), out familyMembers))
            {
                MessageBox.Show("Please enter valid family members.");
                txtFamilyMembers.Focus();
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"UPDATE Users SET
                                    FullName = @FullName,
                                    Phone = @Phone,
                                    Category = @Category,
                                    Address = @Address,
                                    MonthlyIncome = @MonthlyIncome,
                                    FamilyMembers = @FamilyMembers,
                                    NID = @NID,
                                    Verified = @Verified,
                                    Eligible = @Eligible
                                 WHERE Email = @Email";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@MonthlyIncome", monthlyIncome);
                    cmd.Parameters.AddWithValue("@FamilyMembers", familyMembers);
                    cmd.Parameters.AddWithValue("@NID", nid);
                    cmd.Parameters.AddWithValue("@Verified", cmbVerified.Text);
                    cmd.Parameters.AddWithValue("@Eligible", cmbEligible.Text);
                    cmd.Parameters.AddWithValue("@Email", Form1.LoggedInEmail);

                    try
                    {
                        con.Open();

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Profile updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Profile update failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
