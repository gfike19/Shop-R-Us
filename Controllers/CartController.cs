using Microsoft.AspNetCore.Mvc;
using Shop_R_Us.Data;

namespace Shop_R_Us.Controllers
{
    public class CartController : Controller
    {
        public IActionResult ViewCart()
        {
            var id = HttpContext.Session.GetObject<object>("userId");
            if(id == null)
            {
                //HttpContext.Session.SetObject("msg", "You need to be signed in to have a cart!");
                TempData["msg"] = "You need to be signed in to have a cart!";
                return Redirect("/Customer/SignIn");
            }
            return View();
        }
    }
}
