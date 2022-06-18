using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApplication.DAL;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Sliders = await _context.Sliders.FirstOrDefaultAsync(),
                SocialMedias = await _context.SocialMedias.ToListAsync(),
                Settings = await _context.Settings.FirstOrDefaultAsync(),
                Abouts = await _context.Abouts.FirstOrDefaultAsync(),
                AboutLists = await _context.AboutLists.ToListAsync(),
                Cards = await _context.Cards.ToListAsync(),
                Questions = await _context.Questions.FirstOrDefaultAsync(),
                Chefs = await _context.Chefs.ToListAsync(),
                Contacts = await _context.Contacts.ToListAsync(),
            };
            return View(model);
        }
    }
}
