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
    public class AdvertisementController : Controller
    {
        private NwsContext db = new NwsContext();

        public ActionResult _EditButtonPartial()
        {
            return PartialView();
        }

        public ActionResult Content()
        {
            return View(db.Advertisements.ToList());
        }

        // GET: Advertisement/Create
        public ActionResult Create()
        {
            var model = new Advertisement();
            return View(model);
        }

        // POST: Advertisement/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "id,link")] Advertisement advertisement)
        {
            if (ModelState.IsValid)
            {
                db.Advertisements.Add(advertisement);
                db.SaveChanges();
                return RedirectToAction("Content");
            }

            return View(advertisement);
        }

        // GET: Advertisement/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advertisement advertisement = db.Advertisements.Find(id);
            if (advertisement == null)
            {
                return HttpNotFound();
            }
            return View(advertisement);
        }

        // POST: Advertisement/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "id,link")] Advertisement advertisement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(advertisement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Content");
            }
            return View(advertisement);
        }

        // GET: Advertisement/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advertisement advertisement = db.Advertisements.Find(id);
            if (advertisement == null)
            {
                return HttpNotFound();
            }
            return View(advertisement);
        }

        // POST: Advertisement/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Advertisement advertisement = db.Advertisements.Find(id);
            db.Advertisements.Remove(advertisement);
            db.SaveChanges();
            return RedirectToAction("Content");
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
