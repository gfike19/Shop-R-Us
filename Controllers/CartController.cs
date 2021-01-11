using Microsoft.AspNetCore.Mvc;
using Shop_R_Us.Data;
using Shop_R_Us.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_R_Us.Controllers
{
    public class CartController : Controller
    {
        private ShopRusContext context;

        public CartController(ShopRusContext shopRusContext)
        {
            context = shopRusContext;
        }

        public IActionResult ViewCart()
        {
            return View();
        }

    }
}
