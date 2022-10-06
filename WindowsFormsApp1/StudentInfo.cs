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

using System.IO;
namespace WindowsFormsApp1
{
    public partial class StudentInfo : Form
    {
        //connect to the database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BLUE LAP\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
        String imageUrl = "";
        public StudentInfo()
        {
            InitializeComponent();
        }


        private void StudentInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseData.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter1.Fill(this.courseData.Course);

            this.courseTableAdapter.Fill(this.dataDataSet.Course);

        }

        private void pictureBox1_back_Click(object sender, EventArgs e)
        {
            StaffHomePage home2 = new StaffHomePage(); // to return the laset page 
            home2.Show();  //show staff home page 
            this.Hide();//hide this page
        }

        private void button4_browsephoto_Click(object sender, EventArgs e)
        {
            //to can uploade photo from the device
            OpenFileDialog opendatilg = new OpenFileDialog(); 
            if (opendatilg.ShowDialog() == DialogResult.OK) //if the browse succeffuly done

            {

                imageUrl = opendatilg.FileName.ToString(); //put the url of the photo in the image url variable
                pictureBox2_choicephoto.ImageLocation = imageUrl; //view the photo in the picture box

            }
        }

        private void button5_viewphoto_Click(object sender, EventArgs e)
        {

            con.Open(); //open connection

            //query to select image of the table that related to student Id
            SqlCommand comm = new SqlCommand("select image from StudentInfo where Id ='" + StudentID.Text + "'", con);
            try
            {

                SqlDataReader dreader = comm.ExecuteReader();  // to read the result of excuting query
                if (dreader.Read())
                {
                    String images = dreader[0].ToString(); //store the urlin the images variable
                    if (images != null) //check that the image isn't empty
                    {
                        pictureBox3_viewphoto.ImageLocation = images; //to display the image in the picture box
                    }
                    else
                    {
                        MessageBox.Show(" No Image ", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); // if there isn't image in the table 
                    }

                }
                else
                {
                    MessageBox.Show(" No Record", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); //when there isn't the student id in the table
                }
                dreader.Close(); //close reader
            }
            catch
            {
                MessageBox.Show(" No Record", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); //when there isn't the student id in the table
            }
            finally
            {
                con.Close(); //close connection
            }
        }

        private void button1_insert_Click(object sender, EventArgs e)
        {
            //open connection with the database
            con.Open();
            // to insert  data into the table
            if (textBox1_Phone.Text.All(char.IsDigit) || StudentID.Text.All(char.IsDigit)) //to check that the ID and Phone is Number
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentInfo VALUES ('" + StudentID.Text + "', '" + Firstname.Text + "','" + Middlename.Text + "','" + lastname.Text + "','" + Birthday.Text + "','" + Address.Text + "','" + Email.Text + "','" + comboBox1_courses.Text + "','" + textBox1_Phone.Text + "','" + imageUrl + "','" + textBox1_GPA.Text + "','" + txt_password.Text + "')", con);
                try
                {
                    cmd.ExecuteNonQuery(); //excute the query
                    MessageBox.Show("Saved Successfuly", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Information); //when insert successfuly
                }
                catch
                {
                    MessageBox.Show("Not Saved", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); //when insert failed
                }
                finally
                {
                    con.Close(); //close connection
                }
            }
            else
            {
                MessageBox.Show("Please Enter valid Data in the fields!!", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); //when the user enter data which isn't numbers
            }
        }
        private void button2_update_Click_1(object sender, EventArgs e)
        {
            //open connection
            con.Open();
            
           
            if (textBox1_Phone.Text.All(char.IsDigit) || StudentID.Text.All(char.IsDigit)) //to check that the ID and Phone is Number
            {
               //query to update the data into the table
                SqlCommand cmd = new SqlCommand("UPDATE StudentInfo SET FirstName='" + Firstname.Text + "',MiddleName='" + Middlename.Text + "',LastName='" + lastname.Text + "',BirthDay='" + Birthday.Text + "',Address='" + Address.Text + "',Email='" + Email.Text + "',Course='" + comboBox1_courses.Text + "',Phone='" + textBox1_Phone + "',image='" + imageUrl + "',GPA='" + textBox1_GPA.Text + "',Password='" + txt_password.Text + "' where Id='" + StudentID.Text + "'", con);
                try
                {
                    cmd.ExecuteNonQuery(); //to excute query
                    MessageBox.Show("Updated Successfuly", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Information); //when updated successfuly
                }
                catch
                {
                    MessageBox.Show(" Not Updated", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); //when updated failed
                }
                finally
                {
                    con.Close(); //close connection
                }
            }
            else
            {
                MessageBox.Show("Please Enter valid Data in the fields!!", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); //when the user enter data which isn't numbers
            }
        }

        private void button3_delete_Click_1(object sender, EventArgs e)
        {
            //open connection
            con.Open();
           
            // to delete data from the table
            SqlCommand cmd = new SqlCommand("DELETE StudentInfo where Id='" + StudentID.Text + "'", con);

            try
            {
                cmd.ExecuteNonQuery(); //excute query
                MessageBox.Show("Deleted Successfuly", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Information); //when deleted successfuly

                // reset the textboxes
                StudentID.Clear();
                Firstname.Clear();
                Middlename.Clear();
                lastname.Clear();
                Birthday.Clear();
                Address.Clear();
                textBox1_GPA.Clear();
                txt_password.Clear();
                textBox1_Phone.Clear();
                pictureBox2_choicephoto.ImageLocation = "";
                Email.Clear();
                comboBox1_courses.SelectedItem = "";
                pictureBox3_viewphoto.ImageLocation = "";

            }
            catch
            {
                MessageBox.Show(" ID isn't exist ", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); // can't updated password successfuly in the table
            }
            finally
            {
                con.Close(); //close connection
            }
        }

      
    }
}
