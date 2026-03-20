using Library_Management_System.Models;
namespace Library_Management_System.Repository
{
    public interface IBookRepository
    {
        public List<Book> ListByPrice(int price);
        public List<Book> ListAllBook();
        public List<Book> BookByName(string name);
    }
}
