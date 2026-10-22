using System;
using System.Collections.Generic;
using System.Text;

namespace Testik.Models
{
    public enum CanBuying
    {
        Yes, Not
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Compound { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } = 0m;
        public int Discount { get; set; }
        public string PhotoName { get; set; }
        public string PhotoNewName => string.IsNullOrEmpty(PhotoName) ? "/Images/no_image.png" : $"/Images/{PhotoName}";
        public DateOnly DateOfAdd { get; set; }
        public decimal Weight { get; set; }
        public string Unit { get; set; }
        public int CountBuying { get; set; }
        public CanBuying CanBuying { get; set; }
        public ICollection<Product_category> Product_Category { get; set; } = new List<Product_category>();
        public string CategoryName => Product_Category.FirstOrDefault().Category.Name ?? "Нет категории";
    }
}
