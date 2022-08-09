using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.DAL;
using UniversityMs.Helpers;
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

            public IActionResult Index()
            {
                return View(_context.Slides);
            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create(Slide slide)
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                if (!slide.Photo.CheckFileSize(200))
                {
                    ModelState.AddModelError("Photo", "Image's max size must be less than 200kb");
                }
                if (!slide.Photo.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Photo", "Type of File must be image");
                    return View();
                }
                slide.Image = await slide.Photo.SaveFileAysnc(_env.WebRootPath, "img");
                await _context.Slides.AddAsync(slide);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return BadRequest();
                }
                var slider = _context.Slides.Find(id);
                if (slider == null)
                {
                    return NotFound();
                }
                var path = Helper.GetPath(_env.WebRootPath, "img", slider.Image);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                _context.Slides.Remove(slider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            public async Task<IActionResult> Update(int? id)
            {
                if (id == null)
                {
                    return BadRequest();
                }
                //Slide  slide = await _context.SaveChangesAsync();
                Slide slide = _context.Slides.Find(id);
                if (slide == null)
                {
                    return NotFound();
                }
                return View(slide);
            }
            [HttpPost]
            public async Task<IActionResult> Update(Slide sld, int? id)
            {
                if (id == null)
                {
                    return BadRequest();
                }
                Slide slideDb = _context.Slides.Find(id);
                if (slideDb == null)
                {
                    return NotFound();
                }
                sld.Image = await sld.Photo.SaveFileAysnc(_env.WebRootPath, "img");
                //Slide s = _context.Slides.Where(s => s.Id == sld.Id).FirstOrDefault();
                //s.Url = sld.Url;
                var pathDb = Helper.GetPath(_env.WebRootPath, "img", slideDb.Image);
                if (System.IO.File.Exists(pathDb))
                {
                    System.IO.File.Delete(pathDb);
                }
                slideDb.Image = sld.Image;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Slide");
            }
        }
}
