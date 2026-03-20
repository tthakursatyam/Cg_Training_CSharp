using System.Collections.Generic;
using Library_Management_System.Models;

namespace Library_Management_System.Repository
{
    public class BookRepository : IBookRepository
    {
        private Dictionary<int, Book> books = new Dictionary<int, Book>()
        {
            {1, new Book{ Id=1, BookName="CSharp", BookPrice=500 }},
            {2, new Book{ Id=2, BookName="DotNet", BookPrice=650 }},
            {3, new Book{ Id=3, BookName="MVC", BookPrice=700 }}
        };

        public List<Book> ListByPrice(int price)
        {
            List<Book> res = new List<Book>();

            foreach (var i in books)
            {
                if (i.Value.BookPrice > price)
                {
                    res.Add(i.Value);
                }
            }

            return res;
        }

        public List<Book> ListAllBook()
        {
            List<Book> res = new List<Book>();

            foreach (var i in books)
            {
                res.Add(i.Value);
            }

            return res;
        }

        public List<Book> BookByName(string name)
        {
            List<Book> res = new List<Book>();

            foreach (var i in books)
            {
                if (i.Value.BookName == name)
                    res.Add(i.Value);
            }

            return res;
        }
    }
}