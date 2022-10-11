using Microsoft.AspNetCore.Mvc;

namespace Merca_Darius_Lab1.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return Content("Welcome");
        }

        public IActionResult Salut()
        {
            return Content("Bune venit draga utilizator!");
        }

        public IActionResult Varsta(string nume, int ani)
        {
            return Content("Persoana cu numele " + nume + " are " + ani + " ani!");
        }
    }
}
