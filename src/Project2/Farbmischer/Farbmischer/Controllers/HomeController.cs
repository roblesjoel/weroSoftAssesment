using FarbmisherLib;
using Microsoft.AspNetCore.Mvc;

namespace Farbmischer.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index(int red, int green, int blue)
        {
            ColorMixer.Red = red;
            ColorMixer.Green = green;
            ColorMixer.Blue = blue;

            ViewBag.red = ColorMixer.Red;
            ViewBag.green = ColorMixer.Green;
            ViewBag.blue = ColorMixer.Blue;
            ViewBag.startup = ColorMixer.Startup;
            ViewBag.appTitle = ColorMixer.windowName;

            if (ColorMixer.Startup)
            {
                ColorMixer.unSetStartup();
            }

            return View();
        }
    }
}
