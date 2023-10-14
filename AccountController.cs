using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StokTakip2023.Controllers
{
    public class AccountController : Controller
    {
        UserManager um = new UserManager(new EfUserRepository());
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserTable p)
        {

            UserValidator uv = new UserValidator();
            ValidationResult results = uv.Validate(p);
            bool isExist = false;
            UserTable userEmail = um.GetList().Where(x => x.UserName.Trim().ToLower() == p.UserName.Trim().ToLower()).FirstOrDefault();

            if (userEmail != null)
            {
                isExist = true;
            }
            if (results.IsValid && isExist == false)
            {
                p.Role = "User";
                p.UserName = p.UserName.Trim().ToLower().Replace(" ", string.Empty);
                p.Password = p.Password.Trim();
                um.TAdd(p);
                TempData["SuccessMessage"] = "Kaydınız başarıyla oluşturuldu.";
                return RedirectToAction("Login", "Account");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                if (isExist)
                {
                    ModelState.AddModelError("Exist", "Bu kullanıcı adı daha önce kullanılmış.");
                }
                else
                {
                    ModelState.AddModelError("PassError", "Şifre 6 karatkerden uzun olmalıdır.");
                }
            }
            return View();
        }
        public IActionResult Login()
        {
            if (!User.Identity.IsAuthenticated)
            {
                if (TempData["SuccessMessage"] != null)
                {
                    ViewBag.SuccessMessage = TempData["SuccessMessage"].ToString();
                }
                return View();
            }
            else
                return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserTable p)
        {

            UserTable user = um.GetList().Where(x => x.UserName.Trim().ToLower() == p.UserName.Trim().ToLower()).FirstOrDefault();
            if (user != null)
            {
                p.Role = um.GetList().FirstOrDefault(x => x.UserName.Trim().ToLower() == p.UserName.Trim().ToLower()).Role;
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,p.UserName.Trim().ToLower()),
                        new Claim(ClaimTypes.Role,p.Role)
                    };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("BadPass", "Kullanıcı adı veya şifre yanlış !.");
                return View();
            }
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return LocalRedirect("/");
        }
    }
}
