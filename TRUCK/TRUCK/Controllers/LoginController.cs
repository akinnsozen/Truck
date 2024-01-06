using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using TRUCK.Core.Service;
using TRUCK.Model.Entities;
using TRUCK.Models.ViewModels;

namespace TRUCK.Controllers
{
    public class LoginController : Controller
    {
        private readonly ICoreService<AdminUser> _db;

        public LoginController(ICoreService<AdminUser> db)
        {
            _db = db;
        }
        public async Task<IActionResult> Login()
        {
            return View();
        }

       [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel lvm)
        {
            var result = _db.GetRecord(x => x.AdminUsername == lvm.AdminUsername && x.AdminPassword == lvm.AdminPassword);
            if(result != null)
            {
                var claims = new List<Claim>()
                {
                    new Claim("AdminUsername",result.AdminUsername),
                    new Claim("AdminPassword",result.AdminPassword),
                };
                var user = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(user);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "AdminMain", new {area="Admin"});//ADMİN PANELİNE GİDECEK
            }
            return View("Login");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index","Home");
        }

    }
}
