using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Rektor : Controller
    {
        private AppDbContext _context { get; }

        public Rektor(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            RektorVM rektor = new RektorVM 
            {
                Rektorlar=_context.Rektorlar.ToList()
            };
            return View(rektor);
        }
    }
}
