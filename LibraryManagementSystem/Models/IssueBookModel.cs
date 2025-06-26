using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;

namespace LibraryManagementSystem.Models
{
    public class IssueBooksModel
    {
        private readonly DBConnection db = new DBConnection();

        public List<DataIssueBooks> GetAllIssues()
        {
            DataIssueBooks dib = new DataIssueBooks();
            return dib.IssueBooksData();
        }

        public DataTable GetAvailableBooks()
        {
            db.OpenConnection();
            string query = "SELECT id, book_title FROM books WHERE status = 'Available' AND date_delete IS NULL";

            using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public Image GetBookImageById(int id)
        {
            db.OpenConnection();
            string query = "SELECT image FROM books WHERE id = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        string imagePath = table.Rows[0]["image"].ToString();
                        if (File.Exists(imagePath))
                            return Image.FromFile(imagePath);
                    }
                }
            }

            return null;
        }

        public void InsertIssue(string id, string name, string contact, string email, string bookTitle,
                                string status, DateTime issueDate, DateTime returnDate)
        {
            db.OpenConnection();
            string query = @"INSERT INTO issues 
                            (issue_id, name, contact, email, book_title, status, issue_date, return_date, date_insert) 
                            VALUES 
                            (@issueID, @name, @contact, @email, @bookTitle, @status, @issueDate, @returnDate, @dateInsert)";

            using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@issueID", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@bookTitle", bookTitle);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@issueDate", issueDate);
                cmd.Parameters.AddWithValue("@returnDate", returnDate);
                cmd.Parameters.AddWithValue("@dateInsert", DateTime.Today);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateIssue(string id, string name, string contact, string email, string bookTitle,
                                string status, DateTime issueDate, DateTime returnDate)
        {
            db.OpenConnection();
            string query = @"UPDATE issues 
                            SET name = @name, contact = @contact, email = @email, book_title = @bookTitle, 
                                status = @status, issue_date = @issueDate, return_date = @returnDate, 
                                date_update = @dateUpdate 
                            WHERE issue_id = @issueID";

            using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@issueID", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@bookTitle", bookTitle);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@issueDate", issueDate);
                cmd.Parameters.AddWithValue("@returnDate", returnDate);
                cmd.Parameters.AddWithValue("@dateUpdate", DateTime.Today);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteIssue(string id)
        {
            db.OpenConnection();
            string query = "UPDATE issues SET date_delete = @dateDelete WHERE issue_id = @issueID";

            using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@issueID", id);
                cmd.Parameters.AddWithValue("@dateDelete", DateTime.Today);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
