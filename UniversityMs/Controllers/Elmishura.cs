using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Elmishura : Controller
    {
        private AppDbContext _context { get; }

        public Elmishura(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ElmishuraVM elmi = new ElmishuraVM
            {
                Elmishuralar=_context.Elmishuralar.ToList()
            };
            return View(elmi);
        }
    }
}
