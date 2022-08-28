
using UniversityMs.DAL;
using UniversityMs.Helpers;
using UniversityMs.Models;
using UniversityMs.ViewModels.UserViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityMs.ViewModels;

namespace UniversityMs.Areas.UniversityMsAdmin.Controllers
{
   
    [Area("UniversityMsAdmin")]
    public class UserController : Controller
    {   
        private AppDbContext _context { get; }
        
        private IWebHostEnvironment _env { get; }
        private UserManager<AppUser> _userManager { get; }
        private SignInManager<AppUser> _signInManager { get; }
        private RoleManager<IdentityRole> _roleManager { get; }


        public UserController(AppDbContext context, IWebHostEnvironment env, UserManager<AppUser> userManager,
                                      SignInManager<AppUser> signInManager,
                                      RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _env = env;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var user = _context.Users.Where(user => !user.IsDeleted).ToList();
            //
            return View(user);
        }
        public async Task<IActionResult> Delete(string Id)
        {
            if (Id == null)
            {
                return BadRequest();
            }
            AppUser userDb = _context.Users.Where(p => !p.IsDeleted).FirstOrDefault(p => p.Id == Id);
            if (userDb == null)
            {
                return NotFound();
            }
            userDb.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(CreateUserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            AppUser newuser = new AppUser
            {
                LastName = user.LastName,
                Email = user.Email,
                Adress = user.Adress,
                FirstName = user.FirstName,
                PhoneNum = user.PhoneNum,
                UserName=user.Email,
                DateofBirth = user.DateofBirth
                
            };
            var IdentityResult = await _userManager.CreateAsync(newuser, user.Password);
            if (!IdentityResult.Succeeded)
            {
                foreach (var error in IdentityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                  ModelState.AddModelError(string.Empty, "Invalid Register Attempt");
                return View(user);
            };
            //await _userManager.AddToRoleAsync(newuser, Role.RoleType.Student.ToString());
            await _signInManager.SignInAsync(newuser, true);
            return RedirectToAction("Index" , "User");
        }
     
        //[HttpPost]
        //[AutoValidateAntiforgeryToken]
        //public async Task<IActionResult> Create(CreateUserViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    AppUser NewUser = new AppUser
        //    {
        //        LastName = model.LastName,
        //        Email = model.Email,
        //        Adress = model.Adress,
        //        FirstName = model.FirstName,
        //        PhoneNum = model.PhoneNum
        //    };
        //    var IdentityResult = await _userManager.CreateAsync(NewUser, model.Password);

        //    if (!IdentityResult.Succeeded)
        //    {
        //        foreach (var error in IdentityResult.Errors)
        //        {   
        //            ModelState.AddModelError("", error.Description);
        //        }
        //        return View(model);
        //    }
        //    await _userManager.AddToRoleAsync(NewUser, Role.RoleType.Admin.ToString());
        //    await _signInManager.SignInAsync(NewUser, true);
        //    return RedirectToAction("Index");

        //}
    }
}