using Raven.Client.Document;
using RelocationEssentials.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RelocationEssentials.Controllers
{
    public class SchoolController : Controller
    {
        //
        // GET: /School/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChooseLocation()
        {
            return View();
        }

        public ActionResult SchoolDistricts(String State, String Type, String Value, String Zip, int Miles)
        {
            /*DocumentStore Store = new DocumentStore() { ConnectionStringName = "Raven", DefaultDatabase = "School" };
            Store.Initialize();
            
            SchoolDisplayModel model = new SchoolDisplayModel();
            using (var session = Store.OpenSession())
            {
                if (Type.Equals("City"))
                {
                    model.Public = session.Query<DataModel>().ToList();
                    model.Public = model.Public.Where(x => x.Attributes.Find(equalsNamePublicPrivate).Name.Equals("Public")).Where(x => x.Attributes.Find(equalsNameCity).Name.Equals(Value)).ToList();
                    model.Private = session.Query<DataModel>().ToList();
                    model.Private = model.Private.Where(x => x.Attributes.Find(equalsNamePublicPrivate).Name.Equals("Private")).Where(x => x.Attributes.Find(equalsNameCity).Name.Equals(Value)).ToList();
                    model.District = false;
                }
                else if (Type.Equals("County"))
                {
                    model.Public = session.Query<DataModel>().ToList();
                    model.Public = model.Public.Where(x => x.Attributes.Find(equalsNamePublicPrivate).Name.Equals("Public")).Where(x => x.Attributes.Find(equalsNameCounty).Name.Equals(Value)).ToList();
                    model.Private = session.Query<DataModel>().ToList();
                    model.Private = model.Private.Where(x => x.Attributes.Find(equalsNamePublicPrivate).Name.Equals("Private")).Where(x => x.Attributes.Find(equalsNameCounty).Name.Equals(Value)).ToList();
                    model.District = false;
                }
                else if (Type.Equals("School"))
                {
                    model.Public = session.Query<DataModel>().ToList();
                    model.Public = model.Public.Where(x => x.Attributes.Find(equalsNamePublicPrivate).Name.Equals("Public")).Where(x => x.Attributes.Find(equalsName).Name.Equals(Value)).ToList();
                    model.Private = session.Query<DataModel>().ToList();
                    model.Private = model.Private.Where(x => x.Attributes.Find(equalsNamePublicPrivate).Name.Equals("Private")).Where(x => x.Attributes.Find(equalsName).Name.Equals(Value)).ToList();
                    model.District = false;
                }
                else if (Zip != null)
                {
                    model.Public = session.Query<DataModel>().ToList();
                    model.Public = model.Public.Where(x => x.Attributes.Find(equalsNamePublicPrivate).Name.Equals("Public")).Where(x => x.Attributes.Find(equalsNameZip).Name.Equals(Zip)).ToList();
                    model.Private = session.Query<DataModel>().ToList();
                    model.Private = model.Private.Where(x => x.Attributes.Find(equalsNamePublicPrivate).Name.Equals("Private")).Where(x => x.Attributes.Find(equalsNameZip).Name.Equals(Zip)).ToList();
                    model.District = true;
                }
                else
                {
                    return RedirectToAction("ChooseLocation");
                }
                model.PublicBool = (Request.Form["Public"] != null);
                model.PrivateBool = (Request.Form["Private"] != null);
                model.Miles = Miles;
            }*/

            return View();//model);
        }

        public ActionResult ReportCard()
        {
            return View();
        }

        public ActionResult SchoolFront()
        {
            return View();
        }

        public ActionResult SchoolOverview()
        {
            return View();
        }

        public ActionResult SchoolStudents()
        {
            return View();
        }

        public ActionResult SchoolTeachers()
        {
            return View();
        }

        public ActionResult SchoolFacilities()
        {
            return View();
        }

        public ActionResult SchoolAcademia()
        {
            return View();
        }

        public ActionResult SchoolXCurricula()
        {
            return View();
        }

        public ActionResult DistrictFront()
        {
            return View();
        }

        public ActionResult DistrictOverview()
        {
            return View();
        }

        public ActionResult DistrictStudents()
        {
            return View();
        }

        public ActionResult DistrictTeachers()
        {
            return View();
        }

        public ActionResult DistrictFacilities()
        {
            return View();
        }

        public ActionResult DistrictAcademia()
        {
            return View();
        }

        public ActionResult DistrictXCurricula()
        {
            return View();
        }

        public ActionResult CompareFront()
        {
            return View();
        }

        public ActionResult CompareOverview()
        {
            return View();
        }

        public ActionResult CompareStudents()
        {
            return View();
        }

        public ActionResult CompareTeachers()
        {
            return View();
        }

        public ActionResult CompareFacilities()
        {
            return View();
        }

        public ActionResult CompareAcademia()
        {
            return View();
        }

        public ActionResult CompareXCurricula()
        {
            return View();
        }
    }
}
