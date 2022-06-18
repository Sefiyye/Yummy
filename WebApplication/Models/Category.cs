using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Eat> Eat { get; set; }
    }
}
