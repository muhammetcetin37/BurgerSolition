using Burger.BL.Abstract;
using Burger.Entities;
using Burger.Web.Models.DTOs;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Burger.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserManager manager;

        public UserController(IUserManager manager)
        {
            this.manager = manager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            if (ModelState.IsValid)
            {
                var user = manager.GetAll(p => p.Email == loginDTO.Email && p.Password == loginDTO.Password)
                                    .FirstOrDefault();

                if (user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,user.UserName),
                        new Claim(ClaimTypes.Email,user.Email),
                        new Claim(ClaimTypes.Role,user.Role)
                    };

                    var userIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(principal);

                    return RedirectToAction("Index", "Home", new { Area = "Admin" });
                }


            }

            return View(loginDTO);
        }





        [HttpGet]
        public IActionResult Register()
        {
            RegisterDTO dTO = new();

            return View(dTO);
        }




        [HttpPost]
        public IActionResult Register(RegisterDTO dTO)
        {
            if (ModelState.IsValid)
            {
                Kullanicilar yeniKullanici = new();
                yeniKullanici.Ad = dTO.Ad;
                yeniKullanici.Soyad = dTO.Soyad;
                yeniKullanici.Email = dTO.Email;
                yeniKullanici.Password = dTO.Password;
                yeniKullanici.Role = "User";
                yeniKullanici.UserName = dTO.UserName;
                manager.Add(yeniKullanici);
                return RedirectToAction("Login", "User");
            }

            return View(dTO);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}