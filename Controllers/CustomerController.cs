using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_R_Us.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
