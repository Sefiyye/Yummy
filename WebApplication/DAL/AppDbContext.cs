using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.DAL
{

    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutList> AboutLists { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
