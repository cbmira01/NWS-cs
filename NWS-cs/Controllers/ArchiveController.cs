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
    public class ArchiveController : Controller
    {
        private NwsContext db = new NwsContext();

        public ActionResult _EditButtonPartial()
        {
            return PartialView();
        }

        public ActionResult Index()
        {
            return View(db.Archives.ToList());
        }

        public ActionResult Content()
        {
            return View(db.Archives.ToList());
        }

        // GET: Archive/Create
        public ActionResult Create()
        {
            var model = new Archive();
            return View(model);
        }

        // POST: Archive/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "id,title,link")] Archive archive)
        {
            if (ModelState.IsValid)
            {
                db.Archives.Add(archive);
                db.SaveChanges();
                return RedirectToAction("Content");
            }

            return View(archive);
        }

        // GET: Archive/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Archive archive = db.Archives.Find(id);
            if (archive == null)
            {
                return HttpNotFound();
            }
            return View(archive);
        }

        // POST: Archive/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "id,title,link")] Archive archive)
        {
            if (ModelState.IsValid)
            {
                db.Entry(archive).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Content");
            }
            return View(archive);
        }

        // GET: Archive/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Archive archive = db.Archives.Find(id);
            if (archive == null)
            {
                return HttpNotFound();
            }
            return View(archive);
        }

        // POST: Archive/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Archive archive = db.Archives.Find(id);
            db.Archives.Remove(archive);
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
