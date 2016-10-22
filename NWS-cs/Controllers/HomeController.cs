using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NWS_cs.Controllers
{
    public class HomeController : Controller
    {
        private NwsContext db = new NwsContext();

        public ActionResult _FeaturePartial()
        {
            return PartialView(db.Features.ToList());
        }

        public ActionResult _ArticlePartial()
        {
            return PartialView(db.Articles.ToList());
        }

        public ActionResult _VideoPartial()
        {
            return PartialView(db.Videos.ToList());
        }

        public ActionResult _AdvertisementPartial()
        {
            return PartialView(db.Advertisements.ToList());
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}