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
            label5 = new Label();
            label18 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel3 = new Panel();
            button7 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 205);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 15;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Silver;
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label18.Location = new Point(1057, 26);
            label18.Name = "label18";
            label18.Size = new Size(57, 20);
            label18.TabIndex = 34;
            label18.Text = "HOME";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 729);
            panel1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(-2, 186);
            panel4.Name = "panel4";
            panel4.Size = new Size(13, 67);
            panel4.TabIndex = 40;
            panel4.Paint += panel4_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(11, 183);
            panel3.Name = "panel3";
            panel3.Size = new Size(196, 545);
            panel3.TabIndex = 1;
            // 
            // button7
            // 
            button7.BackColor = Color.SteelBlue;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(0, 338);
            button7.Name = "button7";
            button7.Size = new Size(195, 67);
            button7.TabIndex = 6;
            button7.Text = "Attendance Summary";
            button7.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(0, 70);
            button3.Name = "button3";
            button3.Size = new Size(195, 67);
            button3.TabIndex = 5;
            button3.Text = "Student Registration";
            button3.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.SteelBlue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(0, 271);
            button6.Name = "button6";
            button6.Size = new Size(195, 67);
            button6.TabIndex = 4;
            button6.Text = "Daily Attendance";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.SteelBlue;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(0, 204);
            button5.Name = "button5";
            button5.Size = new Size(195, 67);
            button5.TabIndex = 3;
            button5.Text = "Taking Attendance";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(0, 137);
            button4.Name = "button4";
            button4.Size = new Size(195, 67);
            button4.TabIndex = 2;
            button4.Text = "Assign Subject";
            button4.UseVisualStyleBackColor = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(929, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(799, 40);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 37;
            label1.Text = "NAME OF THE USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(273, 52);
            label2.Name = "label2";
            label2.Size = new Size(164, 32);
            label2.TabIndex = 38;
            label2.Text = "DASHBOARD";
            // 
            // button1
            // 
            button1.Location = new Point(917, 78);
            button1.Name = "button1";
            button1.Size = new Size(66, 29);
            button1.TabIndex = 39;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 3);
            button2.Name = "button2";
            button2.Size = new Size(195, 67);
            button2.TabIndex = 0;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = false;
            // 
            // Student_Attendance_Db
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 729);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label18);
            Controls.Add(label5);
            Name = "Student_Attendance_Db";
            Text = "Student_Attendance_Db";
            Load += Student_Attendance_Db_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label18;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel3;
        private Panel panel4;
        private Button button5;
        private Button button4;
        private Button button6;
        private Button button3;
        private Button button7;
        private Button button2;
    }
}