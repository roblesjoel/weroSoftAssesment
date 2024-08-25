using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class Calculator : Controller
    {
        [Route("calculator")]
        public IActionResult Index(string firstNumber, string secondNumber, string Cal)
        {
            int a = String.IsNullOrEmpty(firstNumber) ? 0 :Convert.ToInt32(firstNumber);
            int b = Convert.ToInt32(secondNumber);
            int c = 0;
            switch (Cal)
            {
                case "Add":
                    c = a + b;
                    break;
                case "Sub":
                    c = a - b;
                    break;
                case "Mul":
                    c = a * b;
                    break;
                case "Div":
                    c = a / b;
                    break;
            }
            ViewBag.firstNumber = a;
            ViewBag.secondNumber = b;
            ViewBag.Result = c;
            return View();
        }

        public ActionResult Calculate(string firstNumber, string secondNumber, string Cal)
        {
            int a = Convert.ToInt32(firstNumber);
            int b = Convert.ToInt32(secondNumber);
            int c = 0;
            switch (Cal)
            {
                case "Add":
                    c = a + b;
                    break;
                case "Sub":
                    c = a - b;
                    break;
                case "Mul":
                    c = a * b;
                    break;
                case "Div":
                    c = a / b;
                    break;
            }
            ViewBag.Result = c;
            return View("Index");
        }

    }
}
