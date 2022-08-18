using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Semestr : Controller
    {
        public AppDbContext _context { get; }
        public Semestr(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            SemestrVM semestr = new SemestrVM
            {
                Semestr=_context.Semestr.ToList()
            };
            return View(semestr);
        }
    }
}
