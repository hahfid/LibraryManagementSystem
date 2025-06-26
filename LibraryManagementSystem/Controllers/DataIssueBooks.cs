using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public class DataIssueBooks
    {
        private DBConnection db = new DBConnection();
        private MySqlConnection connect;

        public int ID { set; get; }
        public string IssueID { set; get; }
        public string Name { set; get; }
        public string Contact { set; get; }
        public string Email { set; get; }
        public string BookTitle { set; get; }
        
        public string DateIssue { set; get; }
        public string DateReturn { set; get; }
        public string Status { set; get; }

        public List<DataIssueBooks> IssueBooksData()
        {
            List<DataIssueBooks> listData = new List<DataIssueBooks>();
            connect = db.GetConnection();

            try
            {
                db.OpenConnection();

                string selectData = "SELECT * FROM issues WHERE date_delete IS NULL";

                using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataIssueBooks dib = new DataIssueBooks();
                        dib.ID = Convert.ToInt32(reader["id"]);
                        dib.IssueID = reader["issue_id"].ToString();
                        dib.Name = reader["name"].ToString();
                        dib.Contact = reader["contact"].ToString();
                        dib.Email = reader["email"].ToString();
                        dib.BookTitle = reader["book_title"].ToString();
                        
                        dib.DateIssue = reader["issue_date"].ToString();
                        dib.DateReturn = reader["return_date"].ToString();
                        dib.Status = reader["status"].ToString();

                        listData.Add(dib);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return listData;
        }

        public List<DataIssueBooks> ReturnIssueBooksData()
        {
            List<DataIssueBooks> listData = new List<DataIssueBooks>();
            connect = db.GetConnection();

            try
            {
                db.OpenConnection();

                string selectData = "SELECT * FROM issues WHERE status = 'Not Return' AND date_delete IS NULL";

                using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataIssueBooks dib = new DataIssueBooks();
                        dib.ID = Convert.ToInt32(reader["id"]);
                        dib.IssueID = reader["issue_id"].ToString();
                        dib.Name = reader["name"].ToString();
                        dib.Contact = reader["contact"].ToString();
                        dib.Email = reader["email"].ToString();
                        dib.BookTitle = reader["book_title"].ToString();

                        dib.DateIssue = reader["issue_date"].ToString();
                        dib.DateReturn = reader["return_date"].ToString();
                        dib.Status = reader["status"].ToString();

                        listData.Add(dib);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return listData;
        }
    }
}
