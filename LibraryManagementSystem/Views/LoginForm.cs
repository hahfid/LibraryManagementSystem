using System;
using System.Windows.Forms;
using LibraryManagementSystem.Controllers;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        private LoginController loginController;

        public LoginForm()
        {
            InitializeComponent();
            loginController = new LoginController();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string message;
            bool isLoginSuccess = loginController.Login(login_username.Text, login_password.Text, out message);

            if (isLoginSuccess)
            {
                MessageBox.Show(message, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mForm = new MainForm();
                mForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // kode event handler lain tetap sama seperti semula...

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm rForm = new RegisterForm();
            rForm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
