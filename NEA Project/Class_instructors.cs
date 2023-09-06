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
    public partial class class_instructors : Form
    {
        public class_instructors()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yoga_instructor yoga_Insturctor = new yoga_instructor();
            yoga_Insturctor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            swimming_instructor swimming_Instructor = new swimming_instructor();
            swimming_Instructor.Show();
        }

        private void BTNkarate_instructor_Click(object sender, EventArgs e)
        {
            karate_instructor karate_Instructor = new karate_instructor();
            karate_Instructor.Show();
        }

        private void BTNwomans_self_defence_instructor_Click(object sender, EventArgs e)
        {
            womans_self_defence_instructor womans_Self_Defence_Instructor = new womans_self_defence_instructor();
            womans_Self_Defence_Instructor.Show();
        }

        private void BTNbadminton_instructor_Click(object sender, EventArgs e)
        {
            badminton_instructor badminton_Instructor = new badminton_instructor();
            badminton_Instructor.Show();
        }
    }
}
