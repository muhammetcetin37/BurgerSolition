using Burger.BL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Burger.Web.Controllers
{
    public class KategoriController : Controller
    {
        private readonly IKategoriManager manager;

        public KategoriController(IKategoriManager manager)
        {
            this.manager = manager;
        }
        public IActionResult Index()
        {
            var sonuc = manager.GetAll();
            return View(sonuc);
        }
    }
}
