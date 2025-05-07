using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    class DataAddBooks
    {
        private DBConnection db = new DBConnection();
        private MySqlConnection connect;

        public int ID { set; get; }
        public string BookTitle { set; get; }
        public string Author { set; get; }
        public string Pulished { set; get; }
        public string image { set; get; }
        public string Status { set; get; }

        public List<DataAddBooks> addBooksData()
        {
            List<DataAddBooks> listData = new List<DataAddBooks>();
            connect = db.GetConnection();

            try
            {
                db.OpenConnection();

                string selectData = "SELECT * FROM books WHERE date_delete IS NULL";

                using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataAddBooks dab = new DataAddBooks();
                        dab.ID = Convert.ToInt32(reader["id"]);
                        dab.BookTitle = reader["book_title"].ToString();
                        dab.Author = reader["author"].ToString();
                        dab.Pulished = reader["published_date"].ToString();
                        dab.image = reader["image"].ToString();
                        dab.Status = reader["status"].ToString();

                        listData.Add(dab);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to Database: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return listData;
        }
    }
}
