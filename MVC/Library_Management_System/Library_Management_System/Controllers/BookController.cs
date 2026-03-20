using Microsoft.AspNetCore.Mvc;
using Library_Management_System.Repository;
namespace Library_Management_System.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _repository;
        public BookController(IBookRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Listbyprice(int price)
        {
            var res = _repository.ListByPrice(price);
            return Content(string.Join("\n", res.Select(b =>b.Id+" "+ b.BookName + " " + b.BookPrice)));
        }
        public IActionResult Listallbook()
        {
            var res = _repository.ListAllBook();
            return Content(string.Join("\n", res.Select(b => b.Id + " " + b.BookName + " " + b.BookPrice)));
        }
        public IActionResult Bookbyname(string name)
        {
            var res = _repository.BookByName(name);
            if (res is null) return Content("Book not found");
            return Content(string.Join("\n", res.Select(b => b.Id + " " + b.BookName + " " + b.BookPrice)));
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
