using System;
using System.Collections.Generic;
using System.Text;

namespace Testik.Models
{
    public class Product_category
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public Product Product { get; set; }
    }
}
