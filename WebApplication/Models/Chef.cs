using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Chef
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Subtitle { get; set; }
    }
}
