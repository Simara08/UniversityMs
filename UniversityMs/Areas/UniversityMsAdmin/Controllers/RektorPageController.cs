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
using RektorPage = UniversityMs.Models.RektorPage;

namespace UniversityMs.Areas.UniversityMsAdmin.Controllers
{
    //[Authorize]
    [Area("UniversityMsAdmin")]
    public class RektorPageController : Controller
    {

        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public RektorPageController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Rektorlar.ToListAsync());
        }

        private string UploadedFile(RektorPage rektor)
        {
            string uniqueFileName = null;

            if (rektor.Photo != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "assets/img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + rektor.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    rektor.Photo.CopyTo(fileStream);
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
        public async Task<IActionResult> Create(RektorPage rektor)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(rektor);

                rektor.Image = uniqueFileName;

                _context.Add(rektor);
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
            var rektor = await _context.Rektorlar.FindAsync(id);
            if (rektor == null)
            {
                return NotFound();
            }
            return View(rektor);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(RektorPage rektor, int? id)
        {
            if (id != rektor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldrektor = await _context.Rektorlar.FindAsync(id);
                    string path = Path.Combine(_env.WebRootPath, "img", oldrektor.Image);

                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }


                    string uniqueFileName = UploadedFile(rektor);

                    oldrektor.Image = uniqueFileName;
                    oldrektor.Title = rektor.Title;
                    oldrektor.Content = rektor.Content;
                    oldrektor.Wikilink = rektor.Wikilink;
                    _context.Update(oldrektor);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RektorlarExists(rektor.Id))
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

            var rektor = await _context.Rektorlar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rektor == null)
            {
                return NotFound();
            }

            return View(rektor);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {




            var rektor = await _context.Rektorlar.FindAsync(id);
            _context.Rektorlar.Remove(rektor);


            string path = Path.Combine(_env.WebRootPath, "img", rektor.Image);


            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool RektorlarExists(int id)
        {
            return _context.Rektorlar.Any(e => e.Id == id);
        }
    }
}
