using System;
using System.Collections.Generic;
using System.Text;

namespace Testik.Models
{
    public class Combo_product
    {
        public int Id { get; set; }
        public Combo Combo { get; set; }
        public Product Product { get; set; }
    }
}
