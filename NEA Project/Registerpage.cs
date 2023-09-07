using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototype1;

namespace NEA_Project
{
    public partial class Registerpage : Form
    {
        public Registerpage()
        {
            InitializeComponent();
        }


        private void BTNSignup_Click(object sender, EventArgs e)
        {
            string username = TXTBOXusername.Text;
            string password = TXTBOXpassword.Text;
            string confirm_password = TXTBOXconfirmpassword.Text;

            if (Database.User_Exists(username) == true)
            {
                MessageBox.Show("Username taken");
                return;
            }

            if (password != confirm_password)
            {
                MessageBox.Show("passwords don't match");
                return;
            }



            MessageBox.Show("Account created");
            
            Loginpage loginpage = new Loginpage();
            loginpage.Show();


            














            Database.Add_New_User(username, password);


        }


    }
}


