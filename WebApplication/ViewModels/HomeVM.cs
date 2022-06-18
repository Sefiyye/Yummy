using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.ViewModels
{
    public class HomeVM
    {
        public Slider Sliders { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
        public Setting Settings { get; set; }
        public About Abouts { get; set; }
        public List<AboutList> AboutLists { get; set; }
        public List<Card> Cards { get; set; }
        public Question Questions { get; set; }
        public List<Chef> Chefs { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
