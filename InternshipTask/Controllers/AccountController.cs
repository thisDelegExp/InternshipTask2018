using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using InternshipTask.Models;
using InternshipTask.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace InternshipTask.Controllers
{
    public class AccountController : Controller
    {
        private UserContext context;

        public AccountController()
        {
            context=new UserContext{Users = new List<User>()};
            SampleData.InitializeAccount(context);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = context.Users.FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
                if (user != null)
                {
                    Authenticate(model.Email); 

                    return RedirectToAction("Main", "Analytics");
                }
                ModelState.AddModelError("", "Invalid login or password");
            }
            return View(model);
        }

        private void Authenticate(string userName)
        {

            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }



        /*User registration is currently disabled! Reason : new account gets deleted after logging out.
         Problem summary: new account gets deleted from context.Users by method above(see Logout() ) for unknown reason. 
         Assumption: using a real db and saving changes via Entity Framework could solve the problem.

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user =  context.Users.FirstOrDefault(u => u.Email == model.Email);
                if (user == null)
                {
                    
                    context.Users.Add(new User { Email = model.Email, Password = model.Password });
                    

                     Authenticate(model.Email); 

                    return RedirectToAction("Main", "Analytics");
                }
                else
                    ModelState.AddModelError("", "Invalid login or password");
            }
            return View(model);
        }*/

        
    }
}