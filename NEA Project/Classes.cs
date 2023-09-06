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
    public partial class Classes : Form
    {
        private string username;
        public Classes(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void BTNyoga_Click(object sender, EventArgs e)
        {
            Database.Add_Booking(username, "Yoga");

        }

        private void BTNswimming_Click(object sender, EventArgs e)
        {
            Database.Add_Booking(username, "Swimming");
        }

        private void BTNkarate_Click(object sender, EventArgs e)
        {
            Database.Add_Booking(username, "Karate");
        }

        private void BTNwomans_self_defence_Click(object sender, EventArgs e)
        {
            Database.Add_Booking(username, "Womans self defence");
        }

        private void BTNbadminton_Click(object sender, EventArgs e)
        {
            Database.Add_Booking(username, "Badminton");
        }
    }
}
