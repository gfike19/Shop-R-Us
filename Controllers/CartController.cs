using Microsoft.AspNetCore.Mvc;
using Shop_R_Us.Data;
using Shop_R_Us.Models;
using System.Collections.Generic;

namespace Shop_R_Us.Controllers
{
    public class CartController : Controller
    { //TODO #3 add ability to save cart closing app, cookies?
        public IActionResult ViewCart()
        {
            List<Product> cart = HttpContext.Session.GetObject<List<Product>>("cart") ?? new List<Product>(); ;

            if (cart.Count > 0)
            {
                ViewBag.Cart = cart;
            }

            return View();
        }

        //[HttpPost]
        //public IActionResult RemoveItemFromCart(List<int> markedItem)
        //{
            //TODO #2 add functionality to remove items from cart, update properties of order
        //}
    }
}
