using System;
using System.Windows.Forms;
using System.Drawing;

namespace School_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tutorBtn_Click(object sender, EventArgs e)
        {
            bool isTutor = true;
            bool isAdmin = false;

            if (isTutor)
            {
                tutorBtn.Normalcolor = Color.Cyan;
                adminBtn.Normalcolor = Color.Gray;
                tutorBtn.OnHovercolor = Color.FromArgb(128, 255, 255);
                adminBtn.OnHovercolor = Color.White;
            }   
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            bool isAdmin = true;
            bool isTutor = false;

            if (isAdmin)
            {
                tutorBtn.Normalcolor = Color.Gray;
                adminBtn.Normalcolor = Color.Cyan;
                tutorBtn.OnHovercolor = Color.White;
                adminBtn.OnHovercolor = Color.FromArgb(128, 255, 255);
            }

            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            string msg = "Do you want to exit the application?";
            string title = "Exit";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;

            DialogResult result = MessageBox.Show(msg, title, button, icon);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string password = "0000";
            string username = "kelvin";

            loginErrorMsg.Text = "";

            if (string.IsNullOrEmpty(usernameInput.Text) || string.IsNullOrEmpty(passwordInput.Text))
            {
                loginErrorMsg.Show();
                loginErrorMsg.Text = "Please fill out both fields";
                return;
            }

            if (usernameInput.Text == username && passwordInput.Text == password)
            {
                Tutor_Dashboard tutor_Dashboard = new Tutor_Dashboard();
                this.Hide();
                tutor_Dashboard.Show();
            }
            else
            {
                loginErrorMsg.Show();
                loginErrorMsg.Text = "Invalid credentials. Please try again";
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {
            loginErrorMsg.Hide();
        }
    }
}
