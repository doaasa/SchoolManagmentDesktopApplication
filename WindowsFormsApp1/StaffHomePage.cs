using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StaffHomePage : Form
    {
        public StaffHomePage()
        {
            InitializeComponent();
            customizeDesign(); // to make pannel hide at the beggening of the page
        }
        private void customizeDesign()
        {
            panel_home.Visible = false; // hide staff pannel

        }
        private void hideSubmenu()
        { 
            if (panel_home.Visible == true)  // to make the user can toggel the pannel
                panel_home.Visible = false;

        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false) // hide and show submenu
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
      
    

       
        private void StaffHomePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_StaffHome_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_home); // show and hide the submenu
        }

        private void button4_Student_Click(object sender, EventArgs e)
        {
            StudentInfo student1 = new StudentInfo(); // open the manage student page
            student1.Show(); //open new page of studentinfo
            this.Hide(); //hide this page
        }

        private void button3_Course_Click(object sender, EventArgs e)
        {
            StaffCoursePage course = new StaffCoursePage(); // open the course manage page
            course.Show(); //open new page of course
            this.Hide();  //hide this page
        }

        private void button2_Score_Click(object sender, EventArgs e)
        {
            StaffScorePage score = new StaffScorePage(); // open the manage score page
            score.Show(); //open new page of score
            this.Hide(); //hide this page
        }

        private void button5_Logout_Click(object sender, EventArgs e)
        {
            LogInPageStaff logout = new LogInPageStaff(); // to logout from the page
            logout.Show(); //open new page of login staff page
            this.Hide(); //hide this page
        }
    }
}
