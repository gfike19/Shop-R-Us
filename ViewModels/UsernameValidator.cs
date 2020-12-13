//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;
//using Shop_R_Us.Data;
//using Shop_R_Us.Models;

//namespace Shop_R_Us.ViewModels
//{
//    public class UsernameValidator : ValidationAttribute
//    {
//        private ShopRusContext context;
//        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
//        {
//            List<Customer> customers = context.Customers.ToList();
//            foreach(Customer c in customers)
//            {
//                if(c.CustomerName.Equals(value.ToString()))
//                {
//                    return new ValidationResult("Username already in use");
//                }
//            }
//            return ValidationResult.Success;
//        }
//    }
//}
