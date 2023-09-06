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

        private void GRIDbooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6) 
            { 
                int id = Convert.ToInt32(GRIDbooking.Rows[e.RowIndex].Cells[0].Value);

                Database.Delete_Booking(id);
                GRIDbooking.Rows.Clear();
                Fill_Grid(); 
            }
        }
    }
}
