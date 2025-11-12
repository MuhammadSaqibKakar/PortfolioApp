using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Certificates()
        {
            return View();
        }

        public IActionResult Experiences()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
