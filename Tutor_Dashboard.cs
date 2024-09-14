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

        private string selectedButton = "";
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
            //---------Starting the date and time function
            clockTimer.Interval = 1000;
            clockTimer.Start();


            accountPanel.Hide();
            dashboardPanel.BringToFront();
            accountPanel.SendToBack();
            accountPanel.Visible = false;
            updatePanel.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string msg = "Do you want to exit?";
            string title = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;

            DialogResult result = MessageBox.Show(msg, title, buttons, icon);

            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            string logoutMsg = "Are you sure you want to logout?";
            string title = "Logout";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            DialogResult result = MessageBox.Show(logoutMsg, title, buttons, icon);
            if (result == DialogResult.Yes)
            {
                Tutor_Dashboard tutor_dashboard = new Tutor_Dashboard();
                tutor_dashboard.Hide();
                Login login = new Login();
                login.Show();
            }
        }



        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            setDisplay("Dasboard");
        }

        private void accSettingBtn_Click(object sender, EventArgs e)
        {
            setDisplay("Account");
            
        }


        //--------Function displaying menu when button is clicked
        private void setDisplay(string menu)
        {
            selectedButton = menu;

            accountPanel.Hide();

            if(selectedButton == "Dashboard")
            {
                dashboardPanel.Show();
                accountPanel.Hide();
                dashBtn.Normalcolor = Color.CadetBlue;
            }
            else if(selectedButton == "Classes")
            {

            }
            else if( selectedButton == "Messages")
            {

            }
            else if(selectedButton == "Announcements")
            {

            }
            else if(selectedButton == "Account")
            {
                
               
                accountPanel.Show();
                accountPanel.BringToFront();
                accountPanel.Visible = true;
                accSettingBtn.Normalcolor = Color.CadetBlue;
                classBtn.Normalcolor= Color.FromArgb(12, 21, 30);
                examBtn.Normalcolor = Color.FromArgb(12, 21, 30);
                announcementBtn.Normalcolor = Color.FromArgb(12, 21, 30);
                messagesBtn.Normalcolor = Color.FromArgb(12, 21, 30);
                dashBtn.Normalcolor = Color.FromArgb(12, 21, 30);
            }
        }

        private void updateAccountBtn_Click(object sender, EventArgs e)
        {
            

            string name = nameInput.Text;
            string gender = genderInput.Text;
            string email = emailInput.Text;

            

            if (!string.IsNullOrEmpty(nameInput.Text) || !string.IsNullOrEmpty(genderInput.Text) || !string.IsNullOrEmpty(emailBox.Text))
            {
                updatePanel.Hide();
                nameBox.Text = name;
                genderBox.Text = gender;
                emailBox.Text = email;
                string msg = "Account Updated Successfully";
                string title = "Information";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result = MessageBox.Show(msg, title, button, icon);

            }
            else
            {
                updatePanel.Hide();
            }

            nameInput.Text = "";
            genderInput.Text = "";
            emailInput.Text = "";
        }

        private void editInfoBtn_Click(object sender, EventArgs e)
        {
            updatePanel.Show();
        }
    }
}
