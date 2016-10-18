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
    public class FeatureController : Controller
    {
        private NwsContext db = new NwsContext();

        // GET: Feature
        public ActionResult Index()
        {
            return View(db.Features.ToList());
        }

        // GET: Feature/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feature feature = db.Features.Find(id);
            if (feature == null)
            {
                return HttpNotFound();
            }
            return View(feature);
        }

        // GET: Feature/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Feature/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,article,image1,image2,image3,title")] Feature feature)
        {
            if (ModelState.IsValid)
            {
                db.Features.Add(feature);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(feature);
        }

        // GET: Feature/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feature feature = db.Features.Find(id);
            if (feature == null)
            {
                return HttpNotFound();
            }
            return View(feature);
        }

        // POST: Feature/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,article,image1,image2,image3,title")] Feature feature)
        {
            if (ModelState.IsValid)
            {
                db.Entry(feature).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(feature);
        }

        // GET: Feature/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feature feature = db.Features.Find(id);
            if (feature == null)
            {
                return HttpNotFound();
            }
            return View(feature);
        }

        // POST: Feature/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Feature feature = db.Features.Find(id);
            db.Features.Remove(feature);
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
