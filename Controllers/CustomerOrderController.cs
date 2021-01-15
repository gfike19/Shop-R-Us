﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_R_Us.Models;
using Shop_R_Us.Data;
using System.Dynamic;

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
            if (HttpContext.Request.Cookies["signedIn"] == null)
            {
                string msg = "Must be signed in to place an order";
                ViewBag.msg = msg;
                return Redirect("/Customer/SignIn");
            }
            List<Product> products = context.Product.ToList();
            dynamic model = new ExpandoObject();
            model.currentProd = products;
            List<Product> newOrder = HttpContext.Session.GetObject<List<Product>>("newOrder") ?? new List<Product>();
            model.newOrder = newOrder;
            return View(model);
        }

        [HttpPost]
        public IActionResult addToCart(int currentProd)
        {
            Product p = context.Product.Find(currentProd);
            List<Product> newOrder = new List<Product>();
            newOrder.Add(p);
            HttpContext.Session.SetObject("newOrder", newOrder);
            return View("OrderHome");
        }
    }
}
