namespace AttendanceTrackerOfficial
{
    partial class Assign_Subject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assign_Subject));
            button1 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label2 = new Label();
            button7 = new Button();
            button3 = new Button();
            button6 = new Button();
            button4 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            addsubject = new Button();
            panel2 = new Panel();
            subject = new ComboBox();
            professor = new ComboBox();
            subjectID = new DataGridViewTextBoxColumn();
            subjectname = new DataGridViewTextBoxColumn();
            units = new DataGridViewTextBoxColumn();
            semester = new DataGridViewTextBoxColumn();
            dateAssigned = new DataGridViewTextBoxColumn();
            userID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1058, 104);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 39);
            button1.TabIndex = 58;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(923, 53);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 56;
            label1.Text = "NAME OF THE USER";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1072, 43);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 55;
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
            label2.Location = new Point(288, 53);
            label2.Name = "label2";
            label2.Size = new Size(336, 41);
            label2.TabIndex = 57;
            label2.Text = "SUBJECT ALLOCATION";
            // 
            // button7
            // 
            button7.BackColor = Color.SteelBlue;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button7.Location = new Point(14, 371);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(223, 64);
            button7.TabIndex = 6;
            button7.Text = "Attendance Report";
            button7.UseVisualStyleBackColor = false;
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
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.System;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button4.Location = new Point(15, 192);
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
            panel1.TabIndex = 54;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(button7);
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
            label5.Location = new Point(56, 273);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 53;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { subjectID, subjectname, units, semester, dateAssigned, userID });
            dataGridView1.Location = new Point(262, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(871, 547);
            dataGridView1.TabIndex = 59;
            // 
            // addsubject
            // 
            addsubject.Location = new Point(570, 42);
            addsubject.Name = "addsubject";
            addsubject.Size = new Size(202, 29);
            addsubject.TabIndex = 60;
            addsubject.Text = "AddSubject";
            addsubject.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(professor);
            panel2.Controls.Add(subject);
            panel2.Controls.Add(addsubject);
            panel2.Location = new Point(262, 216);
            panel2.Name = "panel2";
            panel2.Size = new Size(871, 82);
            panel2.TabIndex = 61;
            // 
            // subject
            // 
            subject.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subject.FormattingEnabled = true;
            subject.Location = new Point(309, 42);
            subject.Name = "subject";
            subject.Size = new Size(198, 29);
            subject.TabIndex = 0;
            subject.Text = "subjects";
            // 
            // professor
            // 
            professor.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            professor.FormattingEnabled = true;
            professor.Location = new Point(41, 42);
            professor.Name = "professor";
            professor.Size = new Size(202, 29);
            professor.TabIndex = 61;
            professor.Text = "professor";
            // 
            // subjectID
            // 
            subjectID.HeaderText = "SubjectID";
            subjectID.MinimumWidth = 6;
            subjectID.Name = "subjectID";
            subjectID.Width = 125;
            // 
            // subjectname
            // 
            subjectname.HeaderText = "Subjectname";
            subjectname.MinimumWidth = 6;
            subjectname.Name = "subjectname";
            subjectname.Width = 125;
            // 
            // units
            // 
            units.HeaderText = "Units";
            units.MinimumWidth = 6;
            units.Name = "units";
            units.Width = 125;
            // 
            // semester
            // 
            semester.HeaderText = "Semester";
            semester.MinimumWidth = 6;
            semester.Name = "semester";
            semester.Width = 125;
            // 
            // dateAssigned
            // 
            dateAssigned.HeaderText = "DateAssigned";
            dateAssigned.MinimumWidth = 6;
            dateAssigned.Name = "dateAssigned";
            dateAssigned.Width = 125;
            // 
            // userID
            // 
            userID.HeaderText = "UserID";
            userID.MinimumWidth = 6;
            userID.Name = "userID";
            userID.Width = 125;
            // 
            // Assign_Subject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 859);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Assign_Subject";
            Text = "Assign_Subject";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private PictureBox pictureBox2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label2;
        private Button button7;
        private Button button3;
        private Button button6;
        private Button button4;
        private Button button2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel3;
        private Label label5;
        private DataGridView dataGridView1;
        private Button addsubject;
        private Panel panel2;
        private ComboBox professor;
        private ComboBox subject;
        private DataGridViewTextBoxColumn subjectID;
        private DataGridViewTextBoxColumn subjectname;
        private DataGridViewTextBoxColumn units;
        private DataGridViewTextBoxColumn semester;
        private DataGridViewTextBoxColumn dateAssigned;
        private DataGridViewTextBoxColumn userID;
    }
}