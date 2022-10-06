
namespace WindowsFormsApp1
{
    partial class StudentHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentHomePage));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1_Studenthome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5_logout = new System.Windows.Forms.Button();
            this.panel_home = new System.Windows.Forms.Panel();
            this.button2_score = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_home.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(185, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 68);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Screenshot__2__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(527, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1_Studenthome
            // 
            this.button1_Studenthome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_Studenthome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1_Studenthome.FlatAppearance.BorderSize = 0;
            this.button1_Studenthome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Studenthome.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Studenthome.Location = new System.Drawing.Point(9, 12);
            this.button1_Studenthome.Name = "button1_Studenthome";
            this.button1_Studenthome.Size = new System.Drawing.Size(170, 37);
            this.button1_Studenthome.TabIndex = 1;
            this.button1_Studenthome.Text = "Student Home";
            this.button1_Studenthome.UseVisualStyleBackColor = false;
            this.button1_Studenthome.Click += new System.EventHandler(this.button1_Studenthome_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(5, 0);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(5, 0);
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button5_logout);
            this.panel1.Controls.Add(this.panel_home);
            this.panel1.Controls.Add(this.button1_Studenthome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 450);
            this.panel1.TabIndex = 9;
            // 
            // button5_logout
            // 
            this.button5_logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5_logout.BackColor = System.Drawing.Color.White;
            this.button5_logout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5_logout.FlatAppearance.BorderSize = 2;
            this.button5_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button5_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5_logout.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5_logout.Location = new System.Drawing.Point(25, 330);
            this.button5_logout.Name = "button5_logout";
            this.button5_logout.Size = new System.Drawing.Size(125, 50);
            this.button5_logout.TabIndex = 3;
            this.button5_logout.Text = "Log Out";
            this.button5_logout.UseVisualStyleBackColor = false;
            this.button5_logout.Click += new System.EventHandler(this.button5_logout_Click);
            // 
            // panel_home
            // 
            this.panel_home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_home.Controls.Add(this.button2_score);
            this.panel_home.Location = new System.Drawing.Point(6, 73);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(164, 214);
            this.panel_home.TabIndex = 2;
            // 
            // button2_score
            // 
            this.button2_score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2_score.FlatAppearance.BorderSize = 0;
            this.button2_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_score.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_score.Location = new System.Drawing.Point(3, 67);
            this.button2_score.Name = "button2_score";
            this.button2_score.Size = new System.Drawing.Size(158, 37);
            this.button2_score.TabIndex = 3;
            this.button2_score.Text = "Score";
            this.button2_score.UseVisualStyleBackColor = false;
            this.button2_score.Click += new System.EventHandler(this.button2_score_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.a75ae112489db9c7dc1102777e84f8a7;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // StudentHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentHomePage";
            this.Text = "StudentHomePage";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1_Studenthome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5_logout;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.Button button2_score;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}