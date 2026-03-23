using Microsoft.AspNetCore.Mvc;
using OnetoManyEFMVC.Models;
using OnetoManyEFMVC.Services;

namespace OnetoManyEFMVC.Controllers
{
    public class CollegeController : Controller
    {
        private readonly CollegeService _service;

        public CollegeController(CollegeService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetAllColleges());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CollegeMaster college, string hostelName, double amount, string paymentMode)
        {
            college.Hostels = new List<Hostel>()
            {
                new Hostel { HostelName = hostelName }
            };

            college.Payments = new List<PaymentDetails>()
            {
                new PaymentDetails { Amount = amount, PaymentMode = paymentMode }
            };

            _service.AddCollege(college);

            return RedirectToAction("Index");
        }
    }
}