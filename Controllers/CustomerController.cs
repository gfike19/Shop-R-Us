using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Shop_R_Us.Data;
using Shop_R_Us.Models;
using Shop_R_Us.ViewModels;
using System.Web.Helpers;
using System;

namespace Shop_R_Us.Controllers
{
    public class CustomerController : Controller
    {
        private ShopRusContext context;
        private List<Customer> customers;

        public CustomerController(ShopRusContext shopRusContext)
        {
            context = shopRusContext;
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            if(TempData["msg"].ToString().Length > 0)
            {
                ViewBag.Msg = TempData["msg"].ToString();
            }
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(CustomerSignIn customerSignIn)
        {
            if (ModelState.IsValid)
            {
                customers = context.Customers.ToList();
                foreach (Customer customer in customers)
                {
                    if (customer.CustomerName.Equals(customerSignIn.CustomerName))
                    {
                        Customer dbCustomer = customer;
                        bool verifiedPwd = Crypto.VerifyHashedPassword(dbCustomer.Password, customerSignIn.Password);

                        if (verifiedPwd == true)
                        {
                            HttpContext.Session.SetObject("customerId", dbCustomer.Id);
                            ViewBag.cust = HttpContext.Session.GetObject<int>("customerId");
                            return Redirect("/CustomerOrder/OrderHome/");
                        }
                    }
                }

            }

            return View("SignIn", customerSignIn);
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(CustomerSignUp customerSignUp)
        {
            if (ModelState.IsValid)
            {
                customers = context.Customers.ToList();
                foreach (Customer c in customers)
                {
                    if (c.CustomerName.Equals(customerSignUp.Username))
                    {
                        return View("SignUp", customerSignUp);
                    }
                }
                string hashPwd = Crypto.HashPassword(customerSignUp.Password);
                List<CustomerOrder> custOrder = new List<CustomerOrder>();
                Customer customer = new Customer(customerSignUp.Username, hashPwd, custOrder);
                context.Customers.Add(customer);
                context.SaveChanges();
                HttpContext.Session.SetObject("customerId", customer.Id);
                ViewBag.cust = HttpContext.Session.GetObject<int>("customerId");
                return Redirect("/CustomerOrder/OrderHome/");
            }
            return View("SignUp", customerSignUp);
        }


    }
}
