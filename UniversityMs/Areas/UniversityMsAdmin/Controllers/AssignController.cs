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
    public class AssignController : Controller
    {

        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public AssignController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Assigment.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Assigment assign)
        {
            if (ModelState.IsValid)
            {
                _context.Add(assign);
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
            var assign = await _context.Assigment.FindAsync(id);
            if (assign == null)
            {
                return NotFound();
            }
            return View(assign);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Assigment assign, int? id)
        {
            if (id != assign.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldassign = await _context.Assigment.FindAsync(id);
                    oldassign.Date = assign.Date;
                    oldassign.link = assign.link;
                    oldassign.Mark = assign.Mark;
                    _context.Update(oldassign);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssigmentExists(assign.Id))
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

            var assign = await _context.Class
                .FirstOrDefaultAsync(m => m.Id == id);
            if (assign == null)
            {
                return NotFound();
            }

            return View(assign);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assign = await _context.Aboutpages.FindAsync(id);
            _context.Aboutpages.Remove(assign);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool AssigmentExists(int id)
        {
            return _context.Aboutpages.Any(e => e.Id == id);
        }
    }
}
