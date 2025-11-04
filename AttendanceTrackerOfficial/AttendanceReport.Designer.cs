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
            button3 = new Button();
            button6 = new Button();
            button4 = new Button();
            button2 = new Button();
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
          
            // 
            // button1
            // 
            button1.Location = new Point(1067, 104);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 39);
            button1.TabIndex = 64;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(933, 53);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 62;
            label1.Text = "NAME OF THE USER";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1081, 43);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 53);
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
            label2.Location = new Point(297, 53);
            label2.Name = "label2";
            label2.Size = new Size(338, 41);
            label2.TabIndex = 63;
            label2.Text = "ATTENDANCE REPORT";
            // 
            // btnAttendanceReport
            // 
            btnAttendanceReport.BackColor = Color.SteelBlue;
            btnAttendanceReport.FlatAppearance.BorderSize = 0;
            btnAttendanceReport.FlatStyle = FlatStyle.System;
            btnAttendanceReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAttendanceReport.Location = new Point(15, 371);
            btnAttendanceReport.Margin = new Padding(3, 4, 3, 4);
            btnAttendanceReport.Name = "btnAttendanceReport";
            btnAttendanceReport.Size = new Size(223, 64);
            btnAttendanceReport.TabIndex = 6;
            btnAttendanceReport.Text = "Attendance Report";
            btnAttendanceReport.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button3.Location = new Point(14, 103);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(223, 64);
            button3.TabIndex = 5;
            button3.Text = "Student Management";
            button3.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.SteelBlue;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button6.Location = new Point(14, 281);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(223, 64);
            button6.TabIndex = 4;
            button6.Text = "Attendance Log";
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnAttendanceReport_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button4.Location = new Point(14, 192);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(223, 64);
            button4.TabIndex = 2;
            button4.Text = "Subject Allocation";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button2.Location = new Point(13, 13);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(224, 64);
            button2.TabIndex = 0;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = false;
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
            panel1.TabIndex = 60;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(btnAttendanceReport);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button2);
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
            label5.Location = new Point(65, 273);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 59;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(358, 245);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(662, 463);
            dataGridView1.TabIndex = 69;
            // 
            // btnViewSummary
            // 
            btnViewSummary.Location = new Point(934, 173);
            btnViewSummary.Margin = new Padding(3, 4, 3, 4);
            btnViewSummary.Name = "btnViewSummary";
            btnViewSummary.Size = new Size(86, 44);
            btnViewSummary.TabIndex = 68;
            btnViewSummary.Text = "view";
            btnViewSummary.UseVisualStyleBackColor = true;
            // 
            // cmbSemester
            // 
            cmbSemester.FormattingEnabled = true;
            cmbSemester.Items.AddRange(new object[] { "1st Semester\t", "2nd Semester" });
            cmbSemester.Location = new Point(713, 182);
            cmbSemester.Margin = new Padding(3, 4, 3, 4);
            cmbSemester.Name = "cmbSemester";
            cmbSemester.Size = new Size(138, 28);
            cmbSemester.TabIndex = 67;
            cmbSemester.Text = "Semester";
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "Bachelor of Science in Computer Engineering", "Bachelor of Science in Information Technology", "Bachelor of Science in Computer Science", "Bachelor of Multimedia Arts" });
            cmbCourse.Location = new Point(358, 182);
            cmbCourse.Margin = new Padding(3, 4, 3, 4);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(138, 28);
            cmbCourse.TabIndex = 66;
            cmbCourse.Text = "Course";
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cmbSection.Location = new Point(534, 181);
            cmbSection.Margin = new Padding(3, 4, 3, 4);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(138, 28);
            cmbSection.TabIndex = 65;
            cmbSection.Text = "Section";
            // 
            // Attendance_Summary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 859);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Attendance_Summary";
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
        private Button button3;
        private Button button6;
        private Button button4;
        private Button button2;
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