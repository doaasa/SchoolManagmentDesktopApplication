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
    public partial class PrintCoursePage : Form
    {
        //connect to the database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BLUE LAP\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
        static string userid = "";
        static string courseid = "";
        public PrintCoursePage(string id)
        {
            userid = id; //store the student id in a global variable userid to can acess it
            InitializeComponent();
            
        }

        private void PrintCoursePage_Load(object sender, EventArgs e)
        {
            //fill the table adapter with copy of the data in the course table 
      
            this.courseTableAdapter.Fill(this.dataDataSet.Course);
           
           //open connection 
            con.Open();
           
            // search for the data from course table which have the same id of the course id and student id  in the score table
            SqlCommand cmd = new SqlCommand(" SELECT * from Course where Course.Course_ID  in (SELECT Score.Course_ID from Score where Score.Student_ID = '" + userid+"' )", con);
            
            // make new variable of data set to put the resulted data into group of tables
            DataSet ds = new DataSet();

            // to make a bridge between the database and the dataset to retrive the sql commands
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            try
            {
                da.Fill(ds);       // fill the data retrived of the dataadapter
                DataTable dt; // store the resulted data from the adapter in one of dataset to 
                    if (ds.Tables.Count > 0) // check that the table have data
                     {
                        dt = ds.Tables[0];   //store the data retrived into data tale
                       this.dataGridView1_CourseView.DataSource = dt;  // fill DataGridView
                       dataGridView1_CourseView.ClearSelection();     //clear select first row
                                                   
                     }
                con.Close();   // close connection
            }
            catch(Exception ex)
             {
                MessageBox.Show(ex.Message.ToString(), "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1_CourseView.SelectedRows.Count != 0) //to check that the user don't choose the header row 
                {

                courseid = dataGridView1_CourseView.SelectedRows[0].Cells[0].Value.ToString(); // to have the id of the chosen course of the table
              
                // open course page and get the user id and course id to can view the right data
                StudentCoursePage studentcourse = new StudentCoursePage(userid, courseid);
                studentcourse.Show(); // show new page of StudentCoursePage
                this.Hide(); //hide this instance
                }
                else
                {

                    MessageBox.Show("Please Select valid row", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); //when the user choose invalid row

                }
            }
            catch
            {
                MessageBox.Show("Please Select valid row", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); //when the user choose invalid row
            }

        }

        private void pictureBox2_Back_Click(object sender, EventArgs e)
        {
            StudentHomePage home = new StudentHomePage(userid); // go to the previous page
            home.Show(); // show new page of StudentHomePage
            this.Hide(); //hide this instance
        }

      
    }
}
