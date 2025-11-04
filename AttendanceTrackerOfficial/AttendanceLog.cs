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
    public partial class Daily_Attendance_Record : Form
    {
        public Daily_Attendance_Record()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Student_Attendance_Db Student_Attendance_DbForm = new Student_Attendance_Db();
            Student_Attendance_DbForm.Show();
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

        private void btnAttendanceReport_Click(object sender, EventArgs e)
        {
            AttendanceReport AttendanceReportForm = new AttendanceReport();
            AttendanceReportForm.Show();
            this.Hide();
        }
    }
}
