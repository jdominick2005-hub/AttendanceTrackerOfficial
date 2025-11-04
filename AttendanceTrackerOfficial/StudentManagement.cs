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
    public partial class StudentManagement : Form
    {
        public StudentManagement()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("AttendanceDB");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Register values (@StudentId, @Name, @YearLevel, @Course, @Units, @Classified)", con);
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(txtStudentId.Text));
            cmd.Parameters.AddWithValue("@Name", txtFullName.Text);
            cmd.Parameters.AddWithValue("@YearLevel", txtYearLevel.Text);
            cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
            cmd.Parameters.AddWithValue("@Units", txtUnits.Text);
            cmd.Parameters.AddWithValue("@Classified", txtClassified.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succesfully Registered");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("AttendanceDB");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Register where StudentId=@StudentId", con);
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(txtStudentId.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succesfully Deleted");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("AttendanceDB");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE Register 
                    SET Name = @Name, YearLevel = @YearLevel, Course = @Course, Units = @Units, Classified = @Classified 
                    WHERE StudentId = @StudentId", con);

            cmd.Parameters.AddWithValue("@StudentId", int.Parse(txtStudentId.Text));
            cmd.Parameters.AddWithValue("@Name", txtFullName.Text);
            cmd.Parameters.AddWithValue("@YearLevel", txtYearLevel.Text);
            cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
            cmd.Parameters.AddWithValue("@Units", int.Parse(txtUnits.Text));
            cmd.Parameters.AddWithValue("@Classified", txtClassified.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succesfully Updated");


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("AttendanceDB");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Register", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Student_Registered Student_RegsiteredForm = new Student_Registered();
            this.Hide();
            Student_RegsiteredForm.Show();
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnSubjectAllocation_Click(object sender, EventArgs e)
        {
            AssignSubject AssignSubjectForm = new AssignSubject();
            AssignSubjectForm.Show();
            this.Hide();
        }

        private void btnattendancelog_Click(object sender, EventArgs e)
        {
            Daily_Attendance_Record Daily_Attendance_RecordForm = new Daily_Attendance_Record();
            Daily_Attendance_RecordForm.Show();
            this.Hide();
        }

        private void btnAttendanceReport_Click(object sender, EventArgs e)
        {
            AttendanceReport AttendanceReportForm = new AttendanceReport();
            AttendanceReportForm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Student_Attendance_Db Student_Attendance_DbForm = new Student_Attendance_Db();
            Student_Attendance_DbForm.Show();
            this.Hide();
        }
    }
}
