using Library_Management_System.Models;
using Library_Management_System.Data;

namespace Library_Management_System.Repository
{
    public class SqlBookRepository : IBookRepository
    {
        private readonly AppDbContext _context;

        public SqlBookRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Book> ListAllBook()
        {
            return _context.Books.ToList();
        }

        public List<Book> ListByPrice(int price)
        {
            return _context.Books
                .Where(b => b.BookPrice > price)
                .ToList();
        }

        public List<Book> BookByName(string name)
        {
            return _context.Books
                .Where(b => b.BookName == name)
                .ToList();
        }
    }
}