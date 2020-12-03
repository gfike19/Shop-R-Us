using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_R_Us.Data;
using Shop_R_Us.Models;

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
