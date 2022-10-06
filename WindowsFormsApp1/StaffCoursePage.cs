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
    public partial class StaffCoursePage : Form
    {
        //connect to the database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BLUE LAP\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");

        public StaffCoursePage()
        {
            InitializeComponent();
        }


        private void pictureBox1_back_Click(object sender, EventArgs e)
        {
            StaffHomePage home = new StaffHomePage(); // to return to the staff homepage
            home.Show(); //start new page of the staff home page
            this.Hide(); //hide this page
        }

        private void button1_Insert_Click(object sender, EventArgs e)
        {

            if (Coursehours.Text.All(char.IsDigit) || CourseID.Text.All(char.IsDigit)) //to check that the ID and course hours are Numbers
            {
                //open connection with the database
                con.Open();
               
                // query to insert data into the course table
                SqlCommand cmd = new SqlCommand("INSERT INTO Course VALUES ('" + CourseID.Text + "', '" + Coursename.Text + "','" + Courseinstructor.Text + "','" + Coursetime.Text + "','" + Courseday.Text + "','" + Coursehours.Text + "')", con);

                try
                {
                    cmd.ExecuteNonQuery(); //excute the insert query
                    MessageBox.Show("Saved Successfuly", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Information); //when the data inserted sucessfuly
                }
                catch 
                {
                    MessageBox.Show(" Not Saved", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); //when the data failed to be inserted in the table
                }
                finally
                {
                    con.Close();  //close connection
                }
            }
            else
            {
                MessageBox.Show("Please Enter valid Data in the fields!!", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); //when the user enter characters not numbers in the fields
            }

        }

        private void button2_Update_Click(object sender, EventArgs e)
        {
            if (Coursehours.Text.All(char.IsDigit) || CourseID.Text.All(char.IsDigit))  //to check that the ID and course hours are Numbers
            {
                //open connection to the database
                con.Open();
                
                //query to update data into the course table
                SqlCommand cmd = new SqlCommand("UPDATE Course SET Course_Name='" + Coursename.Text + "',Course_Instructor='" + Courseinstructor.Text + "',Course_Time='" + Coursetime.Text + "',Course_Day='" + Courseday.Text + "',Course_Hours='" + Coursehours.Text + "'where Course_ID='" + CourseID.Text + "'", con);

                try
                {
                    cmd.ExecuteNonQuery(); //excute the updated query
                    MessageBox.Show("Updated Successfuly", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Information); //when the data updated sucessfuly
                }
                catch (Exception)
                {
                    MessageBox.Show(" Not Updated", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error);   //when the data updated failed
                }
                finally
                {
                    con.Close(); //close connection
                }
            }
            else
            {
                MessageBox.Show("Please Enter valid Data in the fields!!", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); //when the user enter characters not numbers in the fields
            }
        }

        private void button3_Delete_Click(object sender, EventArgs e)
        {
            if (CourseID.Text.All(char.IsDigit))  //to check that the ID is Number
            {
                try
                {
                    //open connection to the database
                    con.Open();   
                   
                    //delete data from the course table
                    SqlCommand cmd = new SqlCommand("DELETE Course where Course_ID='" + CourseID.Text + "'", con);
                   
                    cmd.ExecuteNonQuery();  //excute the updated query
                    MessageBox.Show("Deleted Successfuly", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Information); //when data deleted successfuly of the table
                    // reset all the textboxes
                    CourseID.Clear();
                    Coursename.Clear();
                    Courseinstructor.Clear();
                    Coursetime.Clear();
                    Courseday.Clear();
                    Coursehours.Clear();
                }
                catch
                {
                    MessageBox.Show(" This Id can't be deleted, Enter Valid ID which is number and don't related to any other References", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); // can't deleted successfuly from the table
                }
                finally
                {
                    con.Close(); //close connection
                }
            }
            else
            {
                MessageBox.Show("Please Enter valid Data in the fields!!");  //when the user enter characters not numbers in the fields
            }
        }
    }
}
