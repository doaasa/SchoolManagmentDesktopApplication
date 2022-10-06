
namespace WindowsFormsApp1
{
    partial class StaffForgotPasswordPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3_back = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1_loginforgot = new System.Windows.Forms.Button();
            this.textBox3_confrimpassword = new System.Windows.Forms.TextBox();
            this.textBox2_newpassword = new System.Windows.Forms.TextBox();
            this.textBox1_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_back)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.pictureBox3_back);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox3_back
            // 
            this.pictureBox3_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3_back.Image = global::WindowsFormsApp1.Properties.Resources.images_removebg_preview;
            this.pictureBox3_back.Location = new System.Drawing.Point(49, 5);
            this.pictureBox3_back.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox3_back.Name = "pictureBox3_back";
            this.pictureBox3_back.Size = new System.Drawing.Size(34, 32);
            this.pictureBox3_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3_back.TabIndex = 2;
            this.pictureBox3_back.TabStop = false;
            this.pictureBox3_back.Click += new System.EventHandler(this.pictureBox3_back_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1_loginforgot);
            this.panel2.Controls.Add(this.textBox3_confrimpassword);
            this.panel2.Controls.Add(this.textBox2_newpassword);
            this.panel2.Controls.Add(this.textBox1_email);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(400, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 353);
            this.panel2.TabIndex = 1;
            // 
            // button1_loginforgot
            // 
            this.button1_loginforgot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_loginforgot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1_loginforgot.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_loginforgot.ForeColor = System.Drawing.SystemColors.Control;
            this.button1_loginforgot.Location = new System.Drawing.Point(104, 301);
            this.button1_loginforgot.Name = "button1_loginforgot";
            this.button1_loginforgot.Size = new System.Drawing.Size(154, 49);
            this.button1_loginforgot.TabIndex = 7;
            this.button1_loginforgot.Text = "Log in";
            this.button1_loginforgot.UseVisualStyleBackColor = false;
            this.button1_loginforgot.Click += new System.EventHandler(this.button1_loginforgot_Click);
            // 
            // textBox3_confrimpassword
            // 
            this.textBox3_confrimpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3_confrimpassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_confrimpassword.ForeColor = System.Drawing.Color.Silver;
            this.textBox3_confrimpassword.Location = new System.Drawing.Point(14, 249);
            this.textBox3_confrimpassword.Name = "textBox3_confrimpassword";
            this.textBox3_confrimpassword.Size = new System.Drawing.Size(323, 32);
            this.textBox3_confrimpassword.TabIndex = 6;
            this.textBox3_confrimpassword.Text = "Confirm New Password";
            this.textBox3_confrimpassword.Click += new System.EventHandler(this.textBox3_conpass_Click);
            this.textBox3_confrimpassword.TextChanged += new System.EventHandler(this.textBox3_confrimpassword_TextChanged);
            // 
            // textBox2_newpassword
            // 
            this.textBox2_newpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2_newpassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_newpassword.ForeColor = System.Drawing.Color.Silver;
            this.textBox2_newpassword.Location = new System.Drawing.Point(14, 187);
            this.textBox2_newpassword.Name = "textBox2_newpassword";
            this.textBox2_newpassword.Size = new System.Drawing.Size(323, 32);
            this.textBox2_newpassword.TabIndex = 5;
            this.textBox2_newpassword.Text = "New Password";
            this.textBox2_newpassword.Click += new System.EventHandler(this.textBox2_newpass_Click);
            this.textBox2_newpassword.TextChanged += new System.EventHandler(this.textBox2_newpassword_TextChanged);
            // 
            // textBox1_email
            // 
            this.textBox1_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1_email.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_email.ForeColor = System.Drawing.Color.Silver;
            this.textBox1_email.Location = new System.Drawing.Point(14, 126);
            this.textBox1_email.Name = "textBox1_email";
            this.textBox1_email.Size = new System.Drawing.Size(323, 32);
            this.textBox1_email.TabIndex = 4;
            this.textBox1_email.Text = "Enter Your Email";
            this.textBox1_email.Click += new System.EventHandler(this.textBox1_email_Click);
            this.textBox1_email.TextChanged += new System.EventHandler(this.textBox1_email_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Forgot Your Password?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.nku_change_password;
            this.pictureBox2.Location = new System.Drawing.Point(137, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.a9df7ff3c5d907646571e34423394130;
            this.pictureBox1.Location = new System.Drawing.Point(49, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StaffForgotPasswordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "StaffForgotPasswordPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForgotPasswordPage";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_back)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3_back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1_loginforgot;
        private System.Windows.Forms.TextBox textBox3_confrimpassword;
        private System.Windows.Forms.TextBox textBox2_newpassword;
        private System.Windows.Forms.TextBox textBox1_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}