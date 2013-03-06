using Raven.Client.Document;
using RelocationEssentials.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            DocumentStore store = new DocumentStore { ConnectionStringName = "Raven", DefaultDatabase = "RelocationEssentials" };
            store.Initialize();
            using (var session = store.OpenSession())
            {
                StateModel sm = session.Query<StateModel>().Where(x => x.StateAbbrv == StateAbbrv).First();
                ViewBag.topCities = session.Query<PlaceModel>().Where(x => x.StateCD == sm.StateCD).Take(50).ToList(); ;
                ViewBag.topCounties = session.Query<CountyModel>().Where(x => x.StateCD == sm.StateCD).Take(20).ToList(); ;
                ViewBag.cities = new SelectList(session.Query<PlaceModel>().Where(x => x.StateCD == sm.StateCD));
                ViewBag.counties = new SelectList(session.Query<CountyModel>().Where(x => x.StateCD == sm.StateCD));
                ViewBag.zips = new SelectList(session.Query<ZipModel>().Where(x => x.StateCD == sm.StateCD));
            }
            return View();
        }
    }
}
