using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string HeaderLogo { get; set; }
        public string TwitterIcon { get; set; }
        public string FacebookIcon { get; set; }
        public string InstagramIcon { get; set; }
        public string LinkedinIcon { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
    }
}
