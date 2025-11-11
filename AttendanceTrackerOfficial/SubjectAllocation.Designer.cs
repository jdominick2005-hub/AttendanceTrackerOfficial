namespace AttendanceTrackerOfficial
{
    partial class AssignSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignSubject));
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
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            dgvviewsubject = new DataGridView();
            btndelete = new Button();
            btnview = new Button();
            btnupdate = new Button();
            lblfindsubject = new Label();
            txtbox = new TextBox();
            btnsearch = new Button();
            txtsubject = new TextBox();
            lblsubject = new Label();
            lblschedule = new Label();
            lblsection = new Label();
            txtsection = new TextBox();
            txtschedule = new TextBox();
            lblyearlevel = new Label();
            txtyearlevel = new TextBox();
            btnadd = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvviewsubject).BeginInit();
            SuspendLayout();
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
            label2.Location = new Point(261, 61);
            label2.Name = "label2";
            label2.Size = new Size(125, 32);
            label2.TabIndex = 57;
            label2.Text = "SUBJECTS";
            // 
            // btnAttendanceReport
            // 
            btnAttendanceReport.BackColor = Color.SteelBlue;
            btnAttendanceReport.FlatAppearance.BorderSize = 0;
            btnAttendanceReport.FlatStyle = FlatStyle.Flat;
            btnAttendanceReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAttendanceReport.Location = new Point(12, 278);
            btnAttendanceReport.Name = "btnAttendanceReport";
            btnAttendanceReport.Size = new Size(223, 56);
            btnAttendanceReport.TabIndex = 6;
            btnAttendanceReport.Text = "Professors";
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
            btnStudentManagement.Text = "Management";
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
            btnattendancelog.Text = "Users";
            btnattendancelog.UseVisualStyleBackColor = false;
            btnattendancelog.Click += btnattendancelog_Click_1;
            // 
            // btnSubjectAllocation
            // 
            btnSubjectAllocation.BackColor = Color.SteelBlue;
            btnSubjectAllocation.BackgroundImageLayout = ImageLayout.None;
            btnSubjectAllocation.FlatAppearance.BorderSize = 0;
            btnSubjectAllocation.FlatStyle = FlatStyle.System;
            btnSubjectAllocation.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSubjectAllocation.Location = new Point(13, 144);
            btnSubjectAllocation.Name = "btnSubjectAllocation";
            btnSubjectAllocation.Size = new Size(223, 56);
            btnSubjectAllocation.TabIndex = 2;
            btnSubjectAllocation.Text = "Subjects";
            btnSubjectAllocation.UseVisualStyleBackColor = false;
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
            btnDashboard.Text = "Home";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click_1;
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
            panel1.TabIndex = 54;
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
            label5.Location = new Point(49, 205);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 53;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(267, 100);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(710, 62);
            panel2.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 25);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 1;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 25);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 0;
            label3.Text = "Teacher:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(267, 172);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(710, 448);
            dataGridView1.TabIndex = 62;
            // 
            // dgvviewsubject
            // 
            dgvviewsubject.BackgroundColor = Color.White;
            dgvviewsubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvviewsubject.Location = new Point(307, 357);
            dgvviewsubject.Margin = new Padding(3, 2, 3, 2);
            dgvviewsubject.Name = "dgvviewsubject";
            dgvviewsubject.RowHeadersWidth = 51;
            dgvviewsubject.Size = new Size(636, 249);
            dgvviewsubject.TabIndex = 71;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(400, 268);
            btndelete.Margin = new Padding(3, 2, 3, 2);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(73, 22);
            btndelete.TabIndex = 72;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            // 
            // btnview
            // 
            btnview.Location = new Point(488, 268);
            btnview.Margin = new Padding(3, 2, 3, 2);
            btnview.Name = "btnview";
            btnview.Size = new Size(73, 22);
            btnview.TabIndex = 73;
            btnview.Text = "View";
            btnview.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(575, 268);
            btnupdate.Margin = new Padding(3, 2, 3, 2);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(73, 22);
            btnupdate.TabIndex = 74;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // lblfindsubject
            // 
            lblfindsubject.AutoSize = true;
            lblfindsubject.Location = new Point(302, 325);
            lblfindsubject.Name = "lblfindsubject";
            lblfindsubject.Size = new Size(72, 15);
            lblfindsubject.TabIndex = 75;
            lblfindsubject.Text = "Find Subject";
            // 
            // txtbox
            // 
            txtbox.Location = new Point(380, 320);
            txtbox.Margin = new Padding(3, 2, 3, 2);
            txtbox.Name = "txtbox";
            txtbox.Size = new Size(151, 23);
            txtbox.TabIndex = 76;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(537, 321);
            btnsearch.Margin = new Padding(3, 2, 3, 2);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(82, 22);
            btnsearch.TabIndex = 77;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            // 
            // txtsubject
            // 
            txtsubject.Location = new Point(359, 201);
            txtsubject.Margin = new Padding(3, 2, 3, 2);
            txtsubject.Name = "txtsubject";
            txtsubject.Size = new Size(166, 23);
            txtsubject.TabIndex = 78;
            txtsubject.TextChanged += txtsubject_TextChanged;
            // 
            // lblsubject
            // 
            lblsubject.AutoSize = true;
            lblsubject.Location = new Point(307, 205);
            lblsubject.Name = "lblsubject";
            lblsubject.Size = new Size(46, 15);
            lblsubject.TabIndex = 79;
            lblsubject.Text = "Subject";
            // 
            // lblschedule
            // 
            lblschedule.AutoSize = true;
            lblschedule.Location = new Point(548, 241);
            lblschedule.Name = "lblschedule";
            lblschedule.Size = new Size(55, 15);
            lblschedule.TabIndex = 80;
            lblschedule.Text = "Schedule";
            // 
            // lblsection
            // 
            lblsection.AutoSize = true;
            lblsection.Location = new Point(307, 241);
            lblsection.Name = "lblsection";
            lblsection.Size = new Size(46, 15);
            lblsection.TabIndex = 81;
            lblsection.Text = "Section";
            // 
            // txtsection
            // 
            txtsection.Location = new Point(359, 238);
            txtsection.Margin = new Padding(3, 2, 3, 2);
            txtsection.Name = "txtsection";
            txtsection.Size = new Size(166, 23);
            txtsection.TabIndex = 82;
            // 
            // txtschedule
            // 
            txtschedule.Location = new Point(613, 238);
            txtschedule.Margin = new Padding(3, 2, 3, 2);
            txtschedule.Name = "txtschedule";
            txtschedule.Size = new Size(175, 23);
            txtschedule.TabIndex = 83;
            // 
            // lblyearlevel
            // 
            lblyearlevel.AutoSize = true;
            lblyearlevel.Location = new Point(548, 205);
            lblyearlevel.Name = "lblyearlevel";
            lblyearlevel.Size = new Size(59, 15);
            lblyearlevel.TabIndex = 85;
            lblyearlevel.Text = "Year Level";
            // 
            // txtyearlevel
            // 
            txtyearlevel.Location = new Point(613, 201);
            txtyearlevel.Margin = new Padding(3, 2, 3, 2);
            txtyearlevel.Name = "txtyearlevel";
            txtyearlevel.Size = new Size(175, 23);
            txtyearlevel.TabIndex = 86;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(307, 268);
            btnadd.Margin = new Padding(3, 2, 3, 2);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(73, 22);
            btnadd.TabIndex = 87;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // AssignSubject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 644);
            Controls.Add(btnadd);
            Controls.Add(txtyearlevel);
            Controls.Add(lblyearlevel);
            Controls.Add(txtschedule);
            Controls.Add(txtsection);
            Controls.Add(lblsection);
            Controls.Add(lblschedule);
            Controls.Add(lblsubject);
            Controls.Add(txtsubject);
            Controls.Add(btnsearch);
            Controls.Add(txtbox);
            Controls.Add(lblfindsubject);
            Controls.Add(btnupdate);
            Controls.Add(btnview);
            Controls.Add(btndelete);
            Controls.Add(dgvviewsubject);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AssignSubject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assign_Subject";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvviewsubject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridView dgvviewsubject;
        private Button btndelete;
        private Label label3;
        private Label label4;
        private Button btnview;
        private Button btnupdate;
        private Label lblfindsubject;
        private TextBox txtbox;
        private Button btnsearch;
        private TextBox txtsubject;
        private Label lblsubject;
        private Label lblschedule;
        private Label lblsection;
        private TextBox txtsection;
        private TextBox txtschedule;
        private Label lblyearlevel;
        private TextBox txtyearlevel;
        private Button btnadd;
    }
}