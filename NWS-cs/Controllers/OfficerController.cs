using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace NWS_cs.Controllers
{
    public class OfficerController : Controller
    {
        private NwsContext db = new NwsContext();

        public ActionResult _EditButtonPartial()
        {
            return PartialView();
        }

        // GET: Officer
        public ActionResult Index()
        {
            return View(db.Officers.ToList());
        }

        public ActionResult Content()
        {
            return View(db.Officers.ToList());
        }

        // GET: Officer/Create
        public ActionResult Create()
        {
            var model = new Officer();
            return View(model);
        }

        // POST: Officer/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "id,name,email,description,photo")] Officer officer)
        {
            if (ModelState.IsValid)
            {
                db.Officers.Add(officer);
                db.SaveChanges();
                return RedirectToAction("Content");
            }

            return View(officer);
        }

        // GET: Officer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Officer officer = db.Officers.Find(id);
            if (officer == null)
            {
                return HttpNotFound();
            }
            return View(officer);
        }

        // POST: Officer/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "id,name,email,description,photo")] Officer officer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(officer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Content");
            }
            return View(officer);
        }

        // GET: Officer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Officer officer = db.Officers.Find(id);
            if (officer == null)
            {
                return HttpNotFound();
            }
            return View(officer);
        }

        // POST: Officer/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Officer officer = db.Officers.Find(id);
            db.Officers.Remove(officer);
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
