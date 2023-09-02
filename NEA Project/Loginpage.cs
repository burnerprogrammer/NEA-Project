using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualBasic.Logging;
using NEA_Project;

namespace Prototype1
{
    public partial class Loginpage : Form
    {
        private static string databaselocation = "C://Users//ibnsh//source//repos//NEA Project//Database//NEADatabase.accdb";
        private OleDbConnection databaseconnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databaselocation);
        public Loginpage()
        {
            InitializeComponent();

        }


        private void BTNlogin_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();

            if (Database.User_Exists(TXTBOXusername.Text))
            {
                MessageBox.Show("yo");


            }
        }

        // roblox
        private void BTNregister_Click(object sender, EventArgs e)
        {
            Registerpage registerPage = new Registerpage();
            registerPage.Show();
        }
    }

 
}



