using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.DAL;
using WebApplication.Extensions;
using WebApplication.Models;
using WebApplication.Utilities;

namespace WebApplication.Areas.WebApplicationAdmin.Controllers
{
    [Area("WebApplicationAdmin")]
    public class ChefController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ChefController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Chef> chef = await _context.Chefs.ToListAsync();
            return View(chef);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Detail(int id)
        {
            Chef chef = await _context.Chefs.FirstOrDefaultAsync(c => c.Id == id);
            if (chef == null) return NotFound();

            return View(chef);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Chef chef)
        {
            if (!ModelState.IsValid) return View();
            if (chef.Photo != null)
            {
                if (!chef.Photo.IsOkay(1))
                {
                    chef.Image = await chef.Photo.FileCreate(_env.WebRootPath, @"assets\img");
                    await _context.AddAsync(chef);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("Photo", "Please, choose image file under the 1 mb");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("Photo", "Please,choose file");
                return View();
            }
        }
        public async Task<IActionResult> Delete(int id)
        {
            Chef chef = await _context.Chefs.FirstOrDefaultAsync(s => s.Id == id);
            if (chef == null) return NotFound();
            return View(chef);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> DeleteChef(int id)
        {
            Chef chef = await _context.Chefs.FirstOrDefaultAsync(s => s.Id == id);
            _context.Chefs.Remove(chef);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            Chef chef = await _context.Chefs.FirstOrDefaultAsync(c => c.Id == id);
            if (chef == null) return NotFound();
            return View(chef);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(int id, Chef chef)
        {
            if (!ModelState.IsValid) return View();
            Chef existedChef = await _context.Chefs.FirstOrDefaultAsync(p => p.Id == id);
            if (chef.Photo != null)
            {
                if (!chef.Photo.IsOkay(1))
                {
                    string path = _env.WebRootPath + @"assets\img" + existedChef.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    existedChef.Image = await chef.Photo.FileCreate(_env.WebRootPath, @"assets\img");
                }
                else
                {
                    ModelState.AddModelError("Photo", "Please,choose photo under the 1 mb");
                    return View();
                }
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
