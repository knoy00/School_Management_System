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
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (count >= 5)
            {
                Login login = new Login();
                this.Hide();
                login.Show();
                timer1.Stop();  
            }

            

        }
    }
}
