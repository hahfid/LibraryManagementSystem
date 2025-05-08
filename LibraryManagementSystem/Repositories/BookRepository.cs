using LibraryManagementSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Repositories
{
    public class BookRepository
    {
        private readonly DBConnection db;

        public BookRepository()
        {
            db = new DBConnection();
        }

        public List<BookModel> GetAllBooks()
        {
            var books = new List<BookModel>();

            try
            {
                db.OpenConnection();
                var conn = db.GetConnection();

                string query = "SELECT * FROM books WHERE date_delete IS NULL";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        books.Add(new BookModel
                        {
                            Id = reader.GetInt32("id"),
                            BookTitle = reader.GetString("book_title"),
                            Author = reader.GetString("author"),
                            PublishedDate = reader.GetDateTime("published_date"),
                            Status = reader.GetString("status"),
                            ImagePath = reader.GetString("image")
                        });
                    }
                }
            }
            finally
            {
                db.CloseConnection();
            }

            return books;
        }

        public void AddBook(BookModel book)
        {
            try
            {
                db.OpenConnection();
                var conn = db.GetConnection();

                string query = "INSERT INTO books (book_title, author, published_date, status, image, date_insert) " +
                               "VALUES (@title, @auth, @pub, @status, @img, @insert)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", book.BookTitle);
                    cmd.Parameters.AddWithValue("@auth", book.Author);
                    cmd.Parameters.AddWithValue("@pub", book.PublishedDate);
                    cmd.Parameters.AddWithValue("@status", book.Status);
                    cmd.Parameters.AddWithValue("@img", book.ImagePath);
                    cmd.Parameters.AddWithValue("@insert", DateTime.Today);

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public void UpdateBook(BookModel book)
        {
            try
            {
                db.OpenConnection();
                var conn = db.GetConnection();

                string query = "UPDATE books SET book_title = @title, author = @auth, " +
                               "published_date = @pub, status = @status, date_update = @update WHERE id = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", book.BookTitle);
                    cmd.Parameters.AddWithValue("@auth", book.Author);
                    cmd.Parameters.AddWithValue("@pub", book.PublishedDate);
                    cmd.Parameters.AddWithValue("@status", book.Status);
                    cmd.Parameters.AddWithValue("@update", DateTime.Today);
                    cmd.Parameters.AddWithValue("@id", book.Id);

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public void DeleteBook(int id)
        {
            try
            {
                db.OpenConnection();
                var conn = db.GetConnection();

                string query = "UPDATE books SET date_delete = @delete WHERE id = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@delete", DateTime.Today);
                    cmd.Parameters.AddWithValue("@id", id);

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
