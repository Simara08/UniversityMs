using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Prorektor : Controller
    {
        private AppDbContext _context { get; }

        public Prorektor(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ProrektorVM prorektor = new ProrektorVM
            {
                Prorektorlar = _context.Prorektorlar.ToList()
            };
            return View(prorektor);
        }
    }
}
