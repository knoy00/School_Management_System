using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Tutor_Dashboard : Form
    {
        public Tutor_Dashboard()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeDate_Click(object sender, EventArgs e)
        {

        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string time = currentTime.ToString("MMMM dd yyyy - hh:mm:ss tt");
            timeDate.Text = time;
        }

        private void Tutor_Dashboard_Load(object sender, EventArgs e)
        {
            clockTimer.Interval = 1000;
            clockTimer.Start(); ;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
