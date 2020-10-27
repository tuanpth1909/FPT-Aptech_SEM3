using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ConverImage { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "Train your Brain", Author = "Kawashima", ConverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 2, Title = "Why is sex fun", Author = "Diamond", ConverImage = "Assets/2.jpg" });
            books.Add(new Book { BookId = 3, Title = "Cân bằng cảm xúc cả lúc bão giông", Author = "Mecholls", ConverImage = "Assets/3.jpg" });
            books.Add(new Book { BookId = 4, Title = "Não bộ kể gì về bạn", Author = "Eagleman", ConverImage = "Assets/4.jpg" });
            books.Add(new Book { BookId = 5, Title = "Thuật đọc tâm", Author = "Enneagram", ConverImage = "Assets/5.jpg" });
            books.Add(new Book { BookId = 6, Title = "LeaderShip", Author = "Gell", ConverImage = "Assets/6.jpg" });
            books.Add(new Book { BookId = 7, Title = "Báo cáo tài chính", Author = "Thomas", ConverImage = "Assets/7.jpg" });

            return books;
        }
    }
}
