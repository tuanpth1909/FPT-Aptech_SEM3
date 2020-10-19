using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Data.Models
{
    public class Book
    {
        public int BookID { set; get; }

        public int Title { set; get; }

        public int Author { set; get; }

        public int CoverImage { set; get; }

    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookID = 1, Title = "Vuplate", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookID = 2, Title = "More Buying Choices", Author = "Futurum", CoverImage = "Assets/2.png" });
            books.Add(new Book { BookID = 3, Title = "Vuplate", Author = "Futurum", CoverImage = "Assets/3.png" });

            return books;
        }
    }
}
