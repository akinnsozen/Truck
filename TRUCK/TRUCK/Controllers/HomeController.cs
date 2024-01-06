using Microsoft.AspNetCore.Mvc;

namespace TRUCK.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
