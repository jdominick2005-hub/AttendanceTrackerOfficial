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

            // ✅ VALIDATION FIRST
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

            // ✅ IF VALID, UPDATE DATABASE
            using (SqlConnection con = new SqlConnection(
                "Data Source=DESKTOP-279O6NS\\SQLEXPRESS;Initial Catalog=UserInformationDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"))
            {
                try
                {
                    con.Open();

                    // ✅ Make sure this table and column names match your DB
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Users SET Password=@password WHERE name= @name", con);

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
