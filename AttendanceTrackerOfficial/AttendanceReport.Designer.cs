namespace AttendanceTrackerOfficial
{
    partial class AttendanceReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceReport));
            button1 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label2 = new Label();
            btnAttendanceReport = new Button();
            btnStudentManagement = new Button();
            btnattendancelog = new Button();
            btnSubjectAllocation = new Button();
            btnDashboard = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            btnViewSummary = new Button();
            cmbSemester = new ComboBox();
            cmbCourse = new ComboBox();
            cmbSection = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(934, 78);
            button1.Name = "button1";
            button1.Size = new Size(66, 29);
            button1.TabIndex = 64;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(816, 40);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 62;
            label1.Text = "NAME OF THE USER";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(946, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 61;
            pictureBox2.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(260, 40);
            label2.Name = "label2";
            label2.Size = new Size(270, 32);
            label2.TabIndex = 63;
            label2.Text = "ATTENDANCE REPORT";
            // 
            // btnAttendanceReport
            // 
            btnAttendanceReport.BackColor = Color.SteelBlue;
            btnAttendanceReport.FlatAppearance.BorderSize = 0;
            btnAttendanceReport.FlatStyle = FlatStyle.System;
            btnAttendanceReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAttendanceReport.Location = new Point(14, 278);
            btnAttendanceReport.Name = "btnAttendanceReport";
            btnAttendanceReport.Size = new Size(223, 56);
            btnAttendanceReport.TabIndex = 6;
            btnAttendanceReport.Text = "Attendance Report";
            btnAttendanceReport.UseVisualStyleBackColor = false;
            btnAttendanceReport.Click += btnAttendanceReport_Click_1;
            // 
            // btnStudentManagement
            // 
            btnStudentManagement.BackColor = Color.SteelBlue;
            btnStudentManagement.BackgroundImageLayout = ImageLayout.None;
            btnStudentManagement.FlatAppearance.BorderSize = 0;
            btnStudentManagement.FlatStyle = FlatStyle.Flat;
            btnStudentManagement.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnStudentManagement.Location = new Point(12, 77);
            btnStudentManagement.Name = "btnStudentManagement";
            btnStudentManagement.Size = new Size(223, 56);
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
            btnattendancelog.Location = new Point(12, 211);
            btnattendancelog.Name = "btnattendancelog";
            btnattendancelog.Size = new Size(223, 56);
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
            btnSubjectAllocation.Location = new Point(12, 144);
            btnSubjectAllocation.Name = "btnSubjectAllocation";
            btnSubjectAllocation.Size = new Size(223, 56);
            btnSubjectAllocation.TabIndex = 2;
            btnSubjectAllocation.Text = "Subject Allocation";
            btnSubjectAllocation.UseVisualStyleBackColor = false;
            btnSubjectAllocation.Click += btnSubjectAllocation_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.SteelBlue;
            btnDashboard.BackgroundImageLayout = ImageLayout.None;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDashboard.Location = new Point(11, 10);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(224, 56);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
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
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 644);
            panel1.TabIndex = 60;
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
            panel3.Location = new Point(-1, 183);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 460);
            panel3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(57, 205);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 59;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(313, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(579, 347);
            dataGridView1.TabIndex = 69;
            // 
            // btnViewSummary
            // 
            btnViewSummary.Location = new Point(817, 130);
            btnViewSummary.Name = "btnViewSummary";
            btnViewSummary.Size = new Size(75, 33);
            btnViewSummary.TabIndex = 68;
            btnViewSummary.Text = "view";
            btnViewSummary.UseVisualStyleBackColor = true;
            // 
            // cmbSemester
            // 
            cmbSemester.FormattingEnabled = true;
            cmbSemester.Items.AddRange(new object[] { "1st Semester\t", "2nd Semester" });
            cmbSemester.Location = new Point(624, 136);
            cmbSemester.Name = "cmbSemester";
            cmbSemester.Size = new Size(121, 23);
            cmbSemester.TabIndex = 67;
            cmbSemester.Text = "Semester";
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "Bachelor of Science in Computer Engineering", "Bachelor of Science in Information Technology", "Bachelor of Science in Computer Science", "Bachelor of Multimedia Arts" });
            cmbCourse.Location = new Point(313, 136);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(121, 23);
            cmbCourse.TabIndex = 66;
            cmbCourse.Text = "Course";
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cmbSection.Location = new Point(467, 136);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(121, 23);
            cmbSection.TabIndex = 65;
            cmbSection.Text = "Section";
            // 
            // AttendanceReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 644);
            Controls.Add(dataGridView1);
            Controls.Add(btnViewSummary);
            Controls.Add(cmbSemester);
            Controls.Add(cmbCourse);
            Controls.Add(cmbSection);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AttendanceReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance_Summary";
            Load += AttendanceReport_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private PictureBox pictureBox2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label2;
        private Button btnAttendanceReport;
        private Button btnStudentManagement;
        private Button btnattendancelog;
        private Button btnSubjectAllocation;
        private Button btnDashboard;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel3;
        private Label label5;
        private DataGridView dataGridView1;
        private Button btnViewSummary;
        private ComboBox cmbSemester;
        private ComboBox cmbCourse;
        private ComboBox cmbSection;
    }
}