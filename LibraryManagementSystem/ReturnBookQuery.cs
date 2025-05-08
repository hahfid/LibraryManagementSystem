using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public class ReturnBookQuery
    {
        private DBConnection db = new DBConnection();

        public bool ReturnBook(string issueID)
        {
            try
            {
                db.OpenConnection();

                string query = "UPDATE issues SET status = @status, date_update = @dateUpdate WHERE issue_id = @issueID";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@status", "Return");
                    cmd.Parameters.AddWithValue("@dateUpdate", DateTime.Today);
                    cmd.Parameters.AddWithValue("@issueID", issueID);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
