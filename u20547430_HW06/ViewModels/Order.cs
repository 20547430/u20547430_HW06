using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20547430_HW06.ViewModels
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int StoreId { get; set; }
        public int StaffId { get; set; }
    }
}