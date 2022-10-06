using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class StudentCoursePage : Form
    {
        //connect to the database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BLUE LAP\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
        static string userid = "";
        static string courseid = "";
        public StudentCoursePage(string stid , string coid)
        {
            userid = stid;
            courseid = coid;

            InitializeComponent();
            // hide the labels and textboxes
            Course_Name.Visible = false;
            Course_Time.Visible = false;
            Course_Instructor.Visible = false;
            Course_Day.Visible = false;
            Course_Hours.Visible = false;
            Coursename.Visible = false;
            coursetime.Visible = false;
            courseinstructor.Visible = false;
            courseday.Visible = false;
            Coursehours.Visible = false;
        }


        private void pictureBox2_back_Click(object sender, EventArgs e)
        {
            PrintCoursePage student = new PrintCoursePage(userid); //return to the last page
            student.Show(); //show the new page
            this.Hide(); //hide last page
        }

        private void button1_viewCourse_Click(object sender, EventArgs e)
        {
            //open connection with the database
            con.Open();
            // query to search for the data related to the id in the dataset
            SqlCommand cmd = new SqlCommand("SELECT Course_Name ,Course_Instructor , Course_Time,Course_Day,Course_Hours from Course where Course_ID= '" + courseid + "'", con);
          
            //to read the result of excute the query
            SqlDataReader dareader = cmd.ExecuteReader();
            while (dareader.Read()) //if the readed successfully and there is a data returned
            {
                // add the data to the textboxes respectively
                Coursename.Text = dareader.GetValue(0).ToString();
                courseinstructor.Text = dareader.GetValue(1).ToString();
                coursetime.Text = dareader.GetValue(2).ToString();
                courseday.Text = dareader.GetValue(3).ToString();
                Coursehours.Text = dareader.GetValue(4).ToString();

            }

            con.Close(); //close connection

            ID.Text = userid;  //display the student id in the textbox
            textBox1_Courseid.Text = courseid; //display the course id in the textbox
           
            // show the labels and textboxes with the newdata
            Course_Name.Visible = true;
            Course_Time.Visible = true;
            Course_Instructor.Visible = true;
            Course_Day.Visible = true;

            Course_Hours.Visible = true;
            Coursename.Visible = true;
            coursetime.Visible = true;
            courseinstructor.Visible = true;
            courseday.Visible = true;
            Coursehours.Visible = true;
        }

        private void button2_viewScore_Click(object sender, EventArgs e)
        {
            StudentScorePage studentscore = new StudentScorePage(userid, courseid); // to view the score to related course id
            studentscore.Show(); //open the new page of student score page
            this.Hide(); //hide this page
        }
    }
}
