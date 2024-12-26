using Microsoft.AspNetCore.Mvc;

namespace WeedingEventManagment_WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
