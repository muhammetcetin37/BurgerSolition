using Microsoft.AspNetCore.Mvc;

namespace Burger.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
