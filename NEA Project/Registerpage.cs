using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
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
            
                if (TXTBOXusername.Text == "" && TXTBOXpassword.Text == "" && TXTBOXpassword.Text == "")
                {
                    MessageBox.Show("Username and password fields are empty", "Failed Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);




                }


                else if (TXTBOXpassword.Text == TXTBOXconfirmpassword.Text)
                {

                    Database.Add_New_User(TXTBOXusername.Text, TXTBOXpassword.Text);

                    MessageBox.Show("Account created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();               
                }


                else
                {
                    MessageBox.Show("Passwords dont match please re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            


        }

    }
}


