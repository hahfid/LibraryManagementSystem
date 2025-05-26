 using MySql.Data.MySqlClient;
using System;

namespace LibraryManagementSystem.Models
{
    public class DashboardQuery
    {
        private DBConnection db = new DBConnection();

        public int CountAvailableBooks()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT COUNT(id) FROM books WHERE status = 'Available' AND date_delete IS NULL";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public int CountIssuedBooks()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT COUNT(id) FROM issues WHERE date_delete IS NULL";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public int CountReturnedBooks()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT COUNT(id) FROM issues WHERE status = 'Return' AND date_delete IS NULL";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
