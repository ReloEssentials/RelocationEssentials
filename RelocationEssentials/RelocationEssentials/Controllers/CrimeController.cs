using Raven.Client.Document;
using RelocationEssentials.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RelocationEssentials.Controllers
{
    public class CrimeController : Controller
    {
        public ActionResult Index()
        {
            //List<StateModel> Models = rm.QueryState("StateCD", false);

           // ViewBag.States = rm.GetSelectList(Models);

            return View();
        }

        public ActionResult ChoosePlace(String State)
        {
           // List<PlaceModel> Models = rm.QueryPlace("StateCD", State);
           // ViewBag.SE = rm.GetSelectList(Models);
            return View();
        }

        public ActionResult Display(String Place, String Zip)
        {
            if (Zip != null && Zip.Length != 0)
            {
                ViewBag.Zip = "("+Zip+")";
                ViewBag.Place = "";
            }
            else if (Place != null && Place.Length != 0)
            {
                ViewBag.Zip = "";
                ViewBag.Place = Place;
            }
            return View();
        }

    }
}
