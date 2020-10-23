using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBook.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ConverImage { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookID = 1, Title = "Sinh ra de song chu khong phai ton tai", Author = "Pham Tuan", ConverImage = "Assets/1.png" });
            books.Add(new Book { BookID = 2, Title = "Sinh ra de song chu khong phai ton tai", Author = "Pham Tuan", ConverImage = "Assets/2.png" });
            books.Add(new Book { BookID = 3, Title = "Sinh ra de song chu khong phai ton tai", Author = "Pham Tuan", ConverImage = "Assets/3.png" });
            books.Add(new Book { BookID = 4, Title = "Sinh ra de song chu khong phai ton tai", Author = "Pham Tuan", ConverImage = "Assets/4.png" });

            return books;
        }
    }
}
