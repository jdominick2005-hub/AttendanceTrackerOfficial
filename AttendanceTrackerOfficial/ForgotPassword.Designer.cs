
using Microsoft.Data.SqlClient;

namespace AttendanceTrackerOfficial
{
    partial class ForgotPassword
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
            txtname = new TextBox();
            txtnewpassword = new TextBox();
            txtcurrentpassword = new TextBox();
            btnresetpass = new Button();
            SuspendLayout();
            // 
            // txtname
            // 
            txtname.Location = new Point(125, 163);
            txtname.Name = "txtname";
            txtname.Size = new Size(359, 27);
            txtname.TabIndex = 0;
            // 
            // txtnewpassword
            // 
            txtnewpassword.Location = new Point(125, 206);
            txtnewpassword.Name = "txtnewpassword";
            txtnewpassword.Size = new Size(359, 27);
            txtnewpassword.TabIndex = 1;
            // 
            // txtcurrentpassword
            // 
            txtcurrentpassword.Location = new Point(125, 251);
            txtcurrentpassword.Name = "txtcurrentpassword";
            txtcurrentpassword.Size = new Size(359, 27);
            txtcurrentpassword.TabIndex = 2;
            // 
            // btnresetpass
            // 
            btnresetpass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnresetpass.Location = new Point(122, 303);
            btnresetpass.Name = "btnresetpass";
            btnresetpass.Size = new Size(194, 48);
            btnresetpass.TabIndex = 3;
            btnresetpass.Text = "Reset Password";
            btnresetpass.UseVisualStyleBackColor = true;
            btnresetpass.Click += btnresetpass_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(597, 457);
            Controls.Add(btnresetpass);
            Controls.Add(txtcurrentpassword);
            Controls.Add(txtnewpassword);
            Controls.Add(txtname);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnresetpassword_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

       

        #endregion

        private TextBox txtname;
        private TextBox txtnewpassword;
        private TextBox txtcurrentpassword;
        private Button btnresetpass;
    }
}