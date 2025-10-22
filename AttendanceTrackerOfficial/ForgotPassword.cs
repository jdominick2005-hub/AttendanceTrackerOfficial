using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AttendanceTrackerOfficial
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnresetpass_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            string newPassword = txtnewpassword.Text.Trim();
            string confirmPassword = txtconfirmpassword.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter a new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(
                System.Configuration.ConfigurationManager.ConnectionStrings["UserInformationDB"].ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Logins SET Password=@password WHERE Name=@name", con);
                    cmd.Parameters.AddWithValue("@password", newPassword);
                    cmd.Parameters.AddWithValue("@name", name);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoginPage loginPage = new LoginPage();
                        loginPage.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btncancel_Click(object sender, EventArgs e)
        {
            LoginPage cancelForm = new LoginPage();
            cancelForm.Show();
            this.Close();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
     

    }
}
