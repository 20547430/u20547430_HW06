using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20547430_HW06.Models;
using Newtonsoft.Json;


namespace u20547430_HW06.Controllers
{
    public class OrderController : Controller
    {
        private readonly BikeStoresEntities db = new BikeStoresEntities();

        // GET: Order
        public ActionResult Index()
        {
            List<OrderVM> order = db.products.Select(o => new OrderVM
            {
                ProdName=o.product_name,
                ListPrice=o.list_price,
                Quantity=o.stocks,

            }).ToList();

            return View();
        }
    }
}