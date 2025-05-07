using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryManagementSystem.Models
{
    public class UserQuery
    {
        private DBConnection db = new DBConnection();

        public bool Login(string username, string password)
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM users WHERE username = @username AND password = @password";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@username", username.Trim());
                    cmd.Parameters.AddWithValue("@password", password.Trim());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    return table.Rows.Count > 0;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
