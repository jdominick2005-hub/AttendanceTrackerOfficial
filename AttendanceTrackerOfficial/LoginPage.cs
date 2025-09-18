using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AttendanceTrackerOfficial
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void lnkforgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }

        private void lnksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup secondForm = new Signup();
            secondForm.Show();
            this.Hide();
        }

        SqlConnection connect = new SqlConnection("Data Source=JAY\\SQLEXPRESS;Initial Catalog=attendance_db;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtusername.Text) || string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Please fill in both Username and Password fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                connect.Open();

                string query = "SELECT * FROM admin WHERE username = @username and password = @password";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count == 1)
                    {
                       
                        
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (chkbxremember.Checked)
                        {
                            Properties.Settings.Default.username = txtusername.Text.Trim();
                            Properties.Settings.Default.password = txtpassword.Text.Trim();
                            Properties.Settings.Default.RememberMe = true;
                        }
                        else
                        {
                            Properties.Settings.Default.username = "";
                            Properties.Settings.Default.password = "";
                            Properties.Settings.Default.RememberMe = false;
                        }

                        Properties.Settings.Default.Save();

                            Student_Attendance_Db dashboard = new Student_Attendance_Db();
                        this.Hide();
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Databasse Connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.RememberMe)
            {
                txtusername.Text = Properties.Settings.Default.username;
                txtpassword.Text = Properties.Settings.Default.password;
                chkbxremember.Checked = true;
            }
        }
    }
}
