using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class Status : Controller
    {
        public AppDbContext _context { get; }
        public Status(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            StatusVM status = new StatusVM
            {
                Status=_context.Status.ToList()
            };
            return View(status);
        }
    }
}
