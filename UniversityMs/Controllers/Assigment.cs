using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Assigment : Controller
    {
        public AppDbContext _context { get; }
        public Assigment(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            AssigmentVM assign = new AssigmentVM
            {
                Assigment = _context.Assigments.ToList()
            };
            return View(assign);
        }
    }
}
