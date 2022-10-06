
namespace WindowsFormsApp1
{
    partial class StaffCoursePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffCoursePage));
            this.button3_Delete = new System.Windows.Forms.Button();
            this.button2_Update = new System.Windows.Forms.Button();
            this.button1_Insert = new System.Windows.Forms.Button();
            this.Courseday = new System.Windows.Forms.TextBox();
            this.Coursetime = new System.Windows.Forms.TextBox();
            this.Courseinstructor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Coursename = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CourseID = new System.Windows.Forms.TextBox();
            this.pictureBox1_back = new System.Windows.Forms.PictureBox();
            this.Coursehours = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_back)).BeginInit();
            this.SuspendLayout();
            // 
            // button3_Delete
            // 
            this.button3_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3_Delete.BackColor = System.Drawing.Color.DarkOrange;
            this.button3_Delete.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3_Delete.Location = new System.Drawing.Point(416, 422);
            this.button3_Delete.Name = "button3_Delete";
            this.button3_Delete.Size = new System.Drawing.Size(129, 49);
            this.button3_Delete.TabIndex = 37;
            this.button3_Delete.Text = "Delete";
            this.button3_Delete.UseVisualStyleBackColor = false;
            this.button3_Delete.Click += new System.EventHandler(this.button3_Delete_Click);
            // 
            // button2_Update
            // 
            this.button2_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2_Update.BackColor = System.Drawing.Color.Gold;
            this.button2_Update.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_Update.Location = new System.Drawing.Point(584, 422);
            this.button2_Update.Name = "button2_Update";
            this.button2_Update.Size = new System.Drawing.Size(129, 49);
            this.button2_Update.TabIndex = 36;
            this.button2_Update.Text = "Update";
            this.button2_Update.UseVisualStyleBackColor = false;
            this.button2_Update.Click += new System.EventHandler(this.button2_Update_Click);
            // 
            // button1_Insert
            // 
            this.button1_Insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_Insert.BackColor = System.Drawing.SystemColors.WindowText;
            this.button1_Insert.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Insert.ForeColor = System.Drawing.Color.White;
            this.button1_Insert.Location = new System.Drawing.Point(756, 422);
            this.button1_Insert.Name = "button1_Insert";
            this.button1_Insert.Size = new System.Drawing.Size(129, 49);
            this.button1_Insert.TabIndex = 35;
            this.button1_Insert.Text = "Insert";
            this.button1_Insert.UseVisualStyleBackColor = false;
            this.button1_Insert.Click += new System.EventHandler(this.button1_Insert_Click);
            // 
            // Courseday
            // 
            this.Courseday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Courseday.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courseday.Location = new System.Drawing.Point(229, 302);
            this.Courseday.Name = "Courseday";
            this.Courseday.Size = new System.Drawing.Size(195, 35);
            this.Courseday.TabIndex = 32;
            // 
            // Coursetime
            // 
            this.Coursetime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Coursetime.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coursetime.Location = new System.Drawing.Point(229, 238);
            this.Coursetime.Name = "Coursetime";
            this.Coursetime.Size = new System.Drawing.Size(195, 35);
            this.Coursetime.TabIndex = 31;
            // 
            // Courseinstructor
            // 
            this.Courseinstructor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Courseinstructor.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courseinstructor.Location = new System.Drawing.Point(229, 173);
            this.Courseinstructor.Name = "Courseinstructor";
            this.Courseinstructor.Size = new System.Drawing.Size(195, 35);
            this.Courseinstructor.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Course";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Coursename
            // 
            this.Coursename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Coursename.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coursename.Location = new System.Drawing.Point(229, 111);
            this.Coursename.Name = "Coursename";
            this.Coursename.Size = new System.Drawing.Size(195, 35);
            this.Coursename.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 27);
            this.label6.TabIndex = 28;
            this.label6.Text = "Course Day";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 27);
            this.label5.TabIndex = 27;
            this.label5.Text = "Course Time";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 27);
            this.label3.TabIndex = 25;
            this.label3.Text = "Course Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 27);
            this.label4.TabIndex = 26;
            this.label4.Text = "Course Instructor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CourseID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 85);
            this.panel1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(698, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Course ID";
            // 
            // CourseID
            // 
            this.CourseID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CourseID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseID.Location = new System.Drawing.Point(806, 51);
            this.CourseID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(83, 29);
            this.CourseID.TabIndex = 11;
            // 
            // pictureBox1_back
            // 
            this.pictureBox1_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1_back.Image = global::WindowsFormsApp1.Properties.Resources.images_removebg_preview;
            this.pictureBox1_back.Location = new System.Drawing.Point(37, 14);
            this.pictureBox1_back.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1_back.Name = "pictureBox1_back";
            this.pictureBox1_back.Size = new System.Drawing.Size(51, 48);
            this.pictureBox1_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1_back.TabIndex = 0;
            this.pictureBox1_back.TabStop = false;
            this.pictureBox1_back.Click += new System.EventHandler(this.pictureBox1_back_Click);
            // 
            // Coursehours
            // 
            this.Coursehours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Coursehours.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coursehours.Location = new System.Drawing.Point(229, 357);
            this.Coursehours.Name = "Coursehours";
            this.Coursehours.Size = new System.Drawing.Size(195, 35);
            this.Coursehours.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 27);
            this.label7.TabIndex = 38;
            this.label7.Text = "Course Hours";
            // 
            // StaffCoursePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 479);
            this.Controls.Add(this.Coursehours);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3_Delete);
            this.Controls.Add(this.button2_Update);
            this.Controls.Add(this.button1_Insert);
            this.Controls.Add(this.Courseday);
            this.Controls.Add(this.Coursetime);
            this.Controls.Add(this.Courseinstructor);
            this.Controls.Add(this.Coursename);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffCoursePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffCoursePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3_Delete;
        private System.Windows.Forms.Button button2_Update;
        private System.Windows.Forms.Button button1_Insert;
        private System.Windows.Forms.TextBox Courseday;
        private System.Windows.Forms.TextBox Coursetime;
        private System.Windows.Forms.TextBox Courseinstructor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1_back;
        private System.Windows.Forms.TextBox Coursename;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Coursehours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CourseID;
    }
}