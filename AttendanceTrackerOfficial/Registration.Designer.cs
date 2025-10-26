namespace AttendanceTrackerOfficial
{
    partial class Registration
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
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 62);
            panel1.TabIndex = 0;
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHome.Location = new Point(733, 24);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(55, 18);
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
            label7.Location = new Point(313, 19);
            label7.Name = "label7";
            label7.Size = new Size(187, 25);
            label7.TabIndex = 0;
            label7.Text = "Student Registration";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 105);
            label1.Name = "label1";
            label1.Size = new Size(73, 18);
            label1.TabIndex = 0;
            label1.Text = "StudentId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(140, 142);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 1;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(140, 179);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 2;
            label3.Text = "Year Level";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(140, 221);
            label4.Name = "label4";
            label4.Size = new Size(59, 18);
            label4.TabIndex = 3;
            label4.Text = "Course";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(140, 260);
            label5.Name = "label5";
            label5.Size = new Size(43, 18);
            label5.TabIndex = 4;
            label5.Text = "Units";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(140, 298);
            label6.Name = "label6";
            label6.Size = new Size(78, 18);
            label6.TabIndex = 5;
            label6.Text = "Classified";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(231, 135);
            txtStudentId.Multiline = true;
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(223, 32);
            txtStudentId.TabIndex = 6;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(231, 171);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(223, 31);
            txtFullName.TabIndex = 7;
            // 
            // txtYearLevel
            // 
            txtYearLevel.Location = new Point(231, 208);
            txtYearLevel.Multiline = true;
            txtYearLevel.Name = "txtYearLevel";
            txtYearLevel.Size = new Size(223, 32);
            txtYearLevel.TabIndex = 8;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(231, 284);
            txtCourse.Multiline = true;
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(223, 32);
            txtCourse.TabIndex = 9;
            // 
            // txtUnits
            // 
            txtUnits.Location = new Point(231, 246);
            txtUnits.Multiline = true;
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(223, 32);
            txtUnits.TabIndex = 10;
            // 
            // txtClassified
            // 
            txtClassified.Location = new Point(231, 97);
            txtClassified.Multiline = true;
            txtClassified.Name = "txtClassified";
            txtClassified.Size = new Size(223, 32);
            txtClassified.TabIndex = 11;
            // 
            // btnSubmit
            // 
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(564, 90);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(96, 39);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit\r\n";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(564, 135);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 39);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(564, 180);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 39);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnShow
            // 
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(564, 225);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(96, 39);
            btnShow.TabIndex = 15;
            btnShow.Text = "Show\r\n";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnView
            // 
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnView.Location = new Point(534, 290);
            btnView.Name = "btnView";
            btnView.Size = new Size(171, 36);
            btnView.TabIndex = 16;
            btnView.Text = "View Student Registered";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(118, 368);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(620, 246);
            dataGridView1.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(118, 68);
            button1.Name = "button1";
            button1.Size = new Size(358, 272);
            button1.TabIndex = 18;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(491, 68);
            button2.Name = "button2";
            button2.Size = new Size(247, 272);
            button2.TabIndex = 19;
            button2.UseVisualStyleBackColor = false;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 651);
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
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
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