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
            Registration RegistrationForm = new Registration();
            this.Hide();
            RegistrationForm.Show();
        }
    }
}
