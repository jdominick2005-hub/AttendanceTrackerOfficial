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
            lbl_Attendancedb = new Label();
            SuspendLayout();
            // 
            // lbl_Attendancedb
            // 
            lbl_Attendancedb.BackColor = SystemColors.Highlight;
            lbl_Attendancedb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Attendancedb.Location = new Point(54, 43);
            lbl_Attendancedb.Name = "lbl_Attendancedb";
            lbl_Attendancedb.Size = new Size(206, 31);
            lbl_Attendancedb.TabIndex = 0;
            lbl_Attendancedb.Text = "Attendance Dashboard";
            // 
            // Student_Attendance_Db
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(978, 642);
            Controls.Add(lbl_Attendancedb);
            Name = "Student_Attendance_Db";
            Text = "Student_Attendance_Db";
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Attendancedb;
    }
}