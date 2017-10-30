using System;

namespace PartsInParcels.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Grade { get; set; }
        public bool Cured { get; set; }
        public string Origin { get; set; }
        public int Weight { get; set; }
    }
}