using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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
            if(TempData["msg"] != null)
            {
                ViewBag.Msg = TempData["msg"].ToString();
            }
            List<Product> products = context.Products.ToList();
            return View(products);
        }

        [HttpPost]
        public IActionResult OrderHome(int currentProduct)
        {
            Product p = context.Products.Find(currentProduct);
            List<Product> cart = HttpContext.Session.GetObject<List<Product>>("cart") ?? new List<Product>();
            cart.Add(p);
            HttpContext.Session.SetObject("cart", cart);
            return Redirect("/Cart/ViewCart/");
        }

    }
}
