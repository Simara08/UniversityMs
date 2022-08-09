using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class News : Controller
    {
        public AppDbContext _context { get;  }
        public News(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            NewsVM news = new NewsVM
            {
                Newspages=_context.Newspages.ToList()
            };
            return View(news);
        }
    }
}
