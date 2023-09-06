using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototype1;

namespace NEA_Project
{
    public partial class viewbooking : Form
    {
        string username;

        public viewbooking(string username)
        {
            InitializeComponent();
            this.username = username;
            Fill_Grid();
        }

        private void Fill_Grid()
        {
            List<string[]> list = Database.Get_Booked_Classes(username);

            foreach (string[] item in list)
            {
                GRIDbooking.Rows.Add(item);
            }
        }
    }
}
