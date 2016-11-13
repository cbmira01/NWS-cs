using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace NWS_cs.Controllers
{
    public class JeopardyController : Controller
    {
        private NwsContext db = new NwsContext();

        public ActionResult Search()
        {
            TempData["SearchTerm"] = null;
            return View();
        }

        public ActionResult Results()
        {
            var searchTerm = "";

            // Thanks to http://sampathloku.blogspot.com/2012/09/how-to-use-aspnet-mvc-tempdata-properly.html
            if (TempData["SearchTerm"] != null)
            {
                searchTerm = (string)TempData["SearchTerm"];

                var query =
                    from r in db.JeopardyQuestions
                    where r.category.ToLower().Contains(searchTerm)
                        || r.question.ToLower().Contains(searchTerm)
                        || r.answer.ToLower().Contains(searchTerm)
                    select r;

                var results = query.Take(20).ToList();
                return View(results);
            }
            else
            {
                return RedirectToAction("Search");
            }


        }

        [HttpPost]
        public ActionResult Search(string searchTerm)
        {
            // Persist data for next request
            // Thanks to http://sampathloku.blogspot.com/2012/09/how-to-use-aspnet-mvc-tempdata-properly.html
            TempData["SearchTerm"] = null;

            if (!String.IsNullOrEmpty(searchTerm))
            {
                TempData["SearchTerm"] = searchTerm.ToLower();
            }

            return RedirectToAction("Results");
        }

    }
}
