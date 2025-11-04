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
            button1 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label2 = new Label();
            button7 = new Button();
            button3 = new Button();
            button6 = new Button();
            btnSubjectAllocation = new Button();
            button2 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvviewsubject).BeginInit();
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
            // btnSubjectAllocation
            // 
            btnSubjectAllocation.BackColor = Color.SteelBlue;
            btnSubjectAllocation.BackgroundImageLayout = ImageLayout.None;
            btnSubjectAllocation.FlatAppearance.BorderSize = 0;
            btnSubjectAllocation.FlatStyle = FlatStyle.System;
            btnSubjectAllocation.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSubjectAllocation.Location = new Point(10, 192);
            btnSubjectAllocation.Margin = new Padding(3, 4, 3, 4);
            btnSubjectAllocation.Name = "btnSubjectAllocation";
            btnSubjectAllocation.Size = new Size(223, 64);
            btnSubjectAllocation.TabIndex = 2;
            btnSubjectAllocation.Text = "Subject Allocation";
            btnSubjectAllocation.UseVisualStyleBackColor = false;
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
            panel3.Controls.Add(btnSubjectAllocation);
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(262, 216);
            panel2.Name = "panel2";
            panel2.Size = new Size(871, 83);
            panel2.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 31);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 1;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 31);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 0;
            label3.Text = "Teacher:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(262, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(871, 542);
            dataGridView1.TabIndex = 62;
            // 
            // dgvviewsubject
            // 
            dgvviewsubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvviewsubject.Location = new Point(308, 526);
            dgvviewsubject.Name = "dgvviewsubject";
            dgvviewsubject.RowHeadersWidth = 51;
            dgvviewsubject.Size = new Size(810, 319);
            dgvviewsubject.TabIndex = 71;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(447, 436);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 29);
            btndelete.TabIndex = 72;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            // 
            // btnview
            // 
            btnview.Location = new Point(547, 436);
            btnview.Name = "btnview";
            btnview.Size = new Size(94, 29);
            btnview.TabIndex = 73;
            btnview.Text = "View";
            btnview.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(647, 436);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(94, 29);
            btnupdate.TabIndex = 74;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // lblfindsubject
            // 
            lblfindsubject.AutoSize = true;
            lblfindsubject.Location = new Point(288, 491);
            lblfindsubject.Name = "lblfindsubject";
            lblfindsubject.Size = new Size(90, 20);
            lblfindsubject.TabIndex = 75;
            lblfindsubject.Text = "Find Subject";
            // 
            // txtbox
            // 
            txtbox.Location = new Point(394, 484);
            txtbox.Name = "txtbox";
            txtbox.Size = new Size(125, 27);
            txtbox.TabIndex = 76;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(525, 484);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(94, 29);
            btnsearch.TabIndex = 77;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            // 
            // txtsubject
            // 
            txtsubject.Location = new Point(352, 334);
            txtsubject.Name = "txtsubject";
            txtsubject.Size = new Size(125, 27);
            txtsubject.TabIndex = 78;
            txtsubject.TextChanged += txtsubject_TextChanged;
            // 
            // lblsubject
            // 
            lblsubject.AutoSize = true;
            lblsubject.Location = new Point(288, 337);
            lblsubject.Name = "lblsubject";
            lblsubject.Size = new Size(58, 20);
            lblsubject.TabIndex = 79;
            lblsubject.Text = "Subject";
            // 
            // lblschedule
            // 
            lblschedule.AutoSize = true;
            lblschedule.Location = new Point(525, 395);
            lblschedule.Name = "lblschedule";
            lblschedule.Size = new Size(69, 20);
            lblschedule.TabIndex = 80;
            lblschedule.Text = "Schedule";
            // 
            // lblsection
            // 
            lblsection.AutoSize = true;
            lblsection.Location = new Point(288, 392);
            lblsection.Name = "lblsection";
            lblsection.Size = new Size(58, 20);
            lblsection.TabIndex = 81;
            lblsection.Text = "Section";
            // 
            // txtsection
            // 
            txtsection.Location = new Point(352, 385);
            txtsection.Name = "txtsection";
            txtsection.Size = new Size(125, 27);
            txtsection.TabIndex = 82;
            // 
            // txtschedule
            // 
            txtschedule.Location = new Point(600, 392);
            txtschedule.Name = "txtschedule";
            txtschedule.Size = new Size(125, 27);
            txtschedule.TabIndex = 83;
            // 
            // lblyearlevel
            // 
            lblyearlevel.AutoSize = true;
            lblyearlevel.Location = new Point(515, 337);
            lblyearlevel.Name = "lblyearlevel";
            lblyearlevel.Size = new Size(75, 20);
            lblyearlevel.TabIndex = 85;
            lblyearlevel.Text = "Year Level";
            // 
            // txtyearlevel
            // 
            txtyearlevel.Location = new Point(596, 334);
            txtyearlevel.Name = "txtyearlevel";
            txtyearlevel.Size = new Size(125, 27);
            txtyearlevel.TabIndex = 86;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(341, 436);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 29);
            btnadd.TabIndex = 87;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // Assign_Subject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 859);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvviewsubject).EndInit();
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
        private Button btnSubjectAllocation;
        private Button button2;
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