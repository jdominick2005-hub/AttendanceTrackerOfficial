using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace AttendanceTrackerOfficial
{
    public partial class AssignSubject : Form
    {
        public AssignSubject()
        {
            InitializeComponent();
        }
        // ADD
        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AttendaceDB"].ConnectionString);
            if (string.IsNullOrWhiteSpace(txtsubject.Text) ||
                string.IsNullOrWhiteSpace(txtyearlevel.Text) ||
                string.IsNullOrWhiteSpace(txtsection.Text) ||
                string.IsNullOrWhiteSpace(txtschedule.Text))
            {
                MessageBox.Show("Please fill in all fields before adding.");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Subjects (SubjectName, YearLevel, Section, Schedule) VALUES (@name, @year, @section, @sched)", con);
                cmd.Parameters.AddWithValue("@name", txtsubject.Text);
                cmd.Parameters.AddWithValue("@year", txtyearlevel.Text);
                cmd.Parameters.AddWithValue("@section", txtsection.Text);
                cmd.Parameters.AddWithValue("@sched", txtschedule.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Subject successfully added!");
                ClearFields();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        // VIEW
        private void btnview_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AttendaceDB"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Subjects", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvviewsubject.DataSource = dt;
        }

        // UPDATE
        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AttendaceDB"].ConnectionString);
            if (dgvviewsubject.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            int id = Convert.ToInt32(dgvviewsubject.CurrentRow.Cells["SubjectID"].Value);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Subjects SET SubjectName=@name, YearLevel=@year, Section=@section, Schedule=@sched WHERE SubjectID=@id", con);
                cmd.Parameters.AddWithValue("@name", txtsubject.Text);
                cmd.Parameters.AddWithValue("@year", txtyearlevel.Text);
                cmd.Parameters.AddWithValue("@section", txtsection.Text);
                cmd.Parameters.AddWithValue("@sched", txtschedule.Text);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record updated successfully!");
                ClearFields();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        // DELETE
        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AttendaceDB"].ConnectionString);
            if (dgvviewsubject.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            int id = Convert.ToInt32(dgvviewsubject.CurrentRow.Cells["SubjectID"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Subjects WHERE SubjectID=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record deleted successfully!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        // SEARCH
        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AttendaceDB"].ConnectionString);
            string keyword = txtbox.Text.Trim();

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Subjects WHERE SubjectName LIKE @kw OR YearLevel LIKE @kw OR Section LIKE @kw OR Schedule LIKE @kw", con);
            da.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvviewsubject.DataSource = dt;
        }

        // CLEAR TEXTBOXES
        private void ClearFields()
        {
            txtsubject.Clear();
            txtyearlevel.Clear();
            txtsection.Clear();
            txtschedule.Clear();
            txtbox.Clear();
        }

        private void txtsubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Student_Attendance_Db Student_Attendance_DbForm = new Student_Attendance_Db();
            Student_Attendance_DbForm.Show();
            this.Hide();
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            StudentManagement StudentManagementForm = new StudentManagement();
            StudentManagementForm.Show();
            this.Hide();
        }

        private void btnattendancelog_Click_1(object sender, EventArgs e)
        {
            Daily_Attendance_Record Daily_Attendance_RecordForm = new Daily_Attendance_Record();
            Daily_Attendance_RecordForm.Show();
            this.Hide();
        }

        private void btnAttendanceReport_Click_1(object sender, EventArgs e)
        {
            AttendanceReport AttendanceReportForm = new AttendanceReport();
            AttendanceReportForm.Show();
            this.Hide();
        }
    }
}