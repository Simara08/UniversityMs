using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class AssigmentUser : Controller
    {
        public AppDbContext _context { get; }
        public AssigmentUser(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            AssigmentUsersVM asign = new AssigmentUsersVM
            {
                AssigmentUsers=_context.AssigmentUser.ToList()
            };
            return View(asign);
        }
    }
}
