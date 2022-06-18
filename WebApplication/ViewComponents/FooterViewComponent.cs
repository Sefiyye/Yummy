using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.DAL;
using WebApplication.Models;
using WebApplication.ViewModels;

namespace WebApplication.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            Setting setting = await _context.Settings.FirstOrDefaultAsync();
            List<SocialMedia> socialMedias = await _context.SocialMedias.ToListAsync();
            HomeVM homeVM = new HomeVM
            {
                Settings = setting,
                SocialMedias = socialMedias
            };
            return View(homeVM);
        }
    }
}
