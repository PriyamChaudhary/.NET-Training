using Microsoft.AspNetCore.Mvc;
using StudentPortal.Services;

namespace StudentPortal.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public IActionResult Add(int num1, int num2)
        {
            int result = _calculatorService.Add(num1, num2);
            return Content("Sum = " + result);
        }

        public IActionResult Multiply(int num1, int num2)
        {
            int result = _calculatorService.Multiply(num1, num2);
            return Content("Product = " + result);
        }
    }
}
