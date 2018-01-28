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
    public class PrayerListsController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: PrayerLists
        public ActionResult Index()
        {
            return View(db.PrayerList.ToList());
        }

        // GET: PrayerLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrayerList prayerList = db.PrayerList.Find(id);
            if (prayerList == null)
            {
                return HttpNotFound();
            }
            return View(prayerList);
        }

        // GET: PrayerLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrayerLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PrayerName,Description")] PrayerList prayerList)
        {
            if (ModelState.IsValid)
            {
                db.PrayerList.Add(prayerList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(prayerList);
        }

        // GET: PrayerLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrayerList prayerList = db.PrayerList.Find(id);
            if (prayerList == null)
            {
                return HttpNotFound();
            }
            return View(prayerList);
        }

        // POST: PrayerLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PrayerName,Description")] PrayerList prayerList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prayerList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prayerList);
        }

        // GET: PrayerLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrayerList prayerList = db.PrayerList.Find(id);
            if (prayerList == null)
            {
                return HttpNotFound();
            }
            return View(prayerList);
        }

        // POST: PrayerLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PrayerList prayerList = db.PrayerList.Find(id);
            db.PrayerList.Remove(prayerList);
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
