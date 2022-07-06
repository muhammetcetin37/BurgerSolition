using Microsoft.AspNetCore.Mvc;

namespace Burger.Web.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
