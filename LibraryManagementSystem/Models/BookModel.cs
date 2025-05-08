using System;

namespace LibraryManagementSystem.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Status { get; set; }
        public string ImagePath { get; set; }
        public DateTime? DateInsert { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateDelete { get; set; }
    }
}
