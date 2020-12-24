using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using norcam.Models;
using norcam.Data;
using Microsoft.AspNetCore.Identity;

namespace norcam.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _um;
        private readonly SignInManager<IdentityUser> _sim;
        public AdminController(UserManager<IdentityUser> um, SignInManager<IdentityUser> sim)
        {
            _um = um;
            _sim = sim;
        }


        public IActionResult Loginadm()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _sim.SignOutAsync();

            return RedirectToAction("index", "home");
        }

        [HttpPost]
        public IActionResult Loginadm(string correo, string password)
        {
            var result = _sim.PasswordSignInAsync(correo, password, false, false).Result;

            if (result.Succeeded) {
                return RedirectToAction("index", "Ordenes");
            } 

            ModelState.AddModelError("", "Correo y/o contraseña incorrectos");

            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(string correo, string lastname, string password)
        {
            var user = new IdentityUser();
            user.UserName = lastname;
            user.Email = correo;
            

            var result = _um.CreateAsync(user, password).Result;

            if (result.Succeeded) {
                return RedirectToAction("Index", "Ordenes");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View();
        }





        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
