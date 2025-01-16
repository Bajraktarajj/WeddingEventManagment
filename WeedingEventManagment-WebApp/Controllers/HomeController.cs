using Microsoft.AspNetCore.Mvc;

namespace WeedingEventManagment_WebApp.Controllers
{
 //   [ApiController]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            
            if (email == "test@example.com" && password == "password123")
            {
               
                TempData["SuccessMessage"] = "Login successful!";
                return RedirectToAction("Index");
            }
            else
            {
               
                ViewBag.ErrorMessage = "Invalid email or password.";
                return View();
            }
        }

        public IActionResult Index()
        {

            return View();
        }



       
    }
}
