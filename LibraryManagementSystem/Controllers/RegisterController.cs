using System;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
    public class RegisterController
    {
        public bool Register(string email, string username, string password, out string message)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                message = "Please fill all blank fields";
                return false;
            }

            try
            {
                RegisterQuery registerQuery = new RegisterQuery();

                if (registerQuery.IsUsernameTaken(username))
                {
                    message = username.Trim() + " is already taken";
                    return false;
                }
                else
                {
                    registerQuery.RegisterUser(email, username, password);
                    message = "Register successfully!";
                    return true;
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
