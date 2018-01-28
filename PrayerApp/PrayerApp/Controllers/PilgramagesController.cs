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
    public class PilgramagesController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Pilgramages
        public ActionResult Index()
        {
            return View(db.Pilgramages.ToList());
        }

        // GET: Pilgramages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pilgramage pilgramage = db.Pilgramages.Find(id);
            if (pilgramage == null)
            {
                return HttpNotFound();
            }
            return View(pilgramage);
        }

        // GET: Pilgramages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pilgramages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] Pilgramage pilgramage)
        {
            if (ModelState.IsValid)
            {
                db.Pilgramages.Add(pilgramage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pilgramage);
        }

        // GET: Pilgramages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pilgramage pilgramage = db.Pilgramages.Find(id);
            if (pilgramage == null)
            {
                return HttpNotFound();
            }
            return View(pilgramage);
        }

        // POST: Pilgramages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] Pilgramage pilgramage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pilgramage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pilgramage);
        }

        // GET: Pilgramages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pilgramage pilgramage = db.Pilgramages.Find(id);
            if (pilgramage == null)
            {
                return HttpNotFound();
            }
            return View(pilgramage);
        }

        // POST: Pilgramages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pilgramage pilgramage = db.Pilgramages.Find(id);
            db.Pilgramages.Remove(pilgramage);
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
