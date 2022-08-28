using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.ViewModels;

namespace UniversityMs.Controllers
{
    public class ResearchTopic : Controller
    {
        public AppDbContext _context { get; }
        public ResearchTopic(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ResearchTopicVM rproject = new ResearchTopicVM
            {
                ResearchTopic = _context.ResearchTopic.ToList()
            };
            return View(rproject);
        }
    }
}
