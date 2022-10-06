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
    public partial class StudentForgetPasswordPage : Form
    {    
        //connect to the database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BLUE LAP\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
        static string userid = "";
        public StudentForgetPasswordPage()
        {
            InitializeComponent();
        }
        private void textBox1_email_TextChanged(object sender, EventArgs e)
        {
            textBox1_email.ForeColor = Color.Black; // when user clicked on the textbox to write in it the color of writing become black
        }

        private void textBox1_email_Click(object sender, EventArgs e)
        {
            textBox1_email.Text = ""; // reset the textboxe

        }

        private void textBox2_newpass_Click(object sender, EventArgs e)
        {
            textBox2_newpassword.Text = "";  // reset the textboxe

        }

        private void textBox3_conpass_Click(object sender, EventArgs e)
        {
            textBox3_confirmpassword.Text = ""; // reset the textboxe

        }
          private void pictureBox3_back_Click(object sender, EventArgs e)
        {
            HomePageOR home = new HomePageOR(); // to return the home page to choice again
            home.Show(); //open the new homepage
            this.Hide(); //hide this page
        }

        private void button1_loginforgot_Click(object sender, EventArgs e)
        {
            //open connection with the database
            con.Open();
           
            if (textBox3_confirmpassword.Text == textBox2_newpassword.Text) // to check that the new password is the same as the confirmed password
            {
               
                SqlCommand cm2 = new SqlCommand("select email from StudentInfo where Email='" + textBox1_email.Text + "'", con);

                //to read the result of excute the query
                SqlDataReader sdr = cm2.ExecuteReader();

                if (sdr.Read()) //if the readed successfully and there is a data returned
                {
                        //query to update password data in the table
                        SqlCommand cmd = new SqlCommand("UPDATE StudentInfo SET Password='" + textBox2_newpassword.Text + "'where Email='" + textBox1_email.Text + "'", con);
                         con.Close(); // close connection for the data reader
                        try
                        {
                        con.Open(); // open connection for the query
                                    
                        // search for the username and password in the student info table
                        SqlCommand command = new SqlCommand("Select Id from StudentInfo where Email='" + textBox1_email.Text + "'and Password='" + textBox2_newpassword.Text + "'", con);

                        //retrieve a single value from database and returned scalar value on first column of first row in the returned set and check its object
                        object userNameObj = command.ExecuteScalar();
                        
                        if (userNameObj != null) //check that the returned value isn't null
                        {
                            userid = command.ExecuteScalar().ToString(); //store the returned value in the id to can manage student id
                        }
                            cmd.ExecuteNonQuery(); //excute the query
                            command.ExecuteNonQuery(); //excute the query
                        MessageBox.Show("Password Reset Successfuly", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Information); // updated password successfuly in the table
                       
                        StudentHomePage home = new StudentHomePage(userid); //open student home page after successfuly 
                            home.Show();
                            this.Hide();
                        }
                        catch 
                        {
                        MessageBox.Show(" Not Reseted Succesfully ", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error);//when failed to update the table
                    }
                    finally
                        {
                            con.Close();  //close connection
                        }
                    }
                else
                {
                    MessageBox.Show("Email isn't exist .. Please enter the right email", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); //if he entered wrong email
                }

            }
            else
            {
                MessageBox.Show("Please Check the new password and the confirmation password Again", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); // if he entered different password and confirmation password
            }
            con.Close(); //close connection
        }

        private void textBox2_newpassword_TextChanged(object sender, EventArgs e)
        {
            textBox2_newpassword.ForeColor = Color.Black; // when user clicked on the textbox to write in it the color of writing become black
        }

        private void textBox3_confirmpassword_TextChanged(object sender, EventArgs e)
        {
            textBox3_confirmpassword.ForeColor = Color.Black; // when user clicked on the textbox to write in it the color of writing become black
        }
    }
}
