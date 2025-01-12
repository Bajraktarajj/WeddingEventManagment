using Microsoft.AspNetCore.Mvc;

namespace WeedingEventManagment_WebApp.Controllers
{
 //   [ApiController]
    public class HomeController : Controller
    {
      //  [HttpGet("index")]
        public IActionResult Index()
        {

            return View();
        }
    }
}
