using Raven.Client.Document;
using RelocationEssentials.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Raven.Client;

namespace RelocationEssentials.Controllers
{
    public class MapController : Controller
    {
        //
        // GET: /Map/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StateDisplay(String StateAbbrv)
        {
            return View();
        }

        public ActionResult getPlaces(String StateAbbrv)
        {
            return Json(new List<String>().ToArray(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult getCounties(String StateAbbrv)
        {
            return Json(new List<String>().ToArray(), JsonRequestBehavior.AllowGet);
        }
    }
}
