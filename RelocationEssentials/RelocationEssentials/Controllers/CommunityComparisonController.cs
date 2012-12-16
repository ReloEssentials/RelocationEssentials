using Raven.Client.Document;
using RelocationEssentials.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RelocationEssentials.Controllers
{
    public class CommunityComparisonController : Controller
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

            States.Add(new SelectListItem() { Text = "Virginia", Value = "Virginia", Selected = false});

            ViewBag.States = States;

            return View();
        }

        [HttpPost]
        public ActionResult Index(String StateList1, String StateList2, String Zip1, String Zip2)
        {
            if (!(Zip1.Length == 0 && Zip2.Length == 0))
            {
                if (Zip2.Length != 0)
                    return RedirectToAction("CompareZip", new { Zip1 = Zip1, Zip2 = Zip2 });
                else
                    return RedirectToAction("DisplayZip", new { Zip = Zip1 });
            }
            else if (!(StateList1 == null || StateList2 == null) && !(StateList1.Length == 0 && StateList2.Length == 0))
            {
                if (StateList2.Length != 0)
                    return RedirectToAction("ChoosePlaceForTwo", new { State1 = StateList1, State2 = StateList2 });
                else
                    return RedirectToAction("ChoosePlace", new { State = StateList1 });
            }
            return View();
        }

        public ActionResult CompareZip(String Zip1, String Zip2)
        {
            ViewBag.Zip1 = Zip1;
            ViewBag.Zip2 = Zip2;
            return View();
        }

        public ActionResult DisplayZip(String Zip)
        {
            ViewBag.Zip = Zip;
            return View();
        }

        public ActionResult ChoosePlaceForTwo(String State1, String State2)
        {
            List<SelectListItem> State1Enumerable = new List<SelectListItem>();
            List<SelectListItem> State2Enumerable = new List<SelectListItem>();

            State1Enumerable.Add(new SelectListItem() { Text = "", Value = "" });
            State2Enumerable.Add(new SelectListItem() { Text = "", Value = "" });

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
                            if (a.Value.Equals(State1))
                                State1Enumerable.Add(new SelectListItem() { Text = dm.Name, Value = dm.Name });
                            else if (a.Value.Equals(State2))
                                State2Enumerable.Add(new SelectListItem() { Text = dm.Name, Value = dm.Name });
                            break;
                        }
                    }
                }
            }

            ViewBag.S1E = State1Enumerable;
            ViewBag.S2E = State2Enumerable;

            return View();
        }

        [HttpPost]
        public ActionResult ChoosePlaceForTwo(String Place1, String Place2, int v = 0)
        {
            return RedirectToAction("ComparePlace", new { Place1 = Place1, Place2 = Place2 });
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
            return RedirectToAction("DisplayPlace", new { Place = Place });
        }

        public ActionResult ComparePlace(String Place1, String Place2)
        {
            return View();
        }

        public ActionResult DisplayPlace(String Place)
        {
            return View();
        }

    }
}
