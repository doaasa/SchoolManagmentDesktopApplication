
namespace WindowsFormsApp1
{
    partial class StudentInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1_back = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_Birthday = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_MiddleName = new System.Windows.Forms.Label();
            this.label_Lastname = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.Middlename = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.Birthday = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1_insert = new System.Windows.Forms.Button();
            this.button2_update = new System.Windows.Forms.Button();
            this.button3_delete = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2_choicephoto = new System.Windows.Forms.PictureBox();
            this.button4_browsephoto = new System.Windows.Forms.Button();
            this.pictureBox3_viewphoto = new System.Windows.Forms.PictureBox();
            this.button5_viewphoto = new System.Windows.Forms.Button();
            this.textBox1_Phone = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.textBox1_GPA = new System.Windows.Forms.TextBox();
            this.GPA = new System.Windows.Forms.Label();
            this.dataDataSet = new WindowsFormsApp1.DataDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new WindowsFormsApp1.DataDataSetTableAdapters.CourseTableAdapter();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1_courses = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.courseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.courseData = new WindowsFormsApp1.CourseData();
            this.courseBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter1 = new WindowsFormsApp1.CourseDataTableAdapters.CourseTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_choicephoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_viewphoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1_back);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.StudentID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 85);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Student";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1_back
            // 
            this.pictureBox1_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1_back.Image = global::WindowsFormsApp1.Properties.Resources.images_removebg_preview;
            this.pictureBox1_back.Location = new System.Drawing.Point(15, 5);
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
            this.label2.Location = new System.Drawing.Point(650, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID";
            // 
            // StudentID
            // 
            this.StudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudentID.Location = new System.Drawing.Point(761, 46);
            this.StudentID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(83, 32);
            this.StudentID.TabIndex = 9;
            // 
            // label_FirstName
            // 
            this.label_FirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(12, 104);
            this.label_FirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(103, 23);
            this.label_FirstName.TabIndex = 2;
            this.label_FirstName.Text = "First Name";
            // 
            // label_Birthday
            // 
            this.label_Birthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Birthday.AutoSize = true;
            this.label_Birthday.Location = new System.Drawing.Point(12, 256);
            this.label_Birthday.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Birthday.Name = "label_Birthday";
            this.label_Birthday.Size = new System.Drawing.Size(81, 23);
            this.label_Birthday.TabIndex = 3;
            this.label_Birthday.Text = "Birthday";
            // 
            // label_Address
            // 
            this.label_Address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(12, 307);
            this.label_Address.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(76, 23);
            this.label_Address.TabIndex = 4;
            this.label_Address.Text = "Address";
            // 
            // label_Email
            // 
            this.label_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(12, 353);
            this.label_Email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(60, 23);
            this.label_Email.TabIndex = 5;
            this.label_Email.Text = "Email";
            // 
            // label_MiddleName
            // 
            this.label_MiddleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_MiddleName.AutoSize = true;
            this.label_MiddleName.Location = new System.Drawing.Point(12, 158);
            this.label_MiddleName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_MiddleName.Name = "label_MiddleName";
            this.label_MiddleName.Size = new System.Drawing.Size(123, 23);
            this.label_MiddleName.TabIndex = 6;
            this.label_MiddleName.Text = "Middle Name";
            // 
            // label_Lastname
            // 
            this.label_Lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Lastname.AutoSize = true;
            this.label_Lastname.Location = new System.Drawing.Point(12, 207);
            this.label_Lastname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Lastname.Name = "label_Lastname";
            this.label_Lastname.Size = new System.Drawing.Size(99, 23);
            this.label_Lastname.TabIndex = 7;
            this.label_Lastname.Text = "Last Name";
            // 
            // Course
            // 
            this.Course.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Course.AutoSize = true;
            this.Course.Location = new System.Drawing.Point(12, 440);
            this.Course.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(70, 23);
            this.Course.TabIndex = 8;
            this.Course.Text = "Course";
            // 
            // Firstname
            // 
            this.Firstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Firstname.Location = new System.Drawing.Point(141, 95);
            this.Firstname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(160, 32);
            this.Firstname.TabIndex = 10;
            // 
            // Middlename
            // 
            this.Middlename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Middlename.Location = new System.Drawing.Point(141, 149);
            this.Middlename.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Middlename.Name = "Middlename";
            this.Middlename.Size = new System.Drawing.Size(160, 32);
            this.Middlename.TabIndex = 12;
            // 
            // lastname
            // 
            this.lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastname.Location = new System.Drawing.Point(141, 198);
            this.lastname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(160, 32);
            this.lastname.TabIndex = 13;
            // 
            // Birthday
            // 
            this.Birthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Birthday.Location = new System.Drawing.Point(141, 247);
            this.Birthday.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(160, 32);
            this.Birthday.TabIndex = 14;
            // 
            // Address
            // 
            this.Address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Address.Location = new System.Drawing.Point(141, 298);
            this.Address.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(160, 32);
            this.Address.TabIndex = 15;
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Email.Location = new System.Drawing.Point(141, 344);
            this.Email.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(160, 32);
            this.Email.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(548, 170);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Upload Photo";
            // 
            // button1_insert
            // 
            this.button1_insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_insert.BackColor = System.Drawing.SystemColors.WindowText;
            this.button1_insert.ForeColor = System.Drawing.Color.White;
            this.button1_insert.Location = new System.Drawing.Point(724, 576);
            this.button1_insert.Name = "button1_insert";
            this.button1_insert.Size = new System.Drawing.Size(129, 49);
            this.button1_insert.TabIndex = 18;
            this.button1_insert.Text = "Insert";
            this.button1_insert.UseVisualStyleBackColor = false;
            this.button1_insert.Click += new System.EventHandler(this.button1_insert_Click);
            // 
            // button2_update
            // 
            this.button2_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2_update.BackColor = System.Drawing.Color.Gold;
            this.button2_update.Location = new System.Drawing.Point(552, 576);
            this.button2_update.Name = "button2_update";
            this.button2_update.Size = new System.Drawing.Size(129, 49);
            this.button2_update.TabIndex = 19;
            this.button2_update.Text = "Update";
            this.button2_update.UseVisualStyleBackColor = false;
            this.button2_update.Click += new System.EventHandler(this.button2_update_Click_1);
            // 
            // button3_delete
            // 
            this.button3_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3_delete.BackColor = System.Drawing.Color.DarkOrange;
            this.button3_delete.Location = new System.Drawing.Point(384, 576);
            this.button3_delete.Name = "button3_delete";
            this.button3_delete.Size = new System.Drawing.Size(129, 49);
            this.button3_delete.TabIndex = 20;
            this.button3_delete.Text = "Delete";
            this.button3_delete.UseVisualStyleBackColor = false;
            this.button3_delete.Click += new System.EventHandler(this.button3_delete_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2_choicephoto
            // 
            this.pictureBox2_choicephoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2_choicephoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2_choicephoto.Location = new System.Drawing.Point(552, 211);
            this.pictureBox2_choicephoto.Name = "pictureBox2_choicephoto";
            this.pictureBox2_choicephoto.Size = new System.Drawing.Size(317, 222);
            this.pictureBox2_choicephoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2_choicephoto.TabIndex = 21;
            this.pictureBox2_choicephoto.TabStop = false;
            // 
            // button4_browsephoto
            // 
            this.button4_browsephoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4_browsephoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4_browsephoto.Location = new System.Drawing.Point(644, 455);
            this.button4_browsephoto.Name = "button4_browsephoto";
            this.button4_browsephoto.Size = new System.Drawing.Size(149, 42);
            this.button4_browsephoto.TabIndex = 22;
            this.button4_browsephoto.Text = "Browse";
            this.button4_browsephoto.UseVisualStyleBackColor = false;
            this.button4_browsephoto.Click += new System.EventHandler(this.button4_browsephoto_Click);
            // 
            // pictureBox3_viewphoto
            // 
            this.pictureBox3_viewphoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3_viewphoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3_viewphoto.Location = new System.Drawing.Point(324, 215);
            this.pictureBox3_viewphoto.Name = "pictureBox3_viewphoto";
            this.pictureBox3_viewphoto.Size = new System.Drawing.Size(205, 143);
            this.pictureBox3_viewphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3_viewphoto.TabIndex = 23;
            this.pictureBox3_viewphoto.TabStop = false;
            // 
            // button5_viewphoto
            // 
            this.button5_viewphoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5_viewphoto.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5_viewphoto.Location = new System.Drawing.Point(355, 373);
            this.button5_viewphoto.Name = "button5_viewphoto";
            this.button5_viewphoto.Size = new System.Drawing.Size(149, 42);
            this.button5_viewphoto.TabIndex = 24;
            this.button5_viewphoto.Text = "View";
            this.button5_viewphoto.UseVisualStyleBackColor = false;
            this.button5_viewphoto.Click += new System.EventHandler(this.button5_viewphoto_Click);
            // 
            // textBox1_Phone
            // 
            this.textBox1_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1_Phone.Location = new System.Drawing.Point(141, 390);
            this.textBox1_Phone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1_Phone.Name = "textBox1_Phone";
            this.textBox1_Phone.Size = new System.Drawing.Size(160, 32);
            this.textBox1_Phone.TabIndex = 26;
            // 
            // Phone
            // 
            this.Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(12, 399);
            this.Phone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(62, 23);
            this.Phone.TabIndex = 25;
            this.Phone.Text = "Phone";
            // 
            // textBox1_GPA
            // 
            this.textBox1_GPA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1_GPA.Location = new System.Drawing.Point(141, 488);
            this.textBox1_GPA.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1_GPA.Name = "textBox1_GPA";
            this.textBox1_GPA.Size = new System.Drawing.Size(160, 32);
            this.textBox1_GPA.TabIndex = 28;
            // 
            // GPA
            // 
            this.GPA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GPA.AutoSize = true;
            this.GPA.Location = new System.Drawing.Point(16, 488);
            this.GPA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.GPA.Name = "GPA";
            this.GPA.Size = new System.Drawing.Size(49, 23);
            this.GPA.TabIndex = 27;
            this.GPA.Text = "GPA";
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "DataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.dataDataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.dataDataSet;
            // 
            // comboBox1_courses
            // 
            this.comboBox1_courses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1_courses.DataSource = this.courseBindingSource3;
            this.comboBox1_courses.DisplayMember = "Course_Name";
            this.comboBox1_courses.FormattingEnabled = true;
            this.comboBox1_courses.Location = new System.Drawing.Point(141, 440);
            this.comboBox1_courses.Name = "comboBox1_courses";
            this.comboBox1_courses.Size = new System.Drawing.Size(160, 31);
            this.comboBox1_courses.TabIndex = 29;
            this.comboBox1_courses.ValueMember = "Course_ID";
            // 
            // txt_password
            // 
            this.txt_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_password.Location = new System.Drawing.Point(141, 532);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(160, 32);
            this.txt_password.TabIndex = 30;
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(16, 535);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(90, 23);
            this.Password.TabIndex = 31;
            this.Password.Text = "Password";
            // 
            // courseBindingSource2
            // 
            this.courseBindingSource2.DataMember = "Course";
            this.courseBindingSource2.DataSource = this.dataDataSet;
            // 
            // courseData
            // 
            this.courseData.DataSetName = "CourseData";
            this.courseData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource3
            // 
            this.courseBindingSource3.DataMember = "Course";
            this.courseBindingSource3.DataSource = this.courseData;
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.ClientSize = new System.Drawing.Size(893, 637);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.comboBox1_courses);
            this.Controls.Add(this.textBox1_GPA);
            this.Controls.Add(this.GPA);
            this.Controls.Add(this.textBox1_Phone);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.button5_viewphoto);
            this.Controls.Add(this.pictureBox3_viewphoto);
            this.Controls.Add(this.button4_browsephoto);
            this.Controls.Add(this.pictureBox2_choicephoto);
            this.Controls.Add(this.button3_delete);
            this.Controls.Add(this.button2_update);
            this.Controls.Add(this.button1_insert);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.Middlename);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.label_Lastname);
            this.Controls.Add(this.label_MiddleName);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_Birthday);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "StudentInfo";
            this.Text = "StudentInfo";
            this.Load += new System.EventHandler(this.StudentInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_choicephoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_viewphoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_Birthday;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_MiddleName;
        private System.Windows.Forms.Label label_Lastname;
        private System.Windows.Forms.Label Course;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.TextBox Middlename;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox Birthday;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1_insert;
        private System.Windows.Forms.Button button2_update;
        private System.Windows.Forms.Button button3_delete;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2_choicephoto;
        private System.Windows.Forms.Button button4_browsephoto;
        private System.Windows.Forms.PictureBox pictureBox3_viewphoto;
        private System.Windows.Forms.Button button5_viewphoto;
        private System.Windows.Forms.TextBox textBox1_Phone;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox textBox1_GPA;
        private System.Windows.Forms.Label GPA;
        private DataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private DataDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1_courses;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.BindingSource courseBindingSource2;
        private CourseData courseData;
        private System.Windows.Forms.BindingSource courseBindingSource3;
        private CourseDataTableAdapters.CourseTableAdapter courseTableAdapter1;
    }
}