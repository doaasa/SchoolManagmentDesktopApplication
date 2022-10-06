
namespace WindowsFormsApp1
{
    partial class StudentScorePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentScorePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2_back = new System.Windows.Forms.PictureBox();
            this.button1_viewscore = new System.Windows.Forms.Button();
            this.label_Sudent_ID = new System.Windows.Forms.Label();
            this.Student_ID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Studentscore = new System.Windows.Forms.TextBox();
            this.Student_Score = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_back)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2_back);
            this.panel1.Controls.Add(this.button1_viewscore);
            this.panel1.Controls.Add(this.label_Sudent_ID);
            this.panel1.Controls.Add(this.Student_ID);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "Triple S";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2_back
            // 
            this.pictureBox2_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2_back.Image = global::WindowsFormsApp1.Properties.Resources.images_removebg_preview;
            this.pictureBox2_back.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2_back.Name = "pictureBox2_back";
            this.pictureBox2_back.Size = new System.Drawing.Size(53, 44);
            this.pictureBox2_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2_back.TabIndex = 14;
            this.pictureBox2_back.TabStop = false;
            this.pictureBox2_back.Click += new System.EventHandler(this.pictureBox2_back_Click);
            // 
            // button1_viewscore
            // 
            this.button1_viewscore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_viewscore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1_viewscore.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_viewscore.ForeColor = System.Drawing.Color.Black;
            this.button1_viewscore.Location = new System.Drawing.Point(128, 382);
            this.button1_viewscore.Name = "button1_viewscore";
            this.button1_viewscore.Size = new System.Drawing.Size(142, 45);
            this.button1_viewscore.TabIndex = 13;
            this.button1_viewscore.Text = "View Score";
            this.button1_viewscore.UseVisualStyleBackColor = false;
            this.button1_viewscore.Click += new System.EventHandler(this.button1_viewscore_Click);
            // 
            // label_Sudent_ID
            // 
            this.label_Sudent_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Sudent_ID.AutoSize = true;
            this.label_Sudent_ID.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sudent_ID.Location = new System.Drawing.Point(422, 49);
            this.label_Sudent_ID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Sudent_ID.Name = "label_Sudent_ID";
            this.label_Sudent_ID.Size = new System.Drawing.Size(109, 31);
            this.label_Sudent_ID.TabIndex = 10;
            this.label_Sudent_ID.Text = "Your ID";
            // 
            // Student_ID
            // 
            this.Student_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Student_ID.Enabled = false;
            this.Student_ID.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_ID.Location = new System.Drawing.Point(575, 43);
            this.Student_ID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.Size = new System.Drawing.Size(138, 39);
            this.Student_ID.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Studentscore);
            this.panel2.Controls.Add(this.Student_Score);
            this.panel2.Location = new System.Drawing.Point(364, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 245);
            this.panel2.TabIndex = 1;
            // 
            // Studentscore
            // 
            this.Studentscore.Enabled = false;
            this.Studentscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentscore.Location = new System.Drawing.Point(211, 104);
            this.Studentscore.Name = "Studentscore";
            this.Studentscore.Size = new System.Drawing.Size(173, 47);
            this.Studentscore.TabIndex = 7;
            // 
            // Student_Score
            // 
            this.Student_Score.AutoSize = true;
            this.Student_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Score.Location = new System.Drawing.Point(35, 107);
            this.Student_Score.Name = "Student_Score";
            this.Student_Score.Size = new System.Drawing.Size(108, 39);
            this.Student_Score.TabIndex = 2;
            this.Student_Score.Text = "Score";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._4250905f83d1c6a8dec68aea1435e22e;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StudentScorePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentScorePage";
            this.Text = "StudentScorePage";
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Sudent_ID;
        private System.Windows.Forms.TextBox Student_ID;
        private System.Windows.Forms.Button button1_viewscore;
        private System.Windows.Forms.Label Student_Score;
        private System.Windows.Forms.TextBox Studentscore;
        private System.Windows.Forms.PictureBox pictureBox2_back;
        private System.Windows.Forms.Label label1;
    }
}