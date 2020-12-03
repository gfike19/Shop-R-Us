using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_R_Us.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public bool Fs { get; set; }
        public float Price { get; set; }

        public Product() { }

        public Product(string productName, bool fs, float price)
        {
            ProductName = productName ?? throw new ArgumentNullException(nameof(productName));
            Fs = fs;
            Price = price;
        }
    }
}
