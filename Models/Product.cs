using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_R_Us.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public bool Fs { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public Product() { }

        public Product(string productName, bool fs, decimal price)
        {
            ProductName = productName;
            Fs = fs;
            Price = price;
        }
    }
}
