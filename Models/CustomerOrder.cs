using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_R_Us.Models
{
    public class CustomerOrder
    {
        public string Id { get; set; }
        public decimal OrderTotal { get; set; }
        public decimal SubOrderTotal { get; set; }
        public decimal HighTaxTotal { get; set; }
        public decimal LowTaxTotal { get; set; }
        public decimal TaxTotal { get; set; }

        public CustomerOrder () { }

        public CustomerOrder(decimal orderTotal, decimal subOrderTotal, decimal highTaxTotal, decimal lowTaxTotal, decimal taxTotal)
        {
            OrderTotal = orderTotal;
            SubOrderTotal = subOrderTotal;
            HighTaxTotal = highTaxTotal;
            LowTaxTotal = lowTaxTotal;
            TaxTotal = taxTotal;
        }
    }
}
