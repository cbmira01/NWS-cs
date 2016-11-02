using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NWS_cs.Controllers
{
    public class EditController : Controller
    {
        public ActionResult _EditButtonPartial()
        {
            return PartialView();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}