
using Microsoft.AspNetCore.Mvc;
using Student_Management_System_MVC__EF.Models;
using Student_Management_System_MVC__EF.Services;

namespace Student_Management_System_MVC__EF.Controllers
{
    public class AccountController : Controller
    {
        private readonly IStudentServices _service;

        public AccountController(IStudentServices service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student student)
        {
            var result = _service.ValidateStudent(student.Email, student.Password);

            if (result != null)
            {
                return RedirectToAction("Details", "Student", new { id = result.Id });
            }

            ViewBag.Error = "Invalid Email or Password";
            return View();
        }
    }
}
