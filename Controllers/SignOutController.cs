using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class SignOutController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.SignOutAsync(); // Veya Session.Clear() / FormsAuthentication.SignOut()

            // Google'a yönlendir
            return Redirect("https://www.google.com");
            return View();
        }
    }
}
