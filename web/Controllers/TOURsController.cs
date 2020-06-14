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
    public class TOURsController : Controller
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
            var tOURs = db.TOURs.Include(t => t.CHUYENs);
            return View(tOURs.ToList());
        }


        // GET: TOURs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TOUR tOUR = db.TOURs.Find(id);
            if (tOUR == null)
            {
                return HttpNotFound();
            }
            return View(tOUR);
        }

        // GET: TOURs/Create
        public ActionResult Create()
        {
            ViewBag.MA_TOUR = new SelectList(db.LOTRINH_TOUR, "MA_TOUR", "MA_NOIDI");
            return View();
        }

        // POST: TOURs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MA_TOUR,TEN_TOUR,Anh,SoLuong,SO_NGAY,SO_DEM")] TOUR tOUR)
        {
            if (ModelState.IsValid)
            {
                db.TOURs.Add(tOUR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MA_TOUR = new SelectList(db.LOTRINH_TOUR, "MA_TOUR", "MA_NOIDI", tOUR.MA_TOUR);
            return View(tOUR);
        }

        // GET: TOURs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TOUR tOUR = db.TOURs.Find(id);
            if (tOUR == null)
            {
                return HttpNotFound();
            }
            ViewBag.MA_TOUR = new SelectList(db.LOTRINH_TOUR, "MA_TOUR", "MA_NOIDI", tOUR.MA_TOUR);
            return View(tOUR);
        }

        // POST: TOURs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MA_TOUR,TEN_TOUR,Anh,SoLuong,SO_NGAY,SO_DEM")] TOUR tOUR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tOUR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MA_TOUR = new SelectList(db.LOTRINH_TOUR, "MA_TOUR", "MA_NOIDI", tOUR.MA_TOUR);
            return View(tOUR);
        }

        // GET: TOURs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TOUR tOUR = db.TOURs.Find(id);
            if (tOUR == null)
            {
                return HttpNotFound();
            }
            return View(tOUR);
        }

        // POST: TOURs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TOUR tOUR = db.TOURs.Find(id);
            db.TOURs.Remove(tOUR);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
