using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using tutibody.DAL.Context;
using tutibody.DAL.Entities;
using System.Security.Claims;

namespace MyPortfolioUdemy.Controllers
{

    public class LoginController : Controller
    {
        TutibodyContext tutibodyContext = new TutibodyContext();


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        //[HttpPost]
        //public async Task<IActionResult> Index(Login p)
        //{
        //    // Veritabanındaki kullanıcıyı bulma
        //    var values = tutibodyContext.Logins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);

        //    // Eğer kullanıcı bulunursa
        //    if (values != null)
        //    {
        //        var claims = new List<Claim>()
        //{
        //    new Claim(ClaimTypes.Name, p.UserName)
        //};
        //        var useridentity = new ClaimsIdentity(claims, "Login");
        //        ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
        //        await HttpContext.SignInAsync(principal);
        //        return RedirectToAction("AboutList", "About");
        //    }
        //    else
        //    {
        //        // Hata mesajı döndürme
        //        ModelState.AddModelError(string.Empty, "Geçersiz kullanıcı adı veya şifre.");
        //        return View();
        //    }
        //}

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Login p)
        {
            var values = tutibodyContext.Logins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);

            if (values != null)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,p.UserName)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("AboutList", "About");
            }
            else
            {
                // Hata mesajı döndürme
                ModelState.AddModelError(string.Empty, "Geçersiz kullanıcı adı veya şifre.");
                return View();
            }

        }
        public async Task<IActionResult> CikisYap()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
    }
}
