 using Microsoft.AspNetCore.Mvc;

namespace first.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult report()
        {
            return View();
        }
    }
}
