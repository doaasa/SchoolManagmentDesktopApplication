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
    public partial class StudentScorePage : Form
    {
        // open connection to database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BLUE LAP\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
        string userid = "";
        string courseid = "";
        public StudentScorePage(string uid, string cid)
        {
            userid = uid;
            courseid = cid;
            InitializeComponent();
          
            // hide the textboxes
            Student_Score.Visible = false;
         
            Studentscore.Visible = false;
        
        }
        private void pictureBox2_back_Click(object sender, EventArgs e)
        {
            StudentCoursePage studentcourse = new StudentCoursePage(userid, courseid); // to return back to the course page
            studentcourse.Show(); //to open the page
            this.Hide(); //to hide this page
        }

        private void button1_viewscore_Click(object sender, EventArgs e)
        {
            try
            {
                //open connection
                con.Open();

                // to select score of the table
                SqlCommand cmd2 = new SqlCommand("SELECT Student_Score from Score where Student_ID= '" + userid + "'and Course_ID='" + courseid + "'", con);
                //to read the data returned from the query
                SqlDataReader dareader = cmd2.ExecuteReader();
               
                while (dareader.Read()) //if the data sucessffuly readed
                {
                    Studentscore.Text = dareader.GetValue(0).ToString(); // to display the score in the textbox

                }
            
                Student_ID.Text = userid; // display the student id in the textbox


                Student_Score.Visible = true; // make the studentscore textbox and label available
                Studentscore.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry there are Some Errors!!", ex.Message.ToString()); 
            }
            finally
            {
                con.Close(); //close connection
            }
        }
    }
}
