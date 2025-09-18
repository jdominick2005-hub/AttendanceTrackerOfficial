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

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Student_Attendance_Db dashboard = new Student_Attendance_Db();
            this.Hide();
            dashboard.Show();
        }
    }
}
