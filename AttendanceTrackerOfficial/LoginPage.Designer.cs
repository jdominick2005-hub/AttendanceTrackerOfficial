namespace AttendanceTrackerOfficial
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            txtusername = new TextBox();
            txtpassword = new TextBox();
            btnlogin = new Button();
            lblusername = new Label();
            lblpassword = new Label();
            lbldonthaveacc = new Label();
            chkbxremember = new CheckBox();
            lnkforgotpass = new LinkLabel();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.White;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Location = new Point(430, 320);
            txtusername.Margin = new Padding(3, 4, 3, 4);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(263, 47);
            txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.White;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Location = new Point(427, 413);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(263, 47);
            txtpassword.TabIndex = 1;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.CornflowerBlue;
            btnlogin.BackgroundImageLayout = ImageLayout.None;
            btnlogin.ForeColor = SystemColors.ActiveCaptionText;
            btnlogin.Location = new Point(487, 548);
            btnlogin.Margin = new Padding(3, 4, 3, 4);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(147, 68);
            btnlogin.TabIndex = 2;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = Color.Transparent;
            lblusername.Location = new Point(427, 296);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(75, 20);
            lblusername.TabIndex = 3;
            lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.BackColor = Color.Transparent;
            lblpassword.Location = new Point(427, 389);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(70, 20);
            lblpassword.TabIndex = 4;
            lblpassword.Text = "Password";
            // 
            // lbldonthaveacc
            // 
            lbldonthaveacc.AutoSize = true;
            lbldonthaveacc.BackColor = Color.Transparent;
            lbldonthaveacc.Location = new Point(457, 620);
            lbldonthaveacc.Name = "lbldonthaveacc";
            lbldonthaveacc.Size = new Size(163, 20);
            lbldonthaveacc.TabIndex = 5;
            lbldonthaveacc.Text = "Don't have an account?";
            // 
            // chkbxremember
            // 
            chkbxremember.AutoSize = true;
            chkbxremember.BackColor = Color.Transparent;
            chkbxremember.Location = new Point(426, 468);
            chkbxremember.Margin = new Padding(3, 4, 3, 4);
            chkbxremember.Name = "chkbxremember";
            chkbxremember.Size = new Size(136, 24);
            chkbxremember.TabIndex = 6;
            chkbxremember.Text = "Remember Me?";
            chkbxremember.UseVisualStyleBackColor = false;
            // 
            // lnkforgotpass
            // 
            lnkforgotpass.ActiveLinkColor = Color.Red;
            lnkforgotpass.AutoSize = true;
            lnkforgotpass.BackColor = Color.Transparent;
            lnkforgotpass.LinkColor = Color.Black;
            lnkforgotpass.Location = new Point(578, 469);
            lnkforgotpass.Name = "lnkforgotpass";
            lnkforgotpass.Size = new Size(127, 20);
            lnkforgotpass.TabIndex = 9;
            lnkforgotpass.TabStop = true;
            lnkforgotpass.Text = "Forgot password?";
            lnkforgotpass.LinkClicked += lnkforgotpass_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(614, 620);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 20);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1118, 856);
            Controls.Add(linkLabel1);
            Controls.Add(lnkforgotpass);
            Controls.Add(chkbxremember);
            Controls.Add(lbldonthaveacc);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginPage";
            Text = "LoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnlogin;
        private Label lblusername;
        private Label lblpassword;
        private Label lbldonthaveacc;
        private CheckBox chkbxremember;
        private LinkLabel lnkforgotpass;
        private LinkLabel linkLabel1;
    }
}