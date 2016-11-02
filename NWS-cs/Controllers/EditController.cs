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