namespace AttendanceTrackerOfficial
{
    partial class Student_Attendance_Db
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Attendance_Db));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnAttendanceReport = new Button();
            btnStudentManagement = new Button();
            btnattendancelog = new Button();
            btnSubjectAllocation = new Button();
            btnDashboard = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            button1 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(905, 53);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 50;
            label1.Text = "NAME OF THE USER";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1054, 43);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnAttendanceReport
            // 
            btnAttendanceReport.BackColor = Color.SteelBlue;
            btnAttendanceReport.FlatAppearance.BorderSize = 0;
            btnAttendanceReport.FlatStyle = FlatStyle.Flat;
            btnAttendanceReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAttendanceReport.Location = new Point(14, 371);
            btnAttendanceReport.Margin = new Padding(3, 4, 3, 4);
            btnAttendanceReport.Name = "btnAttendanceReport";
            btnAttendanceReport.Size = new Size(223, 64);
            btnAttendanceReport.TabIndex = 6;
            btnAttendanceReport.Text = "Attendance Report";
            btnAttendanceReport.UseVisualStyleBackColor = false;
            btnAttendanceReport.Click += btnAttendanceReport_Click;
            // 
            // btnStudentManagement
            // 
            btnStudentManagement.BackColor = Color.SteelBlue;
            btnStudentManagement.BackgroundImageLayout = ImageLayout.None;
            btnStudentManagement.FlatAppearance.BorderSize = 0;
            btnStudentManagement.FlatStyle = FlatStyle.Flat;
            btnStudentManagement.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnStudentManagement.Location = new Point(14, 103);
            btnStudentManagement.Margin = new Padding(3, 4, 3, 4);
            btnStudentManagement.Name = "btnStudentManagement";
            btnStudentManagement.Size = new Size(223, 64);
            btnStudentManagement.TabIndex = 5;
            btnStudentManagement.Text = "Student Management";
            btnStudentManagement.UseVisualStyleBackColor = false;
            btnStudentManagement.Click += btnStudentManagement_Click;
            // 
            // btnattendancelog
            // 
            btnattendancelog.BackColor = Color.SteelBlue;
            btnattendancelog.FlatAppearance.BorderSize = 0;
            btnattendancelog.FlatStyle = FlatStyle.Flat;
            btnattendancelog.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnattendancelog.Location = new Point(14, 281);
            btnattendancelog.Margin = new Padding(3, 4, 3, 4);
            btnattendancelog.Name = "btnattendancelog";
            btnattendancelog.Size = new Size(223, 64);
            btnattendancelog.TabIndex = 4;
            btnattendancelog.Text = "Attendance Log";
            btnattendancelog.UseVisualStyleBackColor = false;
            btnattendancelog.Click += btnattendancelog_Click;
            // 
            // btnSubjectAllocation
            // 
            btnSubjectAllocation.BackColor = Color.SteelBlue;
            btnSubjectAllocation.BackgroundImageLayout = ImageLayout.None;
            btnSubjectAllocation.FlatAppearance.BorderSize = 0;
            btnSubjectAllocation.FlatStyle = FlatStyle.Flat;
            btnSubjectAllocation.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSubjectAllocation.Location = new Point(14, 192);
            btnSubjectAllocation.Margin = new Padding(3, 4, 3, 4);
            btnSubjectAllocation.Name = "btnSubjectAllocation";
            btnSubjectAllocation.Size = new Size(223, 64);
            btnSubjectAllocation.TabIndex = 2;
            btnSubjectAllocation.Text = "Subject Allocation";
            btnSubjectAllocation.UseVisualStyleBackColor = false;
            btnSubjectAllocation.Click += btnSubjectAllocation_Click_1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.SteelBlue;
            btnDashboard.BackgroundImageLayout = ImageLayout.None;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.System;
            btnDashboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDashboard.Location = new Point(14, 28);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(206, 64);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 859);
            panel1.TabIndex = 48;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(btnAttendanceReport);
            panel3.Controls.Add(btnStudentManagement);
            panel3.Controls.Add(btnattendancelog);
            panel3.Controls.Add(btnSubjectAllocation);
            panel3.Controls.Add(btnDashboard);
            panel3.Location = new Point(-1, 244);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(238, 727);
            panel3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 273);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 47;
            // 
            // button1
            // 
            button1.Location = new Point(1040, 104);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 39);
            button1.TabIndex = 52;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(270, 53);
            label2.Name = "label2";
            label2.Size = new Size(206, 41);
            label2.TabIndex = 51;
            label2.Text = "DASHBOARD";
            // 
            // Student_Attendance_Db
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1152, 859);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Student_Attendance_Db";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student_Attendance_Db";
            Load += Student_Attendance_Db_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnAttendanceReport;
        private Button btnStudentManagement;
        private Button btnattendancelog;
        private Button btnSubjectAllocation;
        private Button btnDashboard;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel3;
        private Label label5;
        private Button button1;
        private Label label2;
    }
}