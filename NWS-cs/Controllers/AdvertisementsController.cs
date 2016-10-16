using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NWS_cs;

namespace NWS_cs.Controllers
{
    public class AdvertisementsController : Controller
    {
        private NwsContext db = new NwsContext();

        // GET: Advertisements
        public ActionResult Index()
        {
            return View(db.Advertisements.ToList());
        }

        // GET: Advertisements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advertisements advertisements = db.Advertisements.Find(id);
            if (advertisements == null)
            {
                return HttpNotFound();
            }
            return View(advertisements);
        }

        // GET: Advertisements/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Advertisements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,link")] Advertisements advertisements)
        {
            if (ModelState.IsValid)
            {
                db.Advertisements.Add(advertisements);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(advertisements);
        }

        // GET: Advertisements/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advertisements advertisements = db.Advertisements.Find(id);
            if (advertisements == null)
            {
                return HttpNotFound();
            }
            return View(advertisements);
        }

        // POST: Advertisements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,link")] Advertisements advertisements)
        {
            if (ModelState.IsValid)
            {
                db.Entry(advertisements).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(advertisements);
        }

        // GET: Advertisements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advertisements advertisements = db.Advertisements.Find(id);
            if (advertisements == null)
            {
                return HttpNotFound();
            }
            return View(advertisements);
        }

        // POST: Advertisements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Advertisements advertisements = db.Advertisements.Find(id);
            db.Advertisements.Remove(advertisements);
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
