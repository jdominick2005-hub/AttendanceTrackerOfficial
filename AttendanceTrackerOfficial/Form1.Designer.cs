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
            panel1 = new Panel();
            signup_ = new Label();
            label5 = new Label();
            signup_btn = new Button();
            signup_forgotpass = new LinkLabel();
            signup_showpass = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            signup_email = new Label();
            label1 = new Label();
            signup_password = new TextBox();
            signup_username = new TextBox();
            textBox1 = new TextBox();
            signup_loginHere = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(signup_loginHere);
            panel1.Controls.Add(signup_);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(signup_btn);
            panel1.Controls.Add(signup_forgotpass);
            panel1.Controls.Add(signup_showpass);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(signup_email);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(signup_password);
            panel1.Controls.Add(signup_username);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(230, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 379);
            panel1.TabIndex = 0;
            // 
            // signup_
            // 
            signup_.AutoSize = true;
            signup_.Location = new Point(62, 336);
            signup_.Name = "signup_";
            signup_.Size = new Size(142, 15);
            signup_.TabIndex = 12;
            signup_.Text = "Already have an account?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 336);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 10;
            // 
            // signup_btn
            // 
            signup_btn.Location = new Point(129, 301);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(75, 23);
            signup_btn.TabIndex = 9;
            signup_btn.Text = "Sign Up";
            signup_btn.UseVisualStyleBackColor = true;
            signup_btn.Click += button1_Click;
            // 
            // signup_forgotpass
            // 
            signup_forgotpass.AutoSize = true;
            signup_forgotpass.Location = new Point(186, 259);
            signup_forgotpass.Name = "signup_forgotpass";
            signup_forgotpass.Size = new Size(100, 15);
            signup_forgotpass.TabIndex = 8;
            signup_forgotpass.TabStop = true;
            signup_forgotpass.Text = "Forgot Password?";
            // 
            // signup_showpass
            // 
            signup_showpass.AutoSize = true;
            signup_showpass.Location = new Point(38, 258);
            signup_showpass.Name = "signup_showpass";
            signup_showpass.Size = new Size(108, 19);
            signup_showpass.TabIndex = 7;
            signup_showpass.Text = "Show Password";
            signup_showpass.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 201);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Password:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 135);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "Username:";
            // 
            // signup_email
            // 
            signup_email.AutoSize = true;
            signup_email.Location = new Point(38, 71);
            signup_email.Name = "signup_email";
            signup_email.Size = new Size(84, 15);
            signup_email.TabIndex = 4;
            signup_email.Text = "Email Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 28);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "Get Started";
            // 
            // signup_password
            // 
            signup_password.Location = new Point(38, 219);
            signup_password.Multiline = true;
            signup_password.Name = "signup_password";
            signup_password.Size = new Size(248, 33);
            signup_password.TabIndex = 2;
            // 
            // signup_username
            // 
            signup_username.Location = new Point(38, 153);
            signup_username.Multiline = true;
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(248, 33);
            signup_username.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 89);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 33);
            textBox1.TabIndex = 0;
            // 
            // signup_loginHere
            // 
            signup_loginHere.AutoSize = true;
            signup_loginHere.Location = new Point(210, 336);
            signup_loginHere.Name = "signup_loginHere";
            signup_loginHere.Size = new Size(65, 15);
            signup_loginHere.TabIndex = 14;
            signup_loginHere.Text = "Login Here";
            signup_loginHere.Click += signup_loginHere_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Signup";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label signup_email;
        private Label label1;
        private TextBox signup_password;
        private TextBox signup_username;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private LinkLabel signup_forgotpass;
        private CheckBox signup_showpass;
        private Label label5;
        private Button signup_btn;
        private Label signup_;
        private Label signup_loginHere;
    }
}