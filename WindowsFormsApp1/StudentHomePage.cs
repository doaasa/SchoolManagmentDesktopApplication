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
    public partial class StudentHomePage : Form
    {

        static string userid = "";
        public StudentHomePage(string id)
        {
            userid = id;
            InitializeComponent();
            customizeDesign(); // to make pannel hide at the beggening of the page
        }
        private void customizeDesign()
        {
            panel_home.Visible = false;  // hide student  pannel

        }
        private void hideSubmenu()
        {
            if (panel_home.Visible == true) // to make the user can toggel the pannel
                panel_home.Visible = false;
        }
        private void showSubmenu(Panel subMenu) // hide and show submenu
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void button1_Studenthome_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_home); //show and hide submenu
        }

        private void button2_score_Click(object sender, EventArgs e)
        {
            PrintCoursePage printcourse = new PrintCoursePage(userid); // to view the course page
            printcourse.Show(); //open the new page
            this.Hide(); //hide this page
        }

        private void button5_logout_Click(object sender, EventArgs e)
        {
            LoginStudent logout = new LoginStudent();  // to logout from the page
            logout.Show(); //open the new page
            this.Hide();//hide this page
        }
    }
}
