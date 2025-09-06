using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Email = "deniztugce299@gmail.com";
            ViewBag.Phone = "+90 535 474 5841";
            ViewBag.Instagram = "https://instagram.com/tugceedeenizz";
            ViewBag.GitHub = "https://github.com/Tugce-hub";
            ViewBag.LinkedIn = "https://www.linkedin.com/in/tuğçe-deniz-869b5a310";
            return View();
        }
    }
}
