using Microsoft.AspNetCore.Mvc;
using Shop_R_Us.Data;
using Shop_R_Us.Models;
using System.Collections.Generic;

namespace Shop_R_Us.Controllers
{
    public class CartController : Controller
    { //TODO #3 add ability to save cart closing app, cookies?

        private ShopRusContext context;
        public CartController(ShopRusContext shopRusContext)
        {
            context = shopRusContext;
        }

        public IActionResult ViewCart()
        {
            CustomerOrder cart = HttpContext.Session.GetObject<CustomerOrder>("cart");

            if (cart != null)
            {
                ViewBag.Cart = cart;
            }

            if (TempData["msg"] != null)
            {
                string msg = (string)TempData["msg"];
                ViewBag.Msg = msg;
            }

            return View();
        }

        [HttpPost]
        public IActionResult RemoveItemFromCart(List<int> markedItem)
        {
            if (markedItem.Count == 0)
            {
                TempData["msg"] = "No item selected!";
                return Redirect("/Cart/ViewCart");
            }

            CustomerOrder cart = HttpContext.Session.GetObject<CustomerOrder>("cart");
            //HttpContext.Session.Remove("cart");

            foreach (int i in markedItem)
            {
                Product p = context.Products.Find(i);
                cart.RemoveItems(p);
            }

            ViewData.Clear();
            HttpContext.Session.SetObject("cart", cart);

            //return Redirect("/Cart/ViewCart");
            return View("ViewCart");
        }
    }
}
