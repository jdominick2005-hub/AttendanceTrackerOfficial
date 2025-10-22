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
    using System.Configuration;




    namespace AttendanceTrackerOfficial
    {

        public partial class Signup : Form
        {
            SqlConnection connect = new SqlConnection(
             ConfigurationManager.ConnectionStrings["UserInformationDB"].ConnectionString
         );




            public Signup()
            {
                InitializeComponent();
            }
            private void button1_Click(object sender, EventArgs e)
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        // Secure parameterized query for checking username
                        string checkUsername = "SELECT * FROM Logins WHERE Username = @username";
                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@username", signup_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_username.Text + " already exists",
                                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // Insert new user (including name)
                                string insertData = "INSERT INTO Logins (Name, Username, Password, Date_Created) " +
                                                    "VALUES(@name, @username, @password, @date)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@name", signup_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!",
                                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Switch to login form
                                    LoginPage loginForm = new LoginPage();
                                    loginForm.Show();
                                    this.Close();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex.Message,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

            private void signup_loginHere_Click(object sender, EventArgs e)
            {
                LoginPage loginForm = new LoginPage();
                loginForm.Show();
                this.Close();
            }

            private void lnklogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                LoginPage loginForm = new LoginPage();
                loginForm.Show();
                this.Close();
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void Signup_Load(object sender, EventArgs e)
            {

            }
        }
    }
