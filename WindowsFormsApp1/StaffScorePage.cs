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
    public partial class StaffScorePage : Form
    {
        //connect to the database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BLUE LAP\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");

        public StaffScorePage()
        {
            InitializeComponent();
        }

       
      
        private void pictureBox1_back_Click(object sender, EventArgs e)
        {
            StaffHomePage home2 = new StaffHomePage(); // to return to the staff homepage
            home2.Show(); //open new page of staff home page
            this.Hide(); //hide this page
        }

        private void button2_Update_Click(object sender, EventArgs e)
        {
          
            //open connection with the database
            con.Open();
            if (Student_ID.Text.All(char.IsDigit) || Course_ID.Text.All(Char.IsDigit)) //to check that the ID and Phone is Number

            {
                // Update data into the Socre table
                SqlCommand cmd = new SqlCommand("UPDATE Score SET Student_Score='" + score.Text + "'where Student_ID= '" + Student_ID.Text + "'and Course_ID='" + Course_ID.Text + "'", con);
                con.Close(); //close connection
                try
                {
                    //open connection with the database
                    con.Open();
                    cmd.ExecuteNonQuery(); //Excute the query
                    MessageBox.Show("Updated Successfuly", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Information); //when the data updated sucessfuly
                }
                catch
                {
                    MessageBox.Show(" Not Updated", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error);  //when the data updated failed
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
            con.Close(); //close connection
        }

        private void button3_Delete_Click(object sender, EventArgs e)
        {
            //open connection with the database
            con.Open();
            
            // query to Delete data from the Socre table
            SqlCommand cmd = new SqlCommand("DELETE Score  where Student_ID= '" + Student_ID.Text + "'and Course_ID='" + Course_ID.Text + "'", con); 
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfuly", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Information);  //when data deleted successfuly of the table
                // to reset the textbox
                Student_ID.Clear();
                score.Clear();
                Course_ID.Clear();


            }
            catch 
            {
                MessageBox.Show(" ID isn't exist ", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error);  //if he entered wrong ID
            }
            finally
            {
                con.Close(); //close connection
            }
        }
    }
}
