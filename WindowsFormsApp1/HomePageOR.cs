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
    public partial class HomePageOR : Form
    {
        public HomePageOR()
        {
            InitializeComponent();
            customizeDesign(); // to make pannel hide at the begging of the page

        }
        private void customizeDesign()
        {
            panel_home.Visible = false; // hide student or staff pannel

        }
        private void hideSubmenu()
        {
            if (panel_home.Visible == true)   // to make the user can toggel the pannel
                panel_home.Visible = false;
        }
        private void showSubmenu(Panel subMenu) // to hide the submenu if the value is true make it false , and if the value is false make it true
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
  
        private void button1_YourTitle_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_home); // to show and hide the submenu of the home title
        }

        private void radioButton1_staff_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1_staff.Checked) // if the user choose staff choice the staff login page will open
            {
                LogInPageStaff staff = new LogInPageStaff();
                staff.Show(); //show the new page of the Staff login page
                this.Hide(); //hide this page
            }
        }

        private void radioButton2_student_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2_student.Checked) // if the user choose Student choice the student login page will open
            {
                LoginStudent studentLogin = new LoginStudent(); //open student login page
                studentLogin.Show(); //show the new page of the student login page
                this.Hide(); //hide this page
            }
        }
    }
}
