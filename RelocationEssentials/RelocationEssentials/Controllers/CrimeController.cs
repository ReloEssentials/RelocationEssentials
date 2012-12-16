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
            DocumentStore Store = new DocumentStore { ConnectionStringName = "Raven", DefaultDatabase = "State" };
            Store.Initialize();

            List<SelectListItem> States = new List<SelectListItem>();
            States.Add(new SelectListItem() { Text = "", Value = "" });
            using (var session = Store.OpenSession())
            {
                List<DataModel> Models = session.Query<DataModel>().OrderBy(x => x.Code).ToList();
                foreach (DataModel dm in Models)
                {
                    foreach (Models.Attribute a in dm.Attributes)
                    {
                        if (a.Name.Equals("Name"))
                        {
                            States.Add(new SelectListItem() { Text = a.Name, Value = a.Name, Selected = false });
                            break;
                        }
                    }
                }
            }

            States.Add(new SelectListItem() { Text = "Virginia", Value = "Virginia", Selected = false });

            ViewBag.States = States;

            return View();
        }

        [HttpPost]
        public ActionResult Index(String State, String Zip)
        {
            if (Zip == null || Zip.Length == 0)
                if (State != null && State.Length != 0)
                    return RedirectToAction("ChoosePlace", new { State = State });
            return RedirectToAction("Display", new { Place = "", Zip = Zip });
        }

        public ActionResult ChoosePlace(String State)
        {
            List<SelectListItem> StateEnumerable = new List<SelectListItem>();
            StateEnumerable.Add(new SelectListItem() { Text = "", Value = "" });

            DocumentStore Store = new DocumentStore() { ConnectionStringName = "Raven", DefaultDatabase = "Place" };
            Store.Initialize();

            List<DataModel> Models;
            using (var session = Store.OpenSession())
            {
                Models = session.Query<DataModel>().ToList();
                foreach (DataModel dm in Models)
                {
                    foreach (Models.Attribute a in dm.Attributes)
                    {
                        if (a.Name.Equals("State_Name"))
                        {
                            if (a.Value.Equals(State))
                                StateEnumerable.Add(new SelectListItem() { Text = dm.Name, Value = dm.Name, Selected = false });
                            break;
                        }
                    }
                }
            }
            ViewBag.SE = StateEnumerable;
            return View();
        }

        [HttpPost]
        public ActionResult ChoosePlace(String Place, int v = 0)
        {
            return RedirectToAction("Display", new { Place = Place, Zip = "" });
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
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
