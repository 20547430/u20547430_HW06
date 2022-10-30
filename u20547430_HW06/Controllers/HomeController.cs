using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20547430_HW06.Models;
using Newtonsoft.Json;

namespace u20547430_HW06.Controllers
{
    public class HomeController : Controller
    {
        private readonly BikeStoresEntities db = new BikeStoresEntities();
        
        public ActionResult Products()
        {
            return View();
        }

        //get products 
        // use select statement 
        // return object as json object
        public string GetProduct()
        {
            object productData = db.products.Select(p => new {Id = p.product_id, Name= p.product_name, Year = p.model_year, Price=p.list_price,
            Brand= p.brand, Category = p.category}).ToList();
            return JsonConvert.SerializeObject(productData);
        }
       



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}