using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.IO;

namespace LibraryManagementSystem.Controllers
{
    public class BookController
    {
        private readonly BookRepository bookRepo = new BookRepository();
        private readonly string imageSaveDirectory = @"E:\LibraryManagementSystem\LibraryManagementSystem\Books_Directory";

        public List<BookModel> GetAllBooks()
        {
            return bookRepo.GetAllBooks();
        }

        public void AddBook(BookModel book, string imagePath)
        {
            string fileName = book.BookTitle + book.Author + ".jpg";
            string savePath = Path.Combine(imageSaveDirectory, fileName);
            Directory.CreateDirectory(Path.GetDirectoryName(savePath));
            File.Copy(imagePath, savePath, true);
            book.ImagePath = savePath;

            bookRepo.AddBook(book);
        }

        public void UpdateBook(BookModel book)
        {
            bookRepo.UpdateBook(book);
        }

        public void DeleteBook(int id)
        {
            bookRepo.DeleteBook(id);
        }
    }
}
