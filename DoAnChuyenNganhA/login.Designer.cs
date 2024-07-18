namespace DoAnChuyenNganhA
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.checkbx_hidepass = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.pic_user = new System.Windows.Forms.PictureBox();
            this.pic_password = new System.Windows.Forms.PictureBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_clearfields = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_password)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lbl_login.Location = new System.Drawing.Point(201, 160);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(156, 50);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Log In";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_user.Location = new System.Drawing.Point(101, 225);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(121, 34);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "User name";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_password.Location = new System.Drawing.Point(112, 325);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(110, 34);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password";
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(144, -2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(283, 170);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 3;
            this.pic_logo.TabStop = false;
            // 
            // checkbx_hidepass
            // 
            this.checkbx_hidepass.AutoSize = true;
            this.checkbx_hidepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbx_hidepass.ForeColor = System.Drawing.Color.Teal;
            this.checkbx_hidepass.Location = new System.Drawing.Point(66, 413);
            this.checkbx_hidepass.Name = "checkbx_hidepass";
            this.checkbx_hidepass.Size = new System.Drawing.Size(149, 24);
            this.checkbx_hidepass.TabIndex = 4;
            this.checkbx_hidepass.Text = "Show password";
            this.checkbx_hidepass.UseVisualStyleBackColor = true;
            this.checkbx_hidepass.CheckedChanged += new System.EventHandler(this.checkbx_hidepass_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.LawnGreen;
            this.btn_login.Location = new System.Drawing.Point(153, 452);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(253, 53);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_user
            // 
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txt_user.Location = new System.Drawing.Point(66, 262);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(429, 25);
            this.txt_user.TabIndex = 6;
            // 
            // pic_user
            // 
            this.pic_user.Image = ((System.Drawing.Image)(resources.GetObject("pic_user.Image")));
            this.pic_user.Location = new System.Drawing.Point(66, 225);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(40, 34);
            this.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_user.TabIndex = 7;
            this.pic_user.TabStop = false;
            // 
            // pic_password
            // 
            this.pic_password.Image = ((System.Drawing.Image)(resources.GetObject("pic_password.Image")));
            this.pic_password.Location = new System.Drawing.Point(64, 321);
            this.pic_password.Name = "pic_password";
            this.pic_password.Size = new System.Drawing.Size(42, 38);
            this.pic_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_password.TabIndex = 8;
            this.pic_password.TabStop = false;
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txt_password.Location = new System.Drawing.Point(66, 362);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(429, 25);
            this.txt_password.TabIndex = 9;
            // 
            // lbl_clearfields
            // 
            this.lbl_clearfields.AutoSize = true;
            this.lbl_clearfields.Font = new System.Drawing.Font("Lucida Bright", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clearfields.ForeColor = System.Drawing.Color.Teal;
            this.lbl_clearfields.Location = new System.Drawing.Point(418, 418);
            this.lbl_clearfields.Name = "lbl_clearfields";
            this.lbl_clearfields.Size = new System.Drawing.Size(105, 19);
            this.lbl_clearfields.TabIndex = 10;
            this.lbl_clearfields.Text = "Clear fields";
            this.lbl_clearfields.Click += new System.EventHandler(this.lbl_clearfields_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Location = new System.Drawing.Point(66, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 1);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Location = new System.Drawing.Point(66, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 1);
            this.panel2.TabIndex = 12;
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.Color.Gray;
            this.btn_signup.Location = new System.Drawing.Point(153, 533);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(253, 53);
            this.btn_signup.TabIndex = 13;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Gray;
            this.btn_exit.Location = new System.Drawing.Point(153, 615);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(253, 53);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 700);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_clearfields);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.pic_password);
            this.Controls.Add(this.pic_user);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.checkbx_hidepass);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.CheckBox checkbx_hidepass;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.PictureBox pic_user;
        private System.Windows.Forms.PictureBox pic_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_clearfields;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_exit;
    }
}

