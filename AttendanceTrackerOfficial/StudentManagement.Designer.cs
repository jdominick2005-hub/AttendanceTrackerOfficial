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
            panel1 = new Panel();
            lblHome = new Label();
            label7 = new Label();
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
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.OutlineButton;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(lblHome);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 83);
            panel1.TabIndex = 0;
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHome.Location = new Point(838, 32);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(69, 23);
            lblHome.TabIndex = 1;
            lblHome.Text = "HOME\r\n";
            lblHome.TextAlign = ContentAlignment.TopCenter;
            lblHome.Click += lblHome_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(358, 25);
            label7.Name = "label7";
            label7.Size = new Size(232, 31);
            label7.TabIndex = 0;
            label7.Text = "Student Registration";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 140);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 0;
            label1.Text = "StudentId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(160, 189);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 1;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(160, 239);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 2;
            label3.Text = "Year Level";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(160, 295);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 3;
            label4.Text = "Course";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(160, 347);
            label5.Name = "label5";
            label5.Size = new Size(53, 23);
            label5.TabIndex = 4;
            label5.Text = "Units";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(160, 397);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 5;
            label6.Text = "Classified";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(264, 127);
            txtStudentId.Margin = new Padding(3, 4, 3, 4);
            txtStudentId.Multiline = true;
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(254, 41);
            txtStudentId.TabIndex = 1;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(264, 177);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(254, 40);
            txtFullName.TabIndex = 2;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // txtYearLevel
            // 
            txtYearLevel.Location = new Point(264, 227);
            txtYearLevel.Margin = new Padding(3, 4, 3, 4);
            txtYearLevel.Multiline = true;
            txtYearLevel.Name = "txtYearLevel";
            txtYearLevel.Size = new Size(254, 41);
            txtYearLevel.TabIndex = 3;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(264, 277);
            txtCourse.Margin = new Padding(3, 4, 3, 4);
            txtCourse.Multiline = true;
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(254, 41);
            txtCourse.TabIndex = 4;
            // 
            // txtUnits
            // 
            txtUnits.Location = new Point(264, 328);
            txtUnits.Margin = new Padding(3, 4, 3, 4);
            txtUnits.Multiline = true;
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(254, 41);
            txtUnits.TabIndex = 5;
            // 
            // txtClassified
            // 
            txtClassified.Location = new Point(264, 387);
            txtClassified.Margin = new Padding(3, 4, 3, 4);
            txtClassified.Multiline = true;
            txtClassified.Name = "txtClassified";
            txtClassified.Size = new Size(254, 41);
            txtClassified.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(645, 120);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(110, 52);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit\r\n";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(645, 180);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 52);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(645, 240);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 52);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnShow
            // 
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(645, 300);
            btnShow.Margin = new Padding(3, 4, 3, 4);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(110, 52);
            btnShow.TabIndex = 10;
            btnShow.Text = "Show\r\n";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnView
            // 
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnView.Location = new Point(610, 387);
            btnView.Margin = new Padding(3, 4, 3, 4);
            btnView.Name = "btnView";
            btnView.Size = new Size(195, 48);
            btnView.TabIndex = 11;
            btnView.Text = "View Student Registered";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(135, 491);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(709, 328);
            dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(135, 91);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(409, 363);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(561, 91);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(282, 363);
            button2.TabIndex = 19;
            button2.UseVisualStyleBackColor = false;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 868);
            Controls.Add(dataGridView1);
            Controls.Add(btnView);
            Controls.Add(btnShow);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSubmit);
            Controls.Add(txtClassified);
            Controls.Add(txtUnits);
            Controls.Add(txtCourse);
            Controls.Add(txtYearLevel);
            Controls.Add(txtFullName);
            Controls.Add(txtStudentId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(button2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += Registration_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
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
        private Label label7;
        private Label lblHome;
        private Button button1;
        private Button button2;
    }
}