using System;
using System.Windows.Forms;
using LibraryManagementSystem.Controllers;

namespace LibraryManagementSystem
{
    public partial class RegisterForm : Form
    {
        private RegisterController registerController;

        public RegisterForm()
        {
            InitializeComponent();
            registerController = new RegisterController();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string message;
            bool isRegisterSuccess = registerController.Register(register_email.Text, register_username.Text, register_password.Text, out message);

            if (isRegisterSuccess)
            {
                MessageBox.Show(message, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            LoginForm lForm = new LoginForm();
            lForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
        }
    }
}
