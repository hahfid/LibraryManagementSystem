using System;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
    public class LoginController
    {
        public bool Login(string username, string password, out string message)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                message = "Please fill all blank fields";
                return false;
            }

            try
            {
                UserQuery userQuery = new UserQuery();
                bool isLoginSuccess = userQuery.Login(username, password);

                if (isLoginSuccess)
                {
                    message = "Login Successfully!";
                    return true;
                }
                else
                {
                    message = "Incorrect Username/Password";
                    return false;
                }
            }
            catch (Exception ex)
            {
                message = "Error connecting to Database: " + ex.Message;
                return false;
            }
        }
    }
}
