using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20547430_HW06.Models
{
    public class OrderVM
    {
        
            public string ProdName { get; set; }
            public decimal ListPrice { get; set; }
            public virtual ICollection<stock> Quantity { get; set; }
            public decimal Total { get; set; }
            public decimal GrandTotal { get; set; }

        
    }
}