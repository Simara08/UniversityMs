using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.Models;

namespace UniversityMs.Areas.UniversityMsAdmin.Controllers
{

        [Area("UniversityMsAdmin")]
        public class UserRolesController : Controller
        {
            private AppDbContext _context { get; }
            private IEnumerable<AppUser> users;
            private IWebHostEnvironment _env { get; }
            private UserManager<AppUser> _userManager { get; }
            private SignInManager<AppUser> _signInManager { get; }
            private RoleManager<IdentityRole> _roleManager { get; }


        public UserRolesController(AppDbContext context, IWebHostEnvironment env, UserManager<AppUser> userManager,
                                          SignInManager<AppUser> signInManager,
                                          RoleManager<IdentityRole> roleManager)
            {
                _context = context;
                users = _context.Users.Where(u => !u.IsDeleted);
                _env = env;
                _userManager = userManager;
                _signInManager = signInManager;
                _roleManager = roleManager;
            }

            public IActionResult Index()
            {
                return View(users);
            }
        }
}

