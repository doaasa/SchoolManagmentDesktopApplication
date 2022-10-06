
namespace WindowsFormsApp1
{
    partial class StaffHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffHomePage));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5_Logout = new System.Windows.Forms.Button();
            this.panel_home = new System.Windows.Forms.Panel();
            this.button2_Score = new System.Windows.Forms.Button();
            this.button3_Course = new System.Windows.Forms.Button();
            this.button4_Student = new System.Windows.Forms.Button();
            this.button1_StaffHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_home.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "School Student System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(5, 0);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(5, 0);
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button5_Logout);
            this.panel1.Controls.Add(this.panel_home);
            this.panel1.Controls.Add(this.button1_StaffHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 482);
            this.panel1.TabIndex = 6;
            // 
            // button5_Logout
            // 
            this.button5_Logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5_Logout.BackColor = System.Drawing.Color.White;
            this.button5_Logout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5_Logout.FlatAppearance.BorderSize = 2;
            this.button5_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button5_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5_Logout.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5_Logout.Location = new System.Drawing.Point(26, 409);
            this.button5_Logout.Name = "button5_Logout";
            this.button5_Logout.Size = new System.Drawing.Size(125, 50);
            this.button5_Logout.TabIndex = 3;
            this.button5_Logout.Text = "Log Out";
            this.button5_Logout.UseVisualStyleBackColor = false;
            this.button5_Logout.Click += new System.EventHandler(this.button5_Logout_Click);
            // 
            // panel_home
            // 
            this.panel_home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_home.Controls.Add(this.button2_Score);
            this.panel_home.Controls.Add(this.button3_Course);
            this.panel_home.Controls.Add(this.button4_Student);
            this.panel_home.Location = new System.Drawing.Point(6, 73);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(174, 330);
            this.panel_home.TabIndex = 2;
            // 
            // button2_Score
            // 
            this.button2_Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2_Score.FlatAppearance.BorderSize = 0;
            this.button2_Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_Score.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_Score.Location = new System.Drawing.Point(6, 229);
            this.button2_Score.Name = "button2_Score";
            this.button2_Score.Size = new System.Drawing.Size(158, 37);
            this.button2_Score.TabIndex = 3;
            this.button2_Score.Text = "Score";
            this.button2_Score.UseVisualStyleBackColor = false;
            this.button2_Score.Click += new System.EventHandler(this.button2_Score_Click);
            // 
            // button3_Course
            // 
            this.button3_Course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3_Course.FlatAppearance.BorderSize = 0;
            this.button3_Course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3_Course.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3_Course.Location = new System.Drawing.Point(6, 138);
            this.button3_Course.Name = "button3_Course";
            this.button3_Course.Size = new System.Drawing.Size(158, 37);
            this.button3_Course.TabIndex = 4;
            this.button3_Course.Text = "Course";
            this.button3_Course.UseVisualStyleBackColor = false;
            this.button3_Course.Click += new System.EventHandler(this.button3_Course_Click);
            // 
            // button4_Student
            // 
            this.button4_Student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4_Student.FlatAppearance.BorderSize = 0;
            this.button4_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4_Student.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4_Student.Location = new System.Drawing.Point(6, 35);
            this.button4_Student.Name = "button4_Student";
            this.button4_Student.Size = new System.Drawing.Size(158, 37);
            this.button4_Student.TabIndex = 5;
            this.button4_Student.Text = "Student";
            this.button4_Student.UseVisualStyleBackColor = false;
            this.button4_Student.Click += new System.EventHandler(this.button4_Student_Click);
            // 
            // button1_StaffHome
            // 
            this.button1_StaffHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_StaffHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1_StaffHome.FlatAppearance.BorderSize = 0;
            this.button1_StaffHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_StaffHome.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_StaffHome.Location = new System.Drawing.Point(6, 14);
            this.button1_StaffHome.Name = "button1_StaffHome";
            this.button1_StaffHome.Size = new System.Drawing.Size(164, 37);
            this.button1_StaffHome.TabIndex = 1;
            this.button1_StaffHome.Text = "Staff Home";
            this.button1_StaffHome.UseVisualStyleBackColor = false;
            this.button1_StaffHome.Click += new System.EventHandler(this.button1_StaffHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(186, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 68);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Screenshot__2__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(527, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.d0cd322eed2ccddc079d87e0e6a1ccb7;
            this.pictureBox2.Location = new System.Drawing.Point(186, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(614, 414);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // StaffHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffHomePage";
            this.Load += new System.EventHandler(this.StaffHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel_home.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1_StaffHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5_Logout;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.Button button2_Score;
        private System.Windows.Forms.Button button3_Course;
        private System.Windows.Forms.Button button4_Student;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}