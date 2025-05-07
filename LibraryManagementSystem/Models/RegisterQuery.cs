using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LibraryManagementSystem.Models
{
    public class RegisterQuery
    {
        private DBConnection db = new DBConnection();

        public bool IsUsernameTaken(string username)
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT COUNT(*) FROM users WHERE username = @username";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@username", username.Trim());
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public void RegisterUser(string email, string username, string password)
        {
            try
            {
                db.OpenConnection();
                string query = "INSERT INTO users (email, username, password, date_register) VALUES (@email, @username, @password, @date)";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@email", email.Trim());
                    cmd.Parameters.AddWithValue("@username", username.Trim());
                    cmd.Parameters.AddWithValue("@password", password.Trim());
                    cmd.Parameters.AddWithValue("@date", DateTime.Today.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
