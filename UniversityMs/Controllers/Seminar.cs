using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Seminar : Controller
    {
        public AppDbContext _context { get; }
        public Seminar(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            SeminarVM semimar = new SeminarVM
            {
                Seminar=_context.Seminar.ToList()
            };
            return View(semimar);
        }
    }
}
