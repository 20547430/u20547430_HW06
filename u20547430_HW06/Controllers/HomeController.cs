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
        public string GetProducts()
        {
            db.Configuration.ProxyCreationEnabled = false; // avoid error

            object productData = db.products.Select(p => new {Id = p.product_id, Name= p.product_name, Year = p.model_year, Price=p.list_price,
            Brand= p.brand.brand_name, Category = p.category.category_name}).ToList();
            return JsonConvert.SerializeObject(productData);
        }
       

        //add new products
        public ActionResult AddProduct(string name, short year, decimal price, int brand, int category)
        {
            db.products.Add(new product {product_name=name,model_year=year,list_price=price, brand_id=brand,category_id=category});
            db.SaveChanges();
            return Json(JsonRequestBehavior.AllowGet);

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}