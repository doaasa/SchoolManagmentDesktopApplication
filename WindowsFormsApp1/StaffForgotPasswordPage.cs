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
    public partial class StaffForgotPasswordPage : Form
    {      
        //connect to the database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BLUE LAP\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");

        public StaffForgotPasswordPage()
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
            textBox2_newpassword.Text = ""; // reset the textboxe

        }

        private void textBox3_conpass_Click(object sender, EventArgs e)
        {
            textBox3_confrimpassword.Text = ""; // reset the textboxe

        }

        private void pictureBox3_back_Click(object sender, EventArgs e)
        {
            HomePageOR home = new HomePageOR(); // to return the home page to choice again
            home.Show(); //open the home page to choose
            this.Hide(); // hide this page
        }

        private void textBox2_newpassword_TextChanged(object sender, EventArgs e)
        {
            textBox2_newpassword.ForeColor = Color.Black; // when user clicked on the textbox to write in it the color of writing become black

        }

        private void textBox3_confrimpassword_TextChanged(object sender, EventArgs e)
        {
            textBox3_confrimpassword.ForeColor = Color.Black;  // when user clicked on the textbox to write in it the color of writing become black

        }

        private void button1_loginforgot_Click(object sender, EventArgs e)
        {
            //open connection with the database
            con.Open();
            // to check that the new password is the same as the confirmed password
            if (textBox3_confrimpassword.Text == textBox2_newpassword.Text)
            {
                //query to search email from table in the database
                SqlCommand cm2 = new SqlCommand("SELECT Email from StaffUsers where Email='" + textBox1_email.Text + "'", con);
                
                //read the result of excuted query
                SqlDataReader sdr = cm2.ExecuteReader();

                //read data table rows and check that there is a data in the first row of first column to check the valadity of username and password
                if (sdr.Read())
                {
                    // to update password data in the table
                    SqlCommand cmd = new SqlCommand("UPDATE StaffUsers SET Password='" + textBox2_newpassword.Text + "'where Email='" + textBox1_email.Text + "'", con);
                    con.Close();  // close connection for the data reader
                    try
                    {
                        con.Open(); // open connection for the query
                        cmd.ExecuteNonQuery(); //ecute the update query
                        MessageBox.Show("Password Reset Successfuly", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Information); // updated password successfuly in the table
                        StaffHomePage home = new StaffHomePage(); //open new staff home page
                        home.Show(); //show the new page
                        this.Hide(); //hide this page
                    }
                    catch 
                    {
                        MessageBox.Show(" Not Reseted Succesfully ", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); //when failed to update the table
                    }
                    finally
                    {
                        con.Close(); //close connection
                    }
                }
                else
                {
                    MessageBox.Show("Email isn't exist .. Please enter the right email", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); //if he entered wrong email
                }
            }

            else
            {
                MessageBox.Show("Please Check the new password and the confirmation password Again","Triple S",MessageBoxButtons.OK,MessageBoxIcon.Error); // if he entered different password and confirmation password

            }
            con.Close(); //close connection
        }
    }
}
