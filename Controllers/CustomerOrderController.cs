using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_R_Us.Models;
using Shop_R_Us.Data;
namespace Shop_R_Us.Controllers
{
    public class CustomerOrderController : Controller
    {
        private ShopRusContext context;

        public CustomerOrderController(ShopRusContext shopRusContext)
        {
            context = shopRusContext;
        }
        [HttpGet]
        public IActionResult OrderHome()
        {
            List<Product> products = context.Products.ToList();
            ViewBag.products = products;
            return View();
        }
    }
}
