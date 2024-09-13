namespace School_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginErrorMsg = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.loginBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.passwordInput = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.usernameInput = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tutorBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.adminBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.forgotPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.loginErrorMsg);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.loginBtn);
            this.panel2.Controls.Add(this.passwordInput);
            this.panel2.Controls.Add(this.usernameInput);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.forgotPass);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(693, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1211, 1041);
            this.panel2.TabIndex = 1;
            // 
            // loginErrorMsg
            // 
            this.loginErrorMsg.BackColor = System.Drawing.SystemColors.MenuText;
            this.loginErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.loginErrorMsg.Location = new System.Drawing.Point(348, 116);
            this.loginErrorMsg.Name = "loginErrorMsg";
            this.loginErrorMsg.Size = new System.Drawing.Size(532, 33);
            this.loginErrorMsg.TabIndex = 8;
            this.loginErrorMsg.Text = "hello";
            this.loginErrorMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.minimizeBtn);
            this.panel3.Controls.Add(this.closeBtn);
            this.panel3.Location = new System.Drawing.Point(721, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 59);
            this.panel3.TabIndex = 7;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.Location = new System.Drawing.Point(338, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(70, 59);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(408, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(70, 59);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginBtn.BackColor = System.Drawing.Color.Cyan;
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBtn.BorderRadius = 7;
            this.loginBtn.ButtonText = "LOGIN";
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.DisabledColor = System.Drawing.Color.Gray;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.loginBtn.Iconimage = null;
            this.loginBtn.Iconimage_right = null;
            this.loginBtn.Iconimage_right_Selected = null;
            this.loginBtn.Iconimage_Selected = null;
            this.loginBtn.IconMarginLeft = 0;
            this.loginBtn.IconMarginRight = 0;
            this.loginBtn.IconRightVisible = true;
            this.loginBtn.IconRightZoom = 0D;
            this.loginBtn.IconVisible = true;
            this.loginBtn.IconZoom = 90D;
            this.loginBtn.IsTab = false;
            this.loginBtn.Location = new System.Drawing.Point(348, 727);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Normalcolor = System.Drawing.Color.Cyan;
            this.loginBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.loginBtn.selected = false;
            this.loginBtn.Size = new System.Drawing.Size(551, 66);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBtn.Textcolor = System.Drawing.Color.Black;
            this.loginBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.BorderColorFocused = System.Drawing.Color.Blue;
            this.passwordInput.BorderColorIdle = System.Drawing.Color.Aqua;
            this.passwordInput.BorderColorMouseHover = System.Drawing.Color.White;
            this.passwordInput.BorderThickness = 2;
            this.passwordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordInput.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.ForeColor = System.Drawing.Color.Aqua;
            this.passwordInput.isPassword = true;
            this.passwordInput.Location = new System.Drawing.Point(348, 615);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(551, 66);
            this.passwordInput.TabIndex = 5;
            this.passwordInput.Text = "PASSWORD";
            this.passwordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernameInput
            // 
            this.usernameInput.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.usernameInput.BorderColorIdle = System.Drawing.Color.Aqua;
            this.usernameInput.BorderColorMouseHover = System.Drawing.Color.White;
            this.usernameInput.BorderThickness = 2;
            this.usernameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameInput.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.ForeColor = System.Drawing.Color.Aqua;
            this.usernameInput.isPassword = false;
            this.usernameInput.Location = new System.Drawing.Point(348, 504);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(551, 66);
            this.usernameInput.TabIndex = 4;
            this.usernameInput.Text = "USERNAME";
            this.usernameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tutorBtn);
            this.panel1.Controls.Add(this.adminBtn);
            this.panel1.Location = new System.Drawing.Point(348, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 100);
            this.panel1.TabIndex = 3;
            // 
            // tutorBtn
            // 
            this.tutorBtn.Activecolor = System.Drawing.Color.Cyan;
            this.tutorBtn.BackColor = System.Drawing.Color.Gray;
            this.tutorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tutorBtn.BorderRadius = 7;
            this.tutorBtn.ButtonText = "TUTOR";
            this.tutorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tutorBtn.DisabledColor = System.Drawing.Color.Gray;
            this.tutorBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.tutorBtn.Iconimage = null;
            this.tutorBtn.Iconimage_right = null;
            this.tutorBtn.Iconimage_right_Selected = null;
            this.tutorBtn.Iconimage_Selected = null;
            this.tutorBtn.IconMarginLeft = 0;
            this.tutorBtn.IconMarginRight = 0;
            this.tutorBtn.IconRightVisible = true;
            this.tutorBtn.IconRightZoom = 0D;
            this.tutorBtn.IconVisible = true;
            this.tutorBtn.IconZoom = 90D;
            this.tutorBtn.IsTab = false;
            this.tutorBtn.Location = new System.Drawing.Point(291, 27);
            this.tutorBtn.Name = "tutorBtn";
            this.tutorBtn.Normalcolor = System.Drawing.Color.Gray;
            this.tutorBtn.OnHovercolor = System.Drawing.Color.White;
            this.tutorBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.tutorBtn.selected = false;
            this.tutorBtn.Size = new System.Drawing.Size(241, 48);
            this.tutorBtn.TabIndex = 5;
            this.tutorBtn.Text = "TUTOR";
            this.tutorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tutorBtn.Textcolor = System.Drawing.Color.Black;
            this.tutorBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorBtn.Click += new System.EventHandler(this.tutorBtn_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.Activecolor = System.Drawing.Color.Cyan;
            this.adminBtn.BackColor = System.Drawing.Color.Cyan;
            this.adminBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminBtn.BorderRadius = 7;
            this.adminBtn.ButtonText = "ADMIN";
            this.adminBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminBtn.DisabledColor = System.Drawing.Color.Gray;
            this.adminBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adminBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.adminBtn.Iconimage = null;
            this.adminBtn.Iconimage_right = null;
            this.adminBtn.Iconimage_right_Selected = null;
            this.adminBtn.Iconimage_Selected = null;
            this.adminBtn.IconMarginLeft = 0;
            this.adminBtn.IconMarginRight = 0;
            this.adminBtn.IconRightVisible = true;
            this.adminBtn.IconRightZoom = 0D;
            this.adminBtn.IconVisible = true;
            this.adminBtn.IconZoom = 90D;
            this.adminBtn.IsTab = false;
            this.adminBtn.Location = new System.Drawing.Point(21, 27);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Normalcolor = System.Drawing.Color.Cyan;
            this.adminBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.adminBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.adminBtn.selected = false;
            this.adminBtn.Size = new System.Drawing.Size(241, 48);
            this.adminBtn.TabIndex = 4;
            this.adminBtn.Text = "ADMIN";
            this.adminBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminBtn.Textcolor = System.Drawing.Color.Black;
            this.adminBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // forgotPass
            // 
            this.forgotPass.AutoSize = true;
            this.forgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPass.ForeColor = System.Drawing.Color.DarkRed;
            this.forgotPass.Location = new System.Drawing.Point(344, 818);
            this.forgotPass.Name = "forgotPass";
            this.forgotPass.Size = new System.Drawing.Size(184, 20);
            this.forgotPass.TabIndex = 1;
            this.forgotPass.Text = "FORGOT PASSWORD?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(504, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(726, 1041);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label forgotPass;
        private Bunifu.Framework.UI.BunifuFlatButton tutorBtn;
        private Bunifu.Framework.UI.BunifuFlatButton adminBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox usernameInput;
        private Bunifu.Framework.UI.BunifuMetroTextbox passwordInput;
        private Bunifu.Framework.UI.BunifuFlatButton loginBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.TextBox loginErrorMsg;
    }
}