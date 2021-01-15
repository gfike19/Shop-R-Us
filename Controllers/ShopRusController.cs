using Microsoft.AspNetCore.Http;  
using Microsoft.AspNetCore.Mvc;  

namespace Shop_R_Us.Controllers
{
    public class ShopRusController : Controller
    {
        public IActionResult ShopRusHome()
        {
            
            return View();
        }
    }
}
