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
 
    public partial class Signup : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=GEMINI;InitialCatalog=StudentAttendanceTracker_db;IntegratedSecurity=True;TrustServerCertificate=True");

        public Signup()
        { 
            InitializeComponent();
        }
        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    String checkUsername = "SELECT * FROM admin WHERE username = '"
                         + signup_username.Text.Trim() + "'"; //admin is out table name

                    using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(signup_username.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO admin (email, username, password, date_created) " +
                                "VALUES(@email, @username, @pass, @date)";

                            DateTime date = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@date", date);

                                cmd.ExecuteNonQuery(); // execute the command!

                                MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //To Switch the form
                                Signup loginForm = new Signup();
                                loginForm.Show();
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void signup_loginHere_Click(object sender, EventArgs e)
        {
            Signup loginForm = new Signup();
            loginForm.Show();
            this.Close();
        }
    }
}
