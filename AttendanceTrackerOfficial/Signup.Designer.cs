namespace AttendanceTrackerOfficial
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            lblalrhaveacc = new Label();
            signup_btn = new Button();
            label3 = new Label();
            signup_email = new Label();
            label1 = new Label();
            signup_password = new TextBox();
            signup_username = new TextBox();
            textBox1 = new TextBox();
            lnklogin = new LinkLabel();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblalrhaveacc
            // 
            lblalrhaveacc.AutoSize = true;
            lblalrhaveacc.BackColor = Color.Transparent;
            lblalrhaveacc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblalrhaveacc.ForeColor = Color.White;
            lblalrhaveacc.Location = new Point(543, 488);
            lblalrhaveacc.Name = "lblalrhaveacc";
            lblalrhaveacc.Size = new Size(142, 15);
            lblalrhaveacc.TabIndex = 12;
            lblalrhaveacc.Text = "Already have an account?";
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.DodgerBlue;
            signup_btn.FlatStyle = FlatStyle.Popup;
            signup_btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_btn.ForeColor = Color.White;
            signup_btn.Location = new Point(593, 456);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(75, 29);
            signup_btn.TabIndex = 9;
            signup_btn.Text = "Submit";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(481, 304);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 5;
            label3.Text = "Username:";
            // 
            // signup_email
            // 
            signup_email.AutoSize = true;
            signup_email.BackColor = Color.Transparent;
            signup_email.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_email.ForeColor = Color.White;
            signup_email.Location = new Point(481, 234);
            signup_email.Name = "signup_email";
            signup_email.Size = new Size(47, 17);
            signup_email.TabIndex = 4;
            signup_email.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(550, 173);
            label1.Name = "label1";
            label1.Size = new Size(159, 41);
            label1.TabIndex = 3;
            label1.Text = "SIGN UP";
            // 
            // signup_password
            // 
            signup_password.Location = new Point(483, 389);
            signup_password.Multiline = true;
            signup_password.Name = "signup_password";
            signup_password.Size = new Size(295, 34);
            signup_password.TabIndex = 2;
            // 
            // signup_username
            // 
            signup_username.Location = new Point(483, 321);
            signup_username.Multiline = true;
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(295, 34);
            signup_username.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(483, 251);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 34);
            textBox1.TabIndex = 0;
            // 
            // lnklogin
            // 
            lnklogin.AutoSize = true;
            lnklogin.BackColor = Color.Transparent;
            lnklogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnklogin.LinkColor = Color.SkyBlue;
            lnklogin.Location = new Point(682, 488);
            lnklogin.Name = "lnklogin";
            lnklogin.Size = new Size(37, 15);
            lnklogin.TabIndex = 11;
            lnklogin.TabStop = true;
            lnklogin.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(481, 372);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 13;
            label2.Text = "Password:";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(964, 611);
            Controls.Add(label2);
            Controls.Add(lnklogin);
            Controls.Add(lblalrhaveacc);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(signup_btn);
            Controls.Add(signup_username);
            Controls.Add(signup_password);
            Controls.Add(signup_email);
            Controls.Add(label3);
            Name = "Signup";
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label signup_email;
        private Label label1;
        private TextBox signup_password;
        private TextBox signup_username;
        private TextBox textBox1;
        private Label label3;
        private Button signup_btn;
        private Label lblalrhaveacc;
        private LinkLabel lnklogin;
        private Label label2;
    }
}