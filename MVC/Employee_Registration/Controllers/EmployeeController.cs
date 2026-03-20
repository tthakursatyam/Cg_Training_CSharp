using Microsoft.AspNetCore.Mvc;
using Employee_Registration.Data;
using Employee_Registration.Models;
namespace Employee_Registration.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeCreate _create;
        public EmployeeController(EmployeeCreate create)
        {
            _create = create;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(EmployeeInfo employee)
        {
            _create.AddEmployee(employee);

            return RedirectToAction("GetStudentData");
        }
    }
}
