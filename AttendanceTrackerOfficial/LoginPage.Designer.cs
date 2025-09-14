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
            pbtransparentbox = new PictureBox();
            pbcoilogo = new PictureBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pbtransparentbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbcoilogo).BeginInit();
            SuspendLayout();
            // 
            // pbtransparentbox
            // 
            pbtransparentbox.BackColor = SystemColors.ActiveBorder;
            pbtransparentbox.Location = new Point(361, 136);
            pbtransparentbox.Name = "pbtransparentbox";
            pbtransparentbox.Size = new Size(333, 450);
            pbtransparentbox.TabIndex = 0;
            pbtransparentbox.TabStop = false;
            // 
            // pbcoilogo
            // 
            pbcoilogo.BackColor = Color.Transparent;
            pbcoilogo.Image = (Image)resources.GetObject("pbcoilogo.Image");
            pbcoilogo.Location = new Point(424, 21);
            pbcoilogo.Name = "pbcoilogo";
            pbcoilogo.Size = new Size(213, 198);
            pbcoilogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbcoilogo.TabIndex = 1;
            pbcoilogo.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ActiveBorder;
            checkBox1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(399, 391);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(111, 20);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = SystemColors.Control;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(482, 463);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 3;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = SystemColors.ActiveBorder;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(568, 505);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(49, 15);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Register";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(399, 242);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(399, 318);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Location = new Point(440, 505);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 8;
            label3.Text = "Don't have an account?";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(399, 266);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 42);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(399, 342);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 42);
            textBox2.TabIndex = 10;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.ActiveBorder;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(556, 393);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1022, 659);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(pbcoilogo);
            Controls.Add(pbtransparentbox);
            Enabled = false;
            Name = "LoginPage";
            Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)pbtransparentbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbcoilogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbtransparentbox;
        private PictureBox pbcoilogo;
        private CheckBox checkBox1;
        private Button button1;
        private LinkLabel linkLabel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
    }
}