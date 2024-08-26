using Microsoft.AspNetCore.Mvc;
using Project1ClassLib;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index(string color, int size, int weight)
        {
            //Set the values
            if (!String.IsNullOrEmpty(color))
            {
                CharRepresentation.Color = color;
            }
            CharRepresentation.Size = size;
            CharRepresentation.Weight = weight;

            // Set the values
            ViewData["color"] = CharRepresentation.Color;
            ViewData["size"] = CharRepresentation.Size;
            ViewData["weight"] = CharRepresentation.Weight;
            ViewData["appTitle"] = CharRepresentation.windowName;
            return View();
        }
    }
}
