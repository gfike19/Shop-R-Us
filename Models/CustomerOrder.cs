using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_R_Us.Models
{
    public class CustomerOrder
    {
        public string Id { get; set; }
        public float OrderTotal { get; set; }
        public float SubOrderTotal { get; set; }
        public float HighTaxTotal { get; set; }
        public float LowTaxTotal { get; set; }
        public float TaxTotal { get; set; }

        public CustomerOrder () { }

        public CustomerOrder(float orderTotal, float subOrderTotal, float highTaxTotal, float lowTaxTotal, float taxTotal)
        {
            OrderTotal = orderTotal;
            SubOrderTotal = subOrderTotal;
            HighTaxTotal = highTaxTotal;
            LowTaxTotal = lowTaxTotal;
            TaxTotal = taxTotal;
        }
    }
}
