using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class LogInPageStaff : Form
    {
        public LogInPageStaff()
        {
            InitializeComponent();
        }
      private void pictureBox4_back_Click(object sender, EventArgs e)
        {
            HomePageOR home = new HomePageOR();  // to can go back to the choice page
            home.Show(); // show the last page
            this.Hide(); // hide this instance
        }

        private void button1_login_Click(object sender, EventArgs e)
        {
            // open connection to the database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BLUE LAP\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
         
            // to make a bridge between the database and the dataset to retrive the sql commands
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) from StaffUsers where FirstName='" + textBox1_username.Text + "'and Password='" + textBox2_password.Text + "'", con);
          
            //make a new table in the dataset adapter to can control and edit it
            DataTable dt = new DataTable();
           
            //fill new table with data being retrived from adapter which is a copy of the data in the table database
            sda.Fill(dt);
            
            //read data table rows and check that there is a data in the first row of first column to check the valadity of username and password
            if (dt.Rows[0][0].ToString() == "1")
            {
                StaffHomePage Staffhomepage = new StaffHomePage(); // when confirming that the username and password exist the staff home page will open directly
                Staffhomepage.Show(); // new staff home page will open
                this.Hide(); // this page will hide
            }
            else
            {
                MessageBox.Show("Please check your Username or Password"); // when one of username and password isn't correct , or the user isn't in the dataset of the application
            }
        }

        private void button1_forgetPassword_Click(object sender, EventArgs e)
        {
            StaffForgotPasswordPage forgot = new StaffForgotPasswordPage(); // to can reset the password of the user if he forget it
            forgot.Show(); // open the forgot page to reset password
            this.Hide(); //hide this page
        }
    }
}
