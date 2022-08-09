﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;

namespace UniversityMs.ViewCompanent
{
    public class FooterViewComponent: ViewComponent
    {
        private AppDbContext _context { get; set; }
        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);
            return View(model);
        }
    }
}
