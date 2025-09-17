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
            txtusername.Location = new Point(376, 240);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(230, 35);
            txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.White;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Location = new Point(374, 310);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(230, 35);
            txtpassword.TabIndex = 1;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.CornflowerBlue;
            btnlogin.BackgroundImageLayout = ImageLayout.None;
            btnlogin.ForeColor = SystemColors.ActiveCaptionText;
            btnlogin.Location = new Point(426, 411);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(129, 51);
            btnlogin.TabIndex = 2;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = Color.Transparent;
            lblusername.Location = new Point(374, 222);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(60, 15);
            lblusername.TabIndex = 3;
            lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.BackColor = Color.Transparent;
            lblpassword.Location = new Point(374, 292);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(57, 15);
            lblpassword.TabIndex = 4;
            lblpassword.Text = "Password";
            // 
            // lbldonthaveacc
            // 
            lbldonthaveacc.AutoSize = true;
            lbldonthaveacc.BackColor = Color.Transparent;
            lbldonthaveacc.Location = new Point(400, 465);
            lbldonthaveacc.Name = "lbldonthaveacc";
            lbldonthaveacc.Size = new Size(131, 15);
            lbldonthaveacc.TabIndex = 5;
            lbldonthaveacc.Text = "Don't have an account?";
            // 
            // chkbxremember
            // 
            chkbxremember.AutoSize = true;
            chkbxremember.BackColor = Color.Transparent;
            chkbxremember.Location = new Point(373, 351);
            chkbxremember.Name = "chkbxremember";
            chkbxremember.Size = new Size(109, 19);
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
            lnkforgotpass.Location = new Point(506, 352);
            lnkforgotpass.Name = "lnkforgotpass";
            lnkforgotpass.Size = new Size(100, 15);
            lnkforgotpass.TabIndex = 9;
            lnkforgotpass.TabStop = true;
            lnkforgotpass.Text = "Forgot password?";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(537, 465);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(47, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(978, 642);
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