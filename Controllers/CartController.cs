using Microsoft.AspNetCore.Mvc;
using Shop_R_Us.Data;
using Shop_R_Us.Models;
using System.Collections.Generic;

namespace Shop_R_Us.Controllers
{
    public class CartController : Controller
    {
        public IActionResult ViewCart()
        {
            List<Product> cart = HttpContext.Session.GetObject<List<Product>>("cart") ?? new List<Product>(); ;

            if(cart.Count > 0)
            {
                ViewBag.Cart = cart;
            }

            return View();
        }
    }
}
