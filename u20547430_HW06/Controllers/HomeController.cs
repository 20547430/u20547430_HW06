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
        //public string GetPlaylists()
        //{
        //    object playlistData = db.Playlist.Select(p => new { ID = p.PlaylistId, p.Name, Tracks = p.Track.Count }).ToList();

        //    return JsonConvert.SerializeObject(playlistData);
        //}



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