using Calculator_Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_Services.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly CalculatorServices _calculator;
        public CalculatorController(CalculatorServices calculator)
        {
            _calculator = calculator;
        }
        public IActionResult Add(int a ,int b)
        {
            int result = _calculator.Add(a,b);
            return Content("Addition = " + result);

        }
        public IActionResult Sub(int a, int b)
        {
            int result = _calculator.Sub(a,b);
            return Content("Substraction = " + result);

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
