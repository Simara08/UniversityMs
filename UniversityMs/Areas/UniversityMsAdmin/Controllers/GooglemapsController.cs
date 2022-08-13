using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UniversityMs.DAL;
using UniversityMs.Models;

namespace UniversityMs.Areas.UniversityMsAdmin.Controllers
{
    [Authorize]
    [Area("UniversityMsAdmin")]
    public class GooglemapsController : Controller
    {
        private readonly AppDbContext _context;

        public GooglemapsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: UniversityMsAdmin/Googlemaps
        public async Task<IActionResult> Index()
        {
            return View(await _context.Maps.ToListAsync());
        }

        // GET: UniversityMsAdmin/Googlemaps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityMsAdmin/Googlemaps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Link,ViewLink")] Googlemap googlemap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(googlemap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(googlemap);
        }

        // GET: UniversityMsAdmin/Googlemaps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var googlemap = await _context.Maps.FindAsync(id);
            if (googlemap == null)
            {
                return NotFound();
            }
            return View(googlemap);
        }

        // POST: UniversityMsAdmin/Googlemaps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Link,ViewLink")] Googlemap googlemap)
        {
            if (id != googlemap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(googlemap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GooglemapExists(googlemap.Id))
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
            return View(googlemap);
        }

        // GET: UniversityMsAdmin/Googlemaps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var googlemap = await _context.Maps
                .FirstOrDefaultAsync(m => m.Id == id);
            if (googlemap == null)
            {
                return NotFound();
            }

            return View(googlemap);
        }

        // POST: UniversityMsAdmin/Googlemaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var googlemap = await _context.Maps.FindAsync(id);
            _context.Maps.Remove(googlemap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GooglemapExists(int id)
        {
            return _context.Maps.Any(e => e.Id == id);
        }
    }
}
