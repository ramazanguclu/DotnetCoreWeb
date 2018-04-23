using Microsoft.EntityFrameworkCore;

namespace DotnetWeb.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public virtual Category Category { get; set; }
    }
}