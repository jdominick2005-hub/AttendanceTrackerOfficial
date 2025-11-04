using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceTrackerOfficial
{
    public partial class Student_Attendance_Db : Form
    {
        public Student_Attendance_Db()
        {
            InitializeComponent();
        }
        private void Student_Attendance_Db_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            StudentManagement RegistrationForm = new StudentManagement();
            this.Hide();
            RegistrationForm.Show();
        }

        private void btnSubjectAllocation_Click_1(object sender, EventArgs e)
        {
            AssignSubject AssignSubjectForm = new AssignSubject();
            this.Hide();  // hides the dashboard
            AssignSubjectForm.Show();  // opens your Assign Subject form
        }

        private void btnattendancelog_Click(object sender, EventArgs e)
        {
            AttendanceReport Attendance_SummaryForm = new AttendanceReport(this);
            this.Hide();
            Attendance_SummaryForm.Show();
        }

        private void btnAttendanceReport_Click(object sender, EventArgs e)
        {
            AttendanceReport AttendanceReportForm = new AttendanceReport(this);
            this.Hide();  // hides the dashboard
            AttendanceReportForm.Show();
        }
    }
}
