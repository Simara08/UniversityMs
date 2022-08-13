using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.Controllers;
using UniversityMs.DAL;
using UniversityMs.Migrations;
using UniversityMs.Models;
using Prorektorpage = UniversityMs.Models.Prorektorpage;

namespace UniversityMs.Areas.UniversityMsAdmin.Controllers
{
    [Authorize]
    [Area("UniversityMsAdmin")]
    public class ProrektorpageController : Controller
    {

        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public ProrektorpageController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Prorektorlar.ToListAsync());
        }

        private string UploadedFile(Prorektorpage prorektor)
        {
            string uniqueFileName = null;

            if (prorektor.Photo != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "assets/img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + prorektor.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    prorektor.Photo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Prorektorpage prorektor)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(prorektor);

                prorektor.Image = uniqueFileName;

                _context.Add(prorektor);
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
            var prorektor = await _context.Prorektorlar.FindAsync(id);
            if (prorektor == null)
            {
                return NotFound();
            }
            return View(prorektor);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Prorektorpage prorektor, int? id)
        {
            if (id != prorektor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldprorektor = await _context.Prorektorlar.FindAsync(id);
                    string path = Path.Combine(_env.WebRootPath, "img", oldprorektor.Image);

                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }


                    string uniqueFileName = UploadedFile(prorektor);

                    oldprorektor.Image = uniqueFileName;
                    oldprorektor.Title = prorektor.Title;
                    oldprorektor.Content = prorektor.Content;
                    oldprorektor.Wikilink = prorektor.Wikilink;
                    _context.Update(oldprorektor);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProrektorlarExists(prorektor.Id))
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

            var prorektor = await _context.Prorektorlar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prorektor == null)
            {
                return NotFound();
            }

            return View(prorektor);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {




            var prorektor = await _context.Prorektorlar.FindAsync(id);
            _context.Prorektorlar.Remove(prorektor);


            string path = Path.Combine(_env.WebRootPath, "img", prorektor.Image);


            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool ProrektorlarExists(int id)
        {
            return _context.Prorektorlar.Any(e => e.Id == id);
        }
    }
}
