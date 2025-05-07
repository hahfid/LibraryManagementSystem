using System;
using System.Data;
using System.Windows.Forms;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
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

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (register_email.Text == "" || register_username.Text == "" || register_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    RegisterQuery registerQuery = new RegisterQuery();

                    if (registerQuery.IsUsernameTaken(register_username.Text))
                    {
                        MessageBox.Show(register_username.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        registerQuery.RegisterUser(
                            register_email.Text,
                            register_username.Text,
                            register_password.Text
                        );

                        MessageBox.Show("Register successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoginForm lForm = new LoginForm();
                        lForm.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
