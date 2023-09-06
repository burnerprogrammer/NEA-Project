using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototype1;

namespace NEA_Project
{
    public partial class Homepage : Form
    {
        private string username;

        public Homepage(string username)
        {
            InitializeComponent();
            LBLuser.Text = username;
            this.username = username;

        }

        private void BTN_classes_Click(object sender, EventArgs e)
        {
            Classes classes = new Classes(username);
            classes.Show();
        }

        private void LBLuser_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Loginpage loginpage = new Loginpage();
            loginpage.Show();
        }

        private void BTNinstructor_Click(object sender, EventArgs e)
        {
            class_instructors class_Instructors = new class_instructors();
            class_Instructors.Show();
        }

        private void BTNview_Bookings_Click(object sender, EventArgs e)
        {
            viewbooking viewbooking = new viewbooking(username);
            viewbooking.Show();
        }
    }
}
