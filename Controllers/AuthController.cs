using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4guys_bs.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SQLitePCL;

namespace _4guys_bs.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        //public AuthController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager) {
        //    _userManager = userManager;
        //    _signInManager = signInManager;
        //}

        
        //GET: Register
        public IActionResult Register() {
            return View();
        }

        //POST: Register
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        
        

        //GET : Login
        public IActionResult Login() {
            return View();
        }

        // public ActionResult Login(User user) {
        //     if (user.Usn == "admin2003" && user.Psw == "2003") {
        //         return RedirectToAction("Admin", "Home");
        //     }
        //     ModelState.AddModelError("", "You do not have access with the Admin role, please try again.");
        //     return View(user);
        // }

        //POST: Login
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Login(LoginView models) {
        //     if (ModelState.IsValid) {
        //         var result = await _signInManager.PasswordSignInAsync(models.Mail, models.pwd, models.rememberme, lockoutOnFailure: false);
        //         if (result.Succeeded) {
        //             return RedirectToAction(nameof(HomeController.Index), "Home");
        //         } else {
        //             ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        //         }
        //     }
        //     return View(models);
        // }

        //POST: Logout
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Logout() {
        //     await _signInManager.SignOutAsync();
        //     return RedirectToAction(nameof(AuthController.Login), "Home");
        // }
    }
}

