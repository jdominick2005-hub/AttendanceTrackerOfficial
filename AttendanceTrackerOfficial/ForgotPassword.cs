using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace AttendanceTrackerOfficial
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnresetpassword_Click(string newpassword, string Name)
        {
            using (SqlConnection con = new SqlConnection("Data Source=GERALD\\SQLEXPRESS;Initial Catalog=attendance_db;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Login SET password=@password WHERE username=@username", con);
                cmd.Parameters.AddWithValue("@password", newpassword);
                cmd.Parameters.AddWithValue("@name", Name);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Name not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                string name = txtname.Text.Trim();
                string newPassword = txtnewpassword.Text.Trim();
                string confirmPassword = txtconfirmpassword.Text.Trim();

                // Validate inputs
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    LoginPage loginPage = new LoginPage();
                    loginPage.Show();
                    this.Hide();
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            LoginPage cancelForm = new LoginPage();
            cancelForm.Show();
            this.Close();
        }
    }
}
