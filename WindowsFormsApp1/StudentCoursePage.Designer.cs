
namespace WindowsFormsApp1
{
    partial class StudentCoursePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentCoursePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2_viewScore = new System.Windows.Forms.Button();
            this.pictureBox2_back = new System.Windows.Forms.PictureBox();
            this.Course_ID = new System.Windows.Forms.Label();
            this.textBox1_Courseid = new System.Windows.Forms.TextBox();
            this.button1_viewCourse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.courseday = new System.Windows.Forms.TextBox();
            this.courseinstructor = new System.Windows.Forms.TextBox();
            this.Course_Name = new System.Windows.Forms.Label();
            this.coursetime = new System.Windows.Forms.TextBox();
            this.Course_Instructor = new System.Windows.Forms.Label();
            this.Course_Day = new System.Windows.Forms.Label();
            this.Course_Time = new System.Windows.Forms.Label();
            this.Coursename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Course_Hours = new System.Windows.Forms.Label();
            this.Coursehours = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_back)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.button2_viewScore);
            this.panel1.Controls.Add(this.pictureBox2_back);
            this.panel1.Controls.Add(this.Course_ID);
            this.panel1.Controls.Add(this.textBox1_Courseid);
            this.panel1.Controls.Add(this.button1_viewCourse);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StudentID);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Course_Hours);
            this.panel1.Controls.Add(this.Coursehours);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 450);
            this.panel1.TabIndex = 0;
            // 
            // button2_viewScore
            // 
            this.button2_viewScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2_viewScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2_viewScore.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_viewScore.ForeColor = System.Drawing.Color.White;
            this.button2_viewScore.Location = new System.Drawing.Point(754, 380);
            this.button2_viewScore.Name = "button2_viewScore";
            this.button2_viewScore.Size = new System.Drawing.Size(113, 45);
            this.button2_viewScore.TabIndex = 22;
            this.button2_viewScore.Text = "Score";
            this.button2_viewScore.UseVisualStyleBackColor = false;
            this.button2_viewScore.Click += new System.EventHandler(this.button2_viewScore_Click);
            // 
            // pictureBox2_back
            // 
            this.pictureBox2_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2_back.Image = global::WindowsFormsApp1.Properties.Resources.images_removebg_preview;
            this.pictureBox2_back.Location = new System.Drawing.Point(15, 12);
            this.pictureBox2_back.Name = "pictureBox2_back";
            this.pictureBox2_back.Size = new System.Drawing.Size(46, 35);
            this.pictureBox2_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2_back.TabIndex = 21;
            this.pictureBox2_back.TabStop = false;
            this.pictureBox2_back.Click += new System.EventHandler(this.pictureBox2_back_Click);
            // 
            // Course_ID
            // 
            this.Course_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Course_ID.AutoSize = true;
            this.Course_ID.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_ID.Location = new System.Drawing.Point(465, 61);
            this.Course_ID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Course_ID.Name = "Course_ID";
            this.Course_ID.Size = new System.Drawing.Size(135, 31);
            this.Course_ID.TabIndex = 19;
            this.Course_ID.Text = "Course ID";
            // 
            // textBox1_Courseid
            // 
            this.textBox1_Courseid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1_Courseid.Enabled = false;
            this.textBox1_Courseid.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_Courseid.Location = new System.Drawing.Point(618, 55);
            this.textBox1_Courseid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1_Courseid.Name = "textBox1_Courseid";
            this.textBox1_Courseid.Size = new System.Drawing.Size(138, 39);
            this.textBox1_Courseid.TabIndex = 20;
            // 
            // button1_viewCourse
            // 
            this.button1_viewCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_viewCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1_viewCourse.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_viewCourse.ForeColor = System.Drawing.Color.Black;
            this.button1_viewCourse.Location = new System.Drawing.Point(96, 383);
            this.button1_viewCourse.Name = "button1_viewCourse";
            this.button1_viewCourse.Size = new System.Drawing.Size(156, 45);
            this.button1_viewCourse.TabIndex = 16;
            this.button1_viewCourse.Text = "View Course";
            this.button1_viewCourse.UseVisualStyleBackColor = false;
            this.button1_viewCourse.Click += new System.EventHandler(this.button1_viewCourse_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.courseday);
            this.panel2.Controls.Add(this.courseinstructor);
            this.panel2.Controls.Add(this.Course_Name);
            this.panel2.Controls.Add(this.coursetime);
            this.panel2.Controls.Add(this.Course_Instructor);
            this.panel2.Controls.Add(this.Course_Day);
            this.panel2.Controls.Add(this.Course_Time);
            this.panel2.Controls.Add(this.Coursename);
            this.panel2.Location = new System.Drawing.Point(365, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 245);
            this.panel2.TabIndex = 15;
            // 
            // courseday
            // 
            this.courseday.Enabled = false;
            this.courseday.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseday.Location = new System.Drawing.Point(240, 189);
            this.courseday.Name = "courseday";
            this.courseday.Size = new System.Drawing.Size(173, 38);
            this.courseday.TabIndex = 17;
            // 
            // courseinstructor
            // 
            this.courseinstructor.Enabled = false;
            this.courseinstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseinstructor.Location = new System.Drawing.Point(240, 78);
            this.courseinstructor.Name = "courseinstructor";
            this.courseinstructor.Size = new System.Drawing.Size(173, 38);
            this.courseinstructor.TabIndex = 15;
            // 
            // Course_Name
            // 
            this.Course_Name.AutoSize = true;
            this.Course_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_Name.Location = new System.Drawing.Point(17, 16);
            this.Course_Name.Name = "Course_Name";
            this.Course_Name.Size = new System.Drawing.Size(181, 31);
            this.Course_Name.TabIndex = 9;
            this.Course_Name.Text = "Course Name";
            // 
            // coursetime
            // 
            this.coursetime.Enabled = false;
            this.coursetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursetime.Location = new System.Drawing.Point(240, 134);
            this.coursetime.Name = "coursetime";
            this.coursetime.Size = new System.Drawing.Size(173, 38);
            this.coursetime.TabIndex = 16;
            // 
            // Course_Instructor
            // 
            this.Course_Instructor.AutoSize = true;
            this.Course_Instructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_Instructor.Location = new System.Drawing.Point(17, 78);
            this.Course_Instructor.Name = "Course_Instructor";
            this.Course_Instructor.Size = new System.Drawing.Size(224, 31);
            this.Course_Instructor.TabIndex = 10;
            this.Course_Instructor.Text = "Course Instructor";
            // 
            // Course_Day
            // 
            this.Course_Day.AutoSize = true;
            this.Course_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_Day.Location = new System.Drawing.Point(17, 189);
            this.Course_Day.Name = "Course_Day";
            this.Course_Day.Size = new System.Drawing.Size(158, 31);
            this.Course_Day.TabIndex = 11;
            this.Course_Day.Text = "Course Day";
            // 
            // Course_Time
            // 
            this.Course_Time.AutoSize = true;
            this.Course_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_Time.Location = new System.Drawing.Point(17, 134);
            this.Course_Time.Name = "Course_Time";
            this.Course_Time.Size = new System.Drawing.Size(169, 31);
            this.Course_Time.TabIndex = 12;
            this.Course_Time.Text = "Course Time";
            // 
            // Coursename
            // 
            this.Coursename.Enabled = false;
            this.Coursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coursename.Location = new System.Drawing.Point(240, 16);
            this.Coursename.Name = "Coursename";
            this.Coursename.Size = new System.Drawing.Size(173, 38);
            this.Coursename.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "Triple S";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentID
            // 
            this.StudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudentID.AutoSize = true;
            this.StudentID.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.Location = new System.Drawing.Point(465, 11);
            this.StudentID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(109, 31);
            this.StudentID.TabIndex = 12;
            this.StudentID.Text = "Your ID";
            // 
            // ID
            // 
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID.Enabled = false;
            this.ID.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(618, 5);
            this.ID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(138, 39);
            this.ID.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._21e42493edf38eec9a88067f83ca2762;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Course_Hours
            // 
            this.Course_Hours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Course_Hours.AutoSize = true;
            this.Course_Hours.Font = new System.Drawing.Font("Tahoma", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_Hours.Location = new System.Drawing.Point(378, 383);
            this.Course_Hours.Name = "Course_Hours";
            this.Course_Hours.Size = new System.Drawing.Size(212, 35);
            this.Course_Hours.TabIndex = 14;
            this.Course_Hours.Text = "Course Hours";
            // 
            // Coursehours
            // 
            this.Coursehours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Coursehours.Enabled = false;
            this.Coursehours.Font = new System.Drawing.Font("Tahoma", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coursehours.Location = new System.Drawing.Point(596, 380);
            this.Coursehours.Name = "Coursehours";
            this.Coursehours.Size = new System.Drawing.Size(107, 43);
            this.Coursehours.TabIndex = 18;
            // 
            // StudentCoursePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentCoursePage";
            this.Text = "StudentCoursePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_back)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1_viewCourse;
        private System.Windows.Forms.TextBox courseday;
        private System.Windows.Forms.TextBox courseinstructor;
        private System.Windows.Forms.Label Course_Name;
        private System.Windows.Forms.TextBox coursetime;
        private System.Windows.Forms.Label Course_Instructor;
        private System.Windows.Forms.Label Course_Day;
        private System.Windows.Forms.Label Course_Time;
        private System.Windows.Forms.TextBox Coursename;
        private System.Windows.Forms.Label Course_Hours;
        private System.Windows.Forms.TextBox Coursehours;
        private System.Windows.Forms.Label Course_ID;
        private System.Windows.Forms.TextBox textBox1_Courseid;
        private System.Windows.Forms.PictureBox pictureBox2_back;
        private System.Windows.Forms.Button button2_viewScore;
        private System.Windows.Forms.Label label1;
    }
}