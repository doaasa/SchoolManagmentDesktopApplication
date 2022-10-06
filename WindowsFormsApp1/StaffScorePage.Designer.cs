
namespace WindowsFormsApp1
{
    partial class StaffScorePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffScorePage));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1_back = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Student_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.TextBox();
            this.Course_ID = new System.Windows.Forms.TextBox();
            this.button3_Delete = new System.Windows.Forms.Button();
            this.button2_Update = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_back)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Score";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 85);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1_back
            // 
            this.pictureBox1_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1_back.Image = global::WindowsFormsApp1.Properties.Resources.images_removebg_preview;
            this.pictureBox1_back.Location = new System.Drawing.Point(39, 14);
            this.pictureBox1_back.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1_back.Name = "pictureBox1_back";
            this.pictureBox1_back.Size = new System.Drawing.Size(51, 48);
            this.pictureBox1_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1_back.TabIndex = 0;
            this.pictureBox1_back.TabStop = false;
            this.pictureBox1_back.Click += new System.EventHandler(this.pictureBox1_back_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID";
            // 
            // Student_ID
            // 
            this.Student_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Student_ID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_ID.Location = new System.Drawing.Point(473, 186);
            this.Student_ID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.Size = new System.Drawing.Size(195, 35);
            this.Student_ID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Student Score";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Course ID";
            // 
            // score
            // 
            this.score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.score.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(473, 316);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(195, 35);
            this.score.TabIndex = 8;
            // 
            // Course_ID
            // 
            this.Course_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Course_ID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_ID.Location = new System.Drawing.Point(473, 246);
            this.Course_ID.Name = "Course_ID";
            this.Course_ID.Size = new System.Drawing.Size(195, 35);
            this.Course_ID.TabIndex = 9;
            // 
            // button3_Delete
            // 
            this.button3_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3_Delete.BackColor = System.Drawing.Color.DarkOrange;
            this.button3_Delete.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3_Delete.Location = new System.Drawing.Point(539, 414);
            this.button3_Delete.Name = "button3_Delete";
            this.button3_Delete.Size = new System.Drawing.Size(129, 49);
            this.button3_Delete.TabIndex = 23;
            this.button3_Delete.Text = "Delete";
            this.button3_Delete.UseVisualStyleBackColor = false;
            this.button3_Delete.Click += new System.EventHandler(this.button3_Delete_Click);
            // 
            // button2_Update
            // 
            this.button2_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2_Update.BackColor = System.Drawing.Color.Gold;
            this.button2_Update.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_Update.Location = new System.Drawing.Point(730, 414);
            this.button2_Update.Name = "button2_Update";
            this.button2_Update.Size = new System.Drawing.Size(129, 49);
            this.button2_Update.TabIndex = 22;
            this.button2_Update.Text = "Update";
            this.button2_Update.UseVisualStyleBackColor = false;
            this.button2_Update.Click += new System.EventHandler(this.button2_Update_Click);
            // 
            // StaffScorePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 486);
            this.Controls.Add(this.button3_Delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Student_ID);
            this.Controls.Add(this.button2_Update);
            this.Controls.Add(this.Course_ID);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffScorePage";
            this.Text = "ScorePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Student_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox score;
        private System.Windows.Forms.TextBox Course_ID;
        private System.Windows.Forms.Button button3_Delete;
        private System.Windows.Forms.Button button2_Update;
    }
}