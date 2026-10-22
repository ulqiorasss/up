using System;
using System.Collections.Generic;
using System.Text;

namespace Testik.Models
{
    public class Combo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoName { get; set; }
        public string PhotoNewName => string.IsNullOrEmpty(PhotoName) ? "/Images/no_image.png" : $"/Images/{PhotoName}";
        public CanBuying CanBuying { get; set; }
        public DateOnly DateOfAdd { get; set; }
        public int CountBuying { get; set; }
        public decimal CoefficientEconomy { get; set; }
    }
}
