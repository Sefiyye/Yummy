namespace WebApplication.Models
{
    public class Eat
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Product { get; set; }
        public string Price { get; set; }
        public Category CategoryId { get; set; }
    }
}
