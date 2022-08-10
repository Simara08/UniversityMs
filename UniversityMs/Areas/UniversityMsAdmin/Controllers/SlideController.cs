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
    [Area("UniversityMsAdmin")]
    public class SlideController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public SlideController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Slides.ToListAsync());
        }

        private string UploadedFile(Slide sld)
        {
            string uniqueFileName = null;

            if (sld.Photo != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "assets/img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + sld.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    sld.Photo.CopyTo(fileStream);
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
        public async Task<IActionResult> Create(Slide slide)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(slide);

                slide.Image = uniqueFileName;

                _context.Add(slide);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return BadRequest();
        //    }
        //    var slider = _context.Slides.Find(id);
        //    if (slider == null)
        //    {
        //        return NotFound();
        //    }
        //    var path = Helper.GetPath(_env.WebRootPath, "img", slider.Image);
        //    if (System.IO.File.Exists(path))
        //    {
        //        System.IO.File.Delete(path);
        //    }
        //    _context.Slides.Remove(slider);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var slide = await _context.Slides.FindAsync(id);
            if (slide == null)
            {
                return NotFound();
            }
            return View(slide);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Slide sld, int? id)
        {
            if (id != sld.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldslide = await _context.Slides.FindAsync(id);
                    string path = Path.Combine(_env.WebRootPath, "img", oldslide.Image);

                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }


                    string uniqueFileName = UploadedFile(sld);

                    oldslide.Image = uniqueFileName;
                    oldslide.Imagetitle = sld.Imagetitle;
                    oldslide.ImgDesctrip = sld.ImgDesctrip;
                    _context.Update(oldslide);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlidesExists(sld.Id))
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

            var slides = await _context.Slides
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slides == null)
            {
                return NotFound();
            }

            return View(slides);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {




            var slides = await _context.Slides.FindAsync(id);
            _context.Slides.Remove(slides);


            string path = Path.Combine(_env.WebRootPath, "img", slides.Image);


            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool SlidesExists(int id)
        {
            return _context.Slides.Any(e => e.Id == id);
        }
    }
}
