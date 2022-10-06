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
    public partial class LoginStudent : Form
    {
        //  connect with the database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BLUE LAP\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
        static string id = "";
        public LoginStudent()
        {
            InitializeComponent();
        }
        private void pictureBox4_back_Click(object sender, EventArgs e)
        {
            HomePageOR home = new HomePageOR(); // ifthe student user want to go back to the choice page
            home.Show(); // show the last page
            this.Hide(); // hide this instance
        }

        private void button1_login_Click(object sender, EventArgs e)
        {
            try
            {
                // open connection with the database
                con.Open();
                // to make a bridge between the database and the dataset to retrive the sql commands

                SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) from Studentinfo where FirstName='" + textBox1_username.Text + "'and Password='" + textBox2_password.Text + "'", con);
            
                // search for the username and password in the student info table
                SqlCommand command = new SqlCommand("Select Id from Studentinfo where FirstName='" + textBox1_username.Text + "'and Password='" + textBox2_password.Text + "'", con);
                
                object userNameObj = command.ExecuteScalar(); //retrieve a single value from database and returned scalar value on first column of first row in the returned set and check its object
               
                if (userNameObj != null) //check that the returned value isn't null
                {
                    id = command.ExecuteScalar().ToString(); //store the returned value in the id to can manage student id
                }

                //make a new table in the dataset adapter to can control and edit it
                DataTable dt = new DataTable();
                
                //fill new table with data being retrived from adapter which is a copy of the data in the table database
                sda.Fill(dt);

                //read data table rows and check that there is a data in the first row of first column to check the valadity of username and password
                if (dt.Rows[0][0].ToString() == "1")
                {
                    StudentHomePage home = new StudentHomePage(id); // getting the id of the registed student to can show the score and courses
                    home.Show(); // new Student home page will open
                    this.Hide(); // this page will hide

                }
                else
                {
                    MessageBox.Show("Please check your Username or Password", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error); // if user name or password isn't exist in the table
                }
            }
            catch
            {
                MessageBox.Show("Some Errors happen in Retriving Data", "Triple S", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close(); //close connection
            }
        }

        private void button1_forgetPassword_Click(object sender, EventArgs e)
        {
            StudentForgetPasswordPage forgot = new StudentForgetPasswordPage(); // if the student user want to reset his password
            forgot.Show(); // open new page of forget password page
            this.Hide(); //hide this instance
        }
    }
}
