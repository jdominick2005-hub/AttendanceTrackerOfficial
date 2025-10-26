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
using Microsoft.Data.SqlClient;

namespace AttendanceTrackerOfficial
{
    public partial class Student_Registered : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\davin\OneDrive\Pictures\ドキュメント\UserInformationDB.mdf;Integrated Security=True;Connect Timeout=30");

        public Student_Registered()
        {
            InitializeComponent();
        }

        private void Student_Registered_Load(object sender, EventArgs e)
        {
            LoadRegister();
        }

        private void LoadRegister()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Register", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Register WHERE Name LIKE @search", con);
            da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadRegister();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Registration RegistrationForm = new Registration();
            this.Hide();
            RegistrationForm.Show();
        }
    }
}
