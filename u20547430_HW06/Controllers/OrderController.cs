using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20547430_HW06.Models;

namespace u20547430_HW06.Controllers
{
    public class OrderController : Controller

    {
        private readonly BikeStoresEntities db = new BikeStoresEntities();

        // GET: Order
        public ActionResult Index()


        List students = dataService.GetAllStudents().ToList();

        BookDetailsVM bookDetail = new BookDetailsVM
        {
            book = book,
            type = type,
            author = author,
            students = students,
            borrows = borrows

            return 
        };
        }
    }
}