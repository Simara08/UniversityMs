using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.Models;

namespace UniversityMs.Areas.UniversityMsAdmin.Controllers
{
    [Authorize]
    [Area("UniversityMsAdmin")]
    public class MezunController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public MezunController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Mezunlar.ToListAsync());
        }

        private string UploadedFile(Mezun grad)
        {
            string uniqueFileName = null;

            if (grad.Photo != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "assets/img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + grad.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    grad.Photo.CopyTo(fileStream);
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
        public async Task<IActionResult> Create(Mezun grad)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(grad);

                grad.Image = uniqueFileName;

                _context.Add(grad);
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
            var grad = await _context.Mezunlar.FindAsync(id);
            if (grad == null)
            {
                return NotFound();
            }
            return View(grad);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Mezun grad, int? id)
        {
            if (id != grad.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldgrad = await _context.Mezunlar.FindAsync(id);
                    string path = Path.Combine(_env.WebRootPath, "img", oldgrad.Image);

                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }


                    string uniqueFileName = UploadedFile(grad);

                    oldgrad.Image = uniqueFileName;
                    oldgrad.Title = grad.Title;
                    oldgrad.LeftImg = grad.LeftImg;
                    oldgrad.ImgTitle = grad.ImgTitle;
                    oldgrad.ImgDesc = grad.ImgDesc;
                    oldgrad.WikiLink = grad.WikiLink;
                    _context.Update(oldgrad);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MezunlarExists(grad.Id))
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

            var grad = await _context.Mezunlar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grad == null)
            {
                return NotFound();
            }

            return View(grad);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {




            var grad = await _context.Mezunlar.FindAsync(id);
            _context.Mezunlar.Remove(grad);


            string path = Path.Combine(_env.WebRootPath, "img", grad.Image);


            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool MezunlarExists(int id)
        {
            return _context.Mezunlar.Any(e => e.Id == id);
        }
    }
}
