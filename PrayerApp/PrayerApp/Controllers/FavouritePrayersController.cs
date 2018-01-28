using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrayerApp.Models;

namespace PrayerApp.Controllers
{
    public class FavouritePrayersController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: FavouritePrayers
        public ActionResult Index()
        {
            return View(db.FavouritePrayers.ToList());
        }

        // GET: FavouritePrayers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FavouritePrayer favouritePrayer = db.FavouritePrayers.Find(id);
            if (favouritePrayer == null)
            {
                return HttpNotFound();
            }
            return View(favouritePrayer);
        }

        // GET: FavouritePrayers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FavouritePrayers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PrayerName")] FavouritePrayer favouritePrayer)
        {
            if (ModelState.IsValid)
            {
                db.FavouritePrayers.Add(favouritePrayer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(favouritePrayer);
        }

        // GET: FavouritePrayers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FavouritePrayer favouritePrayer = db.FavouritePrayers.Find(id);
            if (favouritePrayer == null)
            {
                return HttpNotFound();
            }
            return View(favouritePrayer);
        }

        // POST: FavouritePrayers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PrayerName")] FavouritePrayer favouritePrayer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(favouritePrayer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(favouritePrayer);
        }

        // GET: FavouritePrayers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FavouritePrayer favouritePrayer = db.FavouritePrayers.Find(id);
            if (favouritePrayer == null)
            {
                return HttpNotFound();
            }
            return View(favouritePrayer);
        }

        // POST: FavouritePrayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FavouritePrayer favouritePrayer = db.FavouritePrayers.Find(id);
            db.FavouritePrayers.Remove(favouritePrayer);
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
