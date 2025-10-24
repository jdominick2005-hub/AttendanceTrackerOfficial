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
            chkbxremember = new CheckBox();
            lnkforgotpass = new LinkLabel();
            lnksignup = new LinkLabel();
            lbldonthaveacc = new Label();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.White;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Location = new Point(376, 244);
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
            btnlogin.BackColor = Color.DodgerBlue;
            btnlogin.BackgroundImageLayout = ImageLayout.None;
            btnlogin.FlatStyle = FlatStyle.Popup;
            btnlogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(439, 433);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(96, 29);
            btnlogin.TabIndex = 2;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = Color.Transparent;
            lblusername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblusername.ForeColor = Color.Black;
            lblusername.Location = new Point(374, 226);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(67, 17);
            lblusername.TabIndex = 3;
            lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.BackColor = Color.Transparent;
            lblpassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpassword.ForeColor = Color.Black;
            lblpassword.Location = new Point(374, 292);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(64, 17);
            lblpassword.TabIndex = 4;
            lblpassword.Text = "Password";
            // 
            // chkbxremember
            // 
            chkbxremember.AutoSize = true;
            chkbxremember.BackColor = Color.Transparent;
            chkbxremember.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkbxremember.Location = new Point(373, 351);
            chkbxremember.Name = "chkbxremember";
            chkbxremember.Size = new Size(107, 17);
            chkbxremember.TabIndex = 6;
            chkbxremember.Text = "Show Password";
            chkbxremember.UseVisualStyleBackColor = false;
            // 
            // lnkforgotpass
            // 
            lnkforgotpass.ActiveLinkColor = Color.Red;
            lnkforgotpass.AutoSize = true;
            lnkforgotpass.BackColor = Color.Transparent;
            lnkforgotpass.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkforgotpass.ForeColor = Color.Black;
            lnkforgotpass.LinkColor = Color.Black;
            lnkforgotpass.Location = new Point(506, 352);
            lnkforgotpass.Name = "lnkforgotpass";
            lnkforgotpass.Size = new Size(100, 13);
            lnkforgotpass.TabIndex = 9;
            lnkforgotpass.TabStop = true;
            lnkforgotpass.Text = "Forgot password?";
            lnkforgotpass.LinkClicked += lnkforgotpass_LinkClicked;
            // 
            // lnksignup
            // 
            lnksignup.ActiveLinkColor = Color.Red;
            lnksignup.AutoSize = true;
            lnksignup.BackColor = Color.Transparent;
            lnksignup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnksignup.ForeColor = Color.Black;
            lnksignup.LinkColor = Color.DodgerBlue;
            lnksignup.Location = new Point(529, 465);
            lnksignup.Name = "lnksignup";
            lnksignup.Size = new Size(48, 15);
            lnksignup.TabIndex = 11;
            lnksignup.TabStop = true;
            lnksignup.Text = "Sign up";
            lnksignup.LinkClicked += lnksignup_LinkClicked;
            // 
            // lbldonthaveacc
            // 
            lbldonthaveacc.AutoSize = true;
            lbldonthaveacc.BackColor = Color.Transparent;
            lbldonthaveacc.Location = new Point(401, 465);
            lbldonthaveacc.Name = "lbldonthaveacc";
            lbldonthaveacc.Size = new Size(131, 15);
            lbldonthaveacc.TabIndex = 12;
            lbldonthaveacc.Text = "Don't have an account?";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(964, 611);
            Controls.Add(lbldonthaveacc);
            Controls.Add(lnksignup);
            Controls.Add(lnkforgotpass);
            Controls.Add(chkbxremember);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "LoginPage";
            Text = "LoginPage";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnlogin;
        private Label lblusername;
        private Label lblpassword;
        private CheckBox chkbxremember;
        private LinkLabel lnkforgotpass;
        private LinkLabel lnksignup;
        private Label lbldonthaveacc;
    }
}