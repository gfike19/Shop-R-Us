using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_R_Us.Data;
using Shop_R_Us.Models;
using Shop_R_Us.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Shop_R_Us.Controllers
{
    public class CustomerController : Controller
    {
        
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(CustomerSignIn customerSignIn)
        {
            if(ModelState.IsValid)
            {
                //TODO create login logic
            }
            return Redirect("/CustomerOrder/OrderHome/");
        }
    }
}
