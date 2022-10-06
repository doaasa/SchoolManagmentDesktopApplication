
namespace WindowsFormsApp1
{
    partial class HomePageOR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageOR));
            this.panel_home = new System.Windows.Forms.Panel();
            this.radioButton2_student = new System.Windows.Forms.RadioButton();
            this.radioButton1_staff = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1_YourTitle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_home.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_home
            // 
            this.panel_home.Controls.Add(this.radioButton2_student);
            this.panel_home.Controls.Add(this.radioButton1_staff);
            this.panel_home.Location = new System.Drawing.Point(6, 73);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(164, 292);
            this.panel_home.TabIndex = 2;
            // 
            // radioButton2_student
            // 
            this.radioButton2_student.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2_student.AutoSize = true;
            this.radioButton2_student.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2_student.Location = new System.Drawing.Point(20, 143);
            this.radioButton2_student.Name = "radioButton2_student";
            this.radioButton2_student.Size = new System.Drawing.Size(120, 37);
            this.radioButton2_student.TabIndex = 1;
            this.radioButton2_student.TabStop = true;
            this.radioButton2_student.Text = "Student";
            this.radioButton2_student.UseVisualStyleBackColor = true;
            this.radioButton2_student.CheckedChanged += new System.EventHandler(this.radioButton2_student_CheckedChanged);
            // 
            // radioButton1_staff
            // 
            this.radioButton1_staff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1_staff.AutoSize = true;
            this.radioButton1_staff.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1_staff.Location = new System.Drawing.Point(20, 80);
            this.radioButton1_staff.Name = "radioButton1_staff";
            this.radioButton1_staff.Size = new System.Drawing.Size(86, 37);
            this.radioButton1_staff.TabIndex = 0;
            this.radioButton1_staff.TabStop = true;
            this.radioButton1_staff.Text = "Staff";
            this.radioButton1_staff.UseVisualStyleBackColor = true;
            this.radioButton1_staff.CheckedChanged += new System.EventHandler(this.radioButton1_staff_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(5, 0);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(5, 0);
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel_home);
            this.panel1.Controls.Add(this.button1_YourTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 469);
            this.panel1.TabIndex = 9;
            // 
            // button1_YourTitle
            // 
            this.button1_YourTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_YourTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1_YourTitle.FlatAppearance.BorderSize = 0;
            this.button1_YourTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_YourTitle.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_YourTitle.Location = new System.Drawing.Point(6, 14);
            this.button1_YourTitle.Name = "button1_YourTitle";
            this.button1_YourTitle.Size = new System.Drawing.Size(164, 37);
            this.button1_YourTitle.TabIndex = 1;
            this.button1_YourTitle.Text = "Your Title";
            this.button1_YourTitle.UseVisualStyleBackColor = false;
            this.button1_YourTitle.Click += new System.EventHandler(this.button1_YourTitle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(193, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 68);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Screenshot__2__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(529, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "School Student System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.gbcv_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(193, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(604, 401);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // HomePageOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 469);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePageOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePageOR";
            this.panel_home.ResumeLayout(false);
            this.panel_home.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1_YourTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2_student;
        private System.Windows.Forms.RadioButton radioButton1_staff;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}