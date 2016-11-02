using System.Data;
using System.Linq;
using System.Web.Mvc;

namespace NWS_cs.Controllers
{
    public class ReadController : Controller
    {
        private NwsContext db = new NwsContext();

        // Thanks to http://stackoverflow.com/a/21832863
        public ActionResult Article()
        {
            string uuid = this.Request.QueryString["uuid"];

            var query =
                from article in db.Articles
                where article.uuid.Equals(uuid)
                select article;

            ViewResult viewResult = View(query.ToList());
            return viewResult;
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
