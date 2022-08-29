
using UniversityMs.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.Models;
using UniversityMs.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace UniversityMs.Areas.UniversityMsAdmin.Controllers
{
    public class Account : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public Account(UserManager<AppUser> userManager,
                                      SignInManager<AppUser> signInManager,
                                      RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }


        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            AppUser NewUser = new AppUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
            };
            var IdentityResult = await _userManager.CreateAsync(NewUser, model.Password);

            if (!IdentityResult.Succeeded)
            {
                foreach (var error in IdentityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
            await _userManager.AddToRoleAsync(NewUser, Role.RoleType.Student.ToString());
            await _signInManager.SignInAsync(NewUser, true);
            return RedirectToAction("Index", "Home");

        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginVM model)
        {
            AppUser user = await _userManager.Users.FirstOrDefaultAsync(x => !x.IsAdmin && x.UserName == model.Email);


            if (user == null)
            {
                ModelState.AddModelError("", "UserName or Password is not correct!");
                return View();
            }


            var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password,false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "UserName or Password is not correct!");
                return View();
            }

            if (!ModelState.IsValid)
                return View();

            return RedirectToAction( "Index" , "Home");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }
        //public async Task CreateRole()
        //{
        //    foreach (var role in Enum.GetValues(typeof(Role.RoleType)))
        //    {

        //        if (!await _roleManager.RoleExistsAsync(role.ToString()))
        //        {
        //            await _roleManager.CreateAsync(new IdentityRole { Name = role.ToString() });
        //        }

        //    }

        //}

    }
}
