using Microsoft.AspNetCore.Mvc;
using Student_Management_System_MVC__EF.Services;
using Student_Management_System_MVC__EF.Models;

namespace Student_Management_System_MVC__EF.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentServices _service;

        public StudentController(IStudentServices service)
        {
            _service = service;
        }

        public IActionResult Details(int id)
        {
            var student = _service.GetStudentById(id);
            return View(student);
        }
    }
}
