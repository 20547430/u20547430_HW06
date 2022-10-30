using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20547430_HW06.ViewModels
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int ModelYear { get; set; }
        public double ListPrice { get; set; }
    }
}