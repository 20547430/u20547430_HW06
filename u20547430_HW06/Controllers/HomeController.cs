using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20547430_HW06.Models;
using Newtonsoft.Json;
using PagedList.Mvc;
using PagedList;

namespace u20547430_HW06.Controllers
{
    public class HomeController : Controller
    {
        private readonly BikeStoresEntities db = new BikeStoresEntities();
        
        public ActionResult Products(string searchString, int? i)
        {
            List<product> listTemp = db.products.ToList();
            return View(db.products.Where(x => x.product_name.StartsWith(searchString)|| searchString==null).ToList().ToPagedList(i?? 1,10));
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
        public JsonResult Add(product products)
        {
            db.products.Add(products);
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