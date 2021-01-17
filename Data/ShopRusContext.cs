using Microsoft.EntityFrameworkCore;
using Shop_R_Us.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_R_Us.Data
{
    public class ShopRusContext : DbContext
    {
        public ShopRusContext(DbContextOptions<ShopRusContext> options)
            :base (options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
