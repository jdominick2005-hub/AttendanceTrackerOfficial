using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AttendanceTrackerOfficial
{
    public partial class AttendanceReport : Form
    {
        private Student_Attendance_Db dashboardForm;

        public AttendanceReport(Student_Attendance_Db dashboard)
        {
            InitializeComponent();
            dashboardForm = dashboard;
        }

        public AttendanceReport()
        {
        }

        private void AttendanceReport_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AttendanceDB"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Load courses
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT Course FROM Register ORDER BY Course;", con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbCourse.Items.Clear();
                        while (reader.Read())
                        {
                            cmbCourse.Items.Add(reader["Course"].ToString());
                        }
                    }

                    // Load year levels
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT YearLevel FROM Register ORDER BY YearLevel;", con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbSemester.Items.Clear();
                        while (reader.Read())
                        {
                            cmbSemester.Items.Add(reader["YearLevel"].ToString());
                        }
                    }

                    // Load section options (instead of summary)
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT Classified FROM Register ORDER BY Classified;", con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbSection.Items.Clear();
                        while (reader.Read())
                        {
                            cmbSection.Items.Add(reader["Classified"].ToString());
                        }
                    }
                }

                // Set defaults
                if (cmbCourse.Items.Count > 0) cmbCourse.SelectedIndex = 0;
                if (cmbSemester.Items.Count > 0) cmbSemester.SelectedIndex = 0;
                if (cmbSection.Items.Count > 0) cmbSection.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnattendancelog_Click(object sender, EventArgs e)
        {
            Daily_Attendance_Record Daily_Attendance_RecordForm = new Daily_Attendance_Record();
            Daily_Attendance_RecordForm.Show();
            this.Hide();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
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

        private void btnSubjectAllocation_Click(object sender, EventArgs e)
        {
            AssignSubject AssignSubjectForm = new AssignSubject();
            AssignSubjectForm.Show();
            this.Hide();
        }

        private void btnAttendanceReport_Click_1(object sender, EventArgs e)
        {
            string course = cmbCourse.SelectedItem?.ToString();
            string yearLevel = cmbSemester.SelectedItem?.ToString();
            string section = cmbSection.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(course) || string.IsNullOrEmpty(yearLevel))
            {
                MessageBox.Show("Please select both Course and Year Level.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["UserInformationDB"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                        SELECT 
                            StudentId,
                            Name,
                            Course,
                            YearLevel,
                            Units,
                            Classified,
                            DateRegistered
                        FROM Register
                        WHERE Course = @course
                          AND YearLevel = @yearLevel
                          AND (@section IS NULL OR Classified = @section)
                        ORDER BY Name;";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@course", course);
                        cmd.Parameters.AddWithValue("@yearLevel", yearLevel);
                        cmd.Parameters.AddWithValue("@section", (object)section ?? DBNull.Value);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance summary: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
