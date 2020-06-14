using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using web.Models;

namespace web.Controllers
{
    
    public class HomeController : Controller
    {
        private tourEntities db = new tourEntities();

        // GET: TOURs
        public ActionResult Index()
        {
            var tOURs = db.TOURs.Include(t => t.LOTRINH_TOUR);
            return View(tOURs.ToList());
        }

        public ActionResult travel_NhaTrang()
        {
            return View();
        }

        public ActionResult travel_PhanThiet()
        {
            return View();
        }

        public ActionResult Hienthi()
        {
            return View();
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