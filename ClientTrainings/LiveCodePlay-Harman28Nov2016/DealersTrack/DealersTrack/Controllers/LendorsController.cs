using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DealersTrack.Context;
using DealersTrack.Models;

namespace DealersTrack.Controllers
{
    public class LendorsController : Controller
    {
        private DealerTrackContext db = new DealerTrackContext();

        // GET: Lendors
        public ActionResult Index()
        {
            var lendors = db.Lendors.Include(l => l.Dealer);
            return View(lendors.ToList());
        }

        // GET: Lendors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lendor lendor = db.Lendors.Find(id);
            if (lendor == null)
            {
                return HttpNotFound();
            }
            return View(lendor);
        }

        // GET: Lendors/Create
        public ActionResult Create()
        {
            ViewBag.dealerId = new SelectList(db.Dealers, "dealerId", "dealerName");
            return View();
        }

        // POST: Lendors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "lendorId,lendorName,lendorAddress,dealerId")] Lendor lendor)
        {
            if (ModelState.IsValid)
            {
                db.Lendors.Add(lendor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.dealerId = new SelectList(db.Dealers, "dealerId", "dealerName", lendor.dealerId);
            return View(lendor);
        }

        // GET: Lendors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lendor lendor = db.Lendors.Find(id);
            if (lendor == null)
            {
                return HttpNotFound();
            }
            ViewBag.dealerId = new SelectList(db.Dealers, "dealerId", "dealerName", lendor.dealerId);
            return View(lendor);
        }

        // POST: Lendors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "lendorId,lendorName,lendorAddress,dealerId")] Lendor lendor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lendor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.dealerId = new SelectList(db.Dealers, "dealerId", "dealerName", lendor.dealerId);
            return View(lendor);
        }

        // GET: Lendors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lendor lendor = db.Lendors.Find(id);
            if (lendor == null)
            {
                return HttpNotFound();
            }
            return View(lendor);
        }

        // POST: Lendors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lendor lendor = db.Lendors.Find(id);
            db.Lendors.Remove(lendor);
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
