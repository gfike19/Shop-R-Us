using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_R_Us.Data;
using Shop_R_Us.Models;
using Shop_R_Us.ViewModels;
using Microsoft.EntityFrameworkCore;
using Shop_R_Us.Data;

namespace Shop_R_Us.Controllers
{
    public class CustomerController : Controller
    {
        private ShopRusContext context;

        public CustomerController(ShopRusContext shopRusContext)
        {
            context = shopRusContext;
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(CustomerSignIn customerSignIn)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/CustomerOrder/OrderHome/");
            }

            return View("SignIn", customerSignIn);
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Customer customer)
        {
            return Redirect("/CustomerOrder/OrderHome/");
        }
    }
}
