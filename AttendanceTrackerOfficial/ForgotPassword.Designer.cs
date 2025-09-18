
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            txtname = new TextBox();
            txtnewpassword = new TextBox();
            txtconfirmpassword = new TextBox();
            btnresetpass = new Button();
            lblsignup = new Label();
            lblname = new Label();
            lblnewpass = new Label();
            lblconfirmpass = new Label();
            btncancel = new Button();
            SuspendLayout();
            // 
            // txtname
            // 
            txtname.BackColor = Color.White;
            txtname.BorderStyle = BorderStyle.None;
            txtname.Location = new Point(484, 258);
            txtname.Margin = new Padding(3, 2, 3, 2);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(293, 34);
            txtname.TabIndex = 0;
            // 
            // txtnewpassword
            // 
            txtnewpassword.BackColor = Color.White;
            txtnewpassword.BorderStyle = BorderStyle.None;
            txtnewpassword.Location = new Point(484, 324);
            txtnewpassword.Margin = new Padding(3, 2, 3, 2);
            txtnewpassword.Multiline = true;
            txtnewpassword.Name = "txtnewpassword";
            txtnewpassword.Size = new Size(293, 34);
            txtnewpassword.TabIndex = 1;
            // 
            // txtconfirmpassword
            // 
            txtconfirmpassword.BackColor = Color.White;
            txtconfirmpassword.BorderStyle = BorderStyle.None;
            txtconfirmpassword.Location = new Point(484, 389);
            txtconfirmpassword.Margin = new Padding(3, 2, 3, 2);
            txtconfirmpassword.Multiline = true;
            txtconfirmpassword.Name = "txtconfirmpassword";
            txtconfirmpassword.Size = new Size(293, 34);
            txtconfirmpassword.TabIndex = 2;
            // 
            // btnresetpass
            // 
            btnresetpass.BackColor = Color.DodgerBlue;
            btnresetpass.FlatStyle = FlatStyle.Popup;
            btnresetpass.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnresetpass.ForeColor = Color.White;
            btnresetpass.Location = new Point(543, 469);
            btnresetpass.Name = "btnresetpass";
            btnresetpass.Size = new Size(83, 28);
            btnresetpass.TabIndex = 3;
            btnresetpass.Text = "Reset";
            btnresetpass.UseVisualStyleBackColor = false;
            btnresetpass.Click += btnresetpassword_Click;
            // 
            // lblsignup
            // 
            lblsignup.AutoSize = true;
            lblsignup.BackColor = Color.Transparent;
            lblsignup.Font = new Font("Georgia", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsignup.ForeColor = Color.White;
            lblsignup.Location = new Point(502, 175);
            lblsignup.Name = "lblsignup";
            lblsignup.Size = new Size(260, 41);
            lblsignup.TabIndex = 4;
            lblsignup.Text = "Reset Password";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.BackColor = Color.Transparent;
            lblname.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname.ForeColor = Color.White;
            lblname.Location = new Point(481, 241);
            lblname.Name = "lblname";
            lblname.Size = new Size(44, 17);
            lblname.TabIndex = 5;
            lblname.Text = "Name";
            // 
            // lblnewpass
            // 
            lblnewpass.AutoSize = true;
            lblnewpass.BackColor = Color.Transparent;
            lblnewpass.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnewpass.ForeColor = Color.White;
            lblnewpass.Location = new Point(481, 307);
            lblnewpass.Name = "lblnewpass";
            lblnewpass.Size = new Size(97, 17);
            lblnewpass.TabIndex = 6;
            lblnewpass.Text = "New Password";
            // 
            // lblconfirmpass
            // 
            lblconfirmpass.AutoSize = true;
            lblconfirmpass.BackColor = Color.Transparent;
            lblconfirmpass.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblconfirmpass.ForeColor = Color.White;
            lblconfirmpass.Location = new Point(480, 372);
            lblconfirmpass.Name = "lblconfirmpass";
            lblconfirmpass.Size = new Size(149, 17);
            lblconfirmpass.TabIndex = 7;
            lblconfirmpass.Text = "Confirm New Password";
            // 
            // btncancel
            // 
            btncancel.BackColor = Color.White;
            btncancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncancel.ForeColor = Color.DodgerBlue;
            btncancel.Location = new Point(632, 469);
            btncancel.Margin = new Padding(3, 2, 3, 2);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(83, 28);
            btncancel.TabIndex = 8;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(964, 611);
            Controls.Add(btncancel);
            Controls.Add(lblconfirmpass);
            Controls.Add(lblnewpass);
            Controls.Add(lblname);
            Controls.Add(lblsignup);
            Controls.Add(btnresetpass);
            Controls.Add(txtconfirmpassword);
            Controls.Add(txtnewpassword);
            Controls.Add(txtname);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ForgotPassword";
            Text = "S";
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
        private TextBox txtconfirmpassword;
        private Button btnresetpass;
        private Label lblsignup;
        private Label lblname;
        private Label lblnewpass;
        private Label lblconfirmpass;
        private Button btncancel;
    }
}