using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20547430_HW06.ViewModels
{
    public class OrderVM
    {
        public string ProductName { get; set; }
        public double ListPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }

    }
}