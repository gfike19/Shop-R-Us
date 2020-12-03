using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_R_Us.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Password { get; set; }
        public List<int> OrderIds { get; set; }

        public Customer() { }

        public Customer(string customerName, string password, List<int> orderIds)
        {
            CustomerName = customerName;
            Password = password;
            OrderIds = orderIds;
        }
    }
}
