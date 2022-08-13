
using AnimaLove.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.Models;
using UniversityMs.ViewModels;

namespace AnimaLove.Controllers
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
                Email = model.Email,
                LastName = model.LastName,
                FirstName =model.FirstName,
            };
            var IdentityResult =  await _userManager.CreateAsync(NewUser, model.Password);
            
            if (!IdentityResult.Succeeded)
            {
                foreach (var error in IdentityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
            await _userManager.AddToRoleAsync(NewUser, Role.RoleType.Admin.ToString());
           await _signInManager.SignInAsync(NewUser, true);
            return RedirectToAction("Index","Home");

        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginVM model)
        {
           AppUser DbUser= await _userManager.FindByEmailAsync(model.Email);
            if (DbUser==null)   
            {
                ModelState.AddModelError("", "Email or password is wrong!");
                return View(model);
            }
            AppUser newModel = new AppUser {
                Email = model.Email
            };
            var signInResult =
                 await _signInManager.PasswordSignInAsync(DbUser.Email, model.Password, model.isPersistent,lockoutOnFailure: true);
            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Prease try again later!");
                return View(model);
            }
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or password is wrong!");
                return View(model);

            }
            return RedirectToAction("Index", "Home");
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
