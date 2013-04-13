using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RelocationEssentials.Controllers
{
    public class DefaultController : Controller
    {

        public ActionResult Index(int? which)
        {
            if (which == 0)
                ViewBag.which = "Plate";
            else
                ViewBag.which = "Map";
            return View();
        }

    }
}
