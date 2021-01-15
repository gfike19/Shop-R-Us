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
            if(HttpContext.Request.Cookies["signedIn"] == null)
            {
                string msg = "Must be signed in to place an order";
                ViewBag.msg = msg;
                return Redirect("/Customer/SignIn");
            }
            List<Product> products = context.Product.ToList();
            return View(products);
        }
    }
}
