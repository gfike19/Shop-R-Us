using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop_R_Us.Models
{
    public class CustomerOrder
    {
        public int Id { get; set; }
        public float OrderTotal { get; set; }
        public float SubOrderTotal { get; set; }
        public float HighTaxTotal { get; set; }
        public float LowTaxTotal { get; set; }
        public float TaxTotal { get; set; }
        public List<Product> OrderProducts { get; set; }
        public DateTime CreatedDateUtc { get; set; }

        public CustomerOrder() { }

        public CustomerOrder(float orderTotal, float subOrderTotal, float highTaxTotal, float lowTaxTotal, float taxTotal,
            List<Product> orderProducts)
        {
            OrderTotal = orderTotal;
            SubOrderTotal = subOrderTotal;
            HighTaxTotal = highTaxTotal;
            LowTaxTotal = lowTaxTotal;
            TaxTotal = taxTotal;
            OrderProducts = orderProducts;
        }

        public CustomerOrder(Product p)
        {
            AddItems(p);
        }

        public void AddItems(Product p)
        {
            if (OrderProducts == null)
            {
                OrderProducts = new List<Product>();
            }
            OrderProducts.Add(p);
            SubOrderTotal += (float)p.Price;
            if (p.Fs)
            {
                double lt = .01 * (double)p.Price;
                LowTaxTotal += (float)lt;
            }
            else
            {
                double ht = .04 * (double)p.Price;
                HighTaxTotal += (float)ht;
            }

            TaxTotal += (LowTaxTotal + HighTaxTotal);
            OrderTotal += (SubOrderTotal + TaxTotal);
        }

        public void RemoveItems(Product p)
        {
            //if (OrderProducts.Count == 1)
            //{
            //    OrderProducts.Clear();
            //    SubOrderTotal = 0;
            //    LowTaxTotal = 0;
            //    HighTaxTotal = 0;
            //    TaxTotal = 0;
            //    OrderTotal = 0;
            //    return;
            //}
            foreach (Product r in OrderProducts)
            {
                if (r.Id == p.Id)
                {
                    OrderProducts.Remove(p);

                    SubOrderTotal -= (float)p.Price;
                    if (p.Fs)
                    {
                        double lt = .01 * (double)p.Price;
                        LowTaxTotal = LowTaxTotal - (float)lt;
                    }
                    else
                    {
                        double ht = .04 * (double)p.Price;
                        HighTaxTotal = -(float)ht;
                    }

                    TaxTotal = (LowTaxTotal + HighTaxTotal);
                    OrderTotal = (SubOrderTotal + TaxTotal);
                }
            }

        }

    }
}
