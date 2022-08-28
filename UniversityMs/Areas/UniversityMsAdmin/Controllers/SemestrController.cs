using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.Models;

namespace UniversityMs.Areas.UniversityMsAdmin.Controllers
{
    //[Authorize]
    [Area("UniversityMsAdmin")]
    public class SemestrController : Controller
    {

        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public SemestrController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Semestr.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Semestr semestr)
        {
            if (ModelState.IsValid)
            {
                _context.Add(semestr);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var semestr = await _context.Semestr.FindAsync(id);
            if (semestr == null)
            {
                return NotFound();
            }
            return View(semestr);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Semestr semestr, int? id)
        {
            if (id != semestr.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldsemestr = await _context.Semestr.FindAsync(id);
                    oldsemestr.SemestrNum = semestr.SemestrNum;
                    _context.Update(oldsemestr);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SemestrExists(semestr.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: AdminPanel/Services/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var semestr = await _context.Class
                .FirstOrDefaultAsync(m => m.Id == id);
            if (semestr == null)
            {
                return NotFound();
            }

            return View(semestr);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var semestr = await _context.Aboutpages.FindAsync(id);
            _context.Aboutpages.Remove(semestr);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool SemestrExists(int id)
        {
            return _context.Aboutpages.Any(e => e.Id == id);
        }
    }
}
