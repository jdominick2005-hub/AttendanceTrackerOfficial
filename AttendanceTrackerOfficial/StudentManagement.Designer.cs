namespace AttendanceTrackerOfficial
{
    partial class StudentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentManagement));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtStudentId = new TextBox();
            txtFullName = new TextBox();
            txtYearLevel = new TextBox();
            txtCourse = new TextBox();
            txtUnits = new TextBox();
            txtClassified = new TextBox();
            btnSubmit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnShow = new Button();
            btnView = new Button();
            dataGridView1 = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnAttendanceReport = new Button();
            btnStudentManagement = new Button();
            btnattendancelog = new Button();
            btnSubjectAllocation = new Button();
            btnDashboard = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label9 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(46, 30);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 0;
            label1.Text = "Student Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(46, 68);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 1;
            label2.Text = "Full Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(46, 106);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 2;
            label3.Text = "Year Level:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(46, 144);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 3;
            label4.Text = "Course:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(46, 182);
            label5.Name = "label5";
            label5.Size = new Size(51, 21);
            label5.TabIndex = 4;
            label5.Text = "Units:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(46, 220);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 5;
            label6.Text = "Classified:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(137, 17);
            txtStudentId.Multiline = true;
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(339, 32);
            txtStudentId.TabIndex = 1;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(137, 55);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(339, 31);
            txtFullName.TabIndex = 2;
            // 
            // txtYearLevel
            // 
            txtYearLevel.Location = new Point(137, 92);
            txtYearLevel.Multiline = true;
            txtYearLevel.Name = "txtYearLevel";
            txtYearLevel.Size = new Size(339, 32);
            txtYearLevel.TabIndex = 3;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(137, 130);
            txtCourse.Multiline = true;
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(339, 32);
            txtCourse.TabIndex = 4;
            // 
            // txtUnits
            // 
            txtUnits.Location = new Point(137, 168);
            txtUnits.Multiline = true;
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(339, 32);
            txtUnits.TabIndex = 5;
            // 
            // txtClassified
            // 
            txtClassified.Location = new Point(137, 206);
            txtClassified.Multiline = true;
            txtClassified.Name = "txtClassified";
            txtClassified.Size = new Size(339, 32);
            txtClassified.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DodgerBlue;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(830, 97);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(113, 39);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit\r\n";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DodgerBlue;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(830, 142);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 39);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DodgerBlue;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(830, 187);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 39);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.DodgerBlue;
            btnShow.FlatStyle = FlatStyle.Popup;
            btnShow.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnShow.ForeColor = Color.White;
            btnShow.Location = new Point(830, 232);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(113, 39);
            btnShow.TabIndex = 10;
            btnShow.Text = "Show\r\n";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.DodgerBlue;
            btnView.FlatStyle = FlatStyle.Popup;
            btnView.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(830, 312);
            btnView.Name = "btnView";
            btnView.Size = new Size(113, 56);
            btnView.TabIndex = 11;
            btnView.Text = "View Registered Student";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(298, 374);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(645, 237);
            dataGridView1.TabIndex = 12;
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
            btnAttendanceReport.Location = new Point(12, 283);
            btnAttendanceReport.Name = "btnAttendanceReport";
            btnAttendanceReport.Size = new Size(223, 56);
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
            btnStudentManagement.FlatStyle = FlatStyle.System;
            btnStudentManagement.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnStudentManagement.Location = new Point(13, 82);
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
            btnattendancelog.Location = new Point(12, 216);
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
            btnSubjectAllocation.Location = new Point(12, 149);
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
            btnDashboard.Location = new Point(12, 15);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(224, 56);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 644);
            panel2.TabIndex = 54;
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
            panel3.Size = new Size(235, 440);
            panel3.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(293, 54);
            label9.Name = "label9";
            label9.Size = new Size(304, 32);
            label9.TabIndex = 57;
            label9.Text = "STUDENT MANAGEMENT";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Silver;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(0, 205);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 53;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtStudentId);
            panel1.Controls.Add(txtYearLevel);
            panel1.Controls.Add(txtCourse);
            panel1.Controls.Add(txtClassified);
            panel1.Controls.Add(txtUnits);
            panel1.Location = new Point(298, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 271);
            panel1.TabIndex = 58;
            // 
            // StudentManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 644);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(btnView);
            Controls.Add(btnShow);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSubmit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StudentManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtStudentId;
        private TextBox txtFullName;
        private TextBox txtYearLevel;
        private TextBox txtCourse;
        private TextBox txtUnits;
        private TextBox txtClassified;
        private Button btnSubmit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnShow;
        private Button btnView;
        private DataGridView dataGridView1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnAttendanceReport;
        private Button btnStudentManagement;
        private Button btnattendancelog;
        private Button btnSubjectAllocation;
        private Button btnDashboard;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Label label9;
        private Label label10;
        private Panel panel1;
    }
}