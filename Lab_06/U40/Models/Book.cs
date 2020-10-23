using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U40.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "Pham", Author = "Tuaan", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 2, Title = "Thanh", Author = "Nghi", CoverImage = "Assets/2.jpg" });
            books.Add(new Book { BookId = 3, Title = "Nghi", Author = "Loan", CoverImage = "Assets/3.jpg" });
            books.Add(new Book { BookId = 4, Title = "Bug", Author = "Fix", CoverImage = "Assets/4.jpg" });
            books.Add(new Book { BookId = 5, Title = "Pham", Author = "Tuaan", CoverImage = "Assets/5.jpg" });
            books.Add(new Book { BookId = 6, Title = "Pham", Author = "Tuaan", CoverImage = "Assets/6.jpg" });
            books.Add(new Book { BookId = 7, Title = "Pham", Author = "Tuaan", CoverImage = "Assets/7.jpg" });
            books.Add(new Book { BookId = 8, Title = "Pham", Author = "Tuaan", CoverImage = "Assets/8.jpg" });

            return books;
        }
    }
}
