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

        public ActionResult SchoolDistricts(String State, String City, String County, String School, String Zip, int Miles, Boolean Public, Boolean Private)
        {
            DocumentStore Store = new DocumentStore() { ConnectionStringName = "Raven", DefaultDatabase = "School" };
            Store.Initialize();

            SchoolDisplayModel model = new SchoolDisplayModel();
            using (var session = Store.OpenSession())
            {
                if (City != null)
                {
                    model.Public = session.Query<DataModel>().Where(x => x.Attributes.Find(equalsNamePublicPrivate).Name.Equals("Public") && x.Attributes.Find(equalsNameCity).Name.Equals(City)).ToList();
                    model.Private = session.Query<DataModel>().Where(x => x.Attributes.Find(equalsNamePublicPrivate).Name.Equals("Private") && x.Attributes.Find(equalsNameCity).Name.Equals(City)).ToList();
                    model.District = false;
                }
                else if (County != null)
                {
                    model.Public = session.Query<DataModel>().Where(x => x.Attributes.Find(equalsNamePublicPrivate).Name.Equals("Public") && x.Attributes.Find(equalsNameCounty).Name.Equals(County)).ToList();
                    model.Private = session.Query<DataModel>().Where(x => x.Attributes.Find(equalsNamePublicPrivate).Name.Equals("Private") && x.Attributes.Find(equalsNameCounty).Name.Equals(County)).ToList();
                    model.District = false;
                }
                else if (School != null)
                {
                    model.Public = session.Query<DataModel>().Where(x => x.Attributes.Find(equalsNamePublicPrivate).Name.Equals("Public") && x.Attributes.Find(equalsName).Name.Equals(School)).ToList();
                    model.Private = session.Query<DataModel>().Where(x => x.Attributes.Find(equalsNamePublicPrivate).Name.Equals("Private") && x.Attributes.Find(equalsName).Name.Equals(School)).ToList();
                    model.District = false;
                }
                else if (Zip != null)
                {
                    model.Public = session.Query<DataModel>().Where(x => x.Attributes.Find(equalsNamePublicPrivate).Name.Equals("Public") && x.Attributes.Find(equalsNameZip).Name.Equals(Zip)).ToList();
                    model.Private = session.Query<DataModel>().Where(x => x.Attributes.Find(equalsNamePublicPrivate).Name.Equals("Private") && x.Attributes.Find(equalsNameZip).Name.Equals(Zip)).ToList();
                    model.District = true;
                }
                else
                {
                    return RedirectToAction("ChooseLocation");
                }
                model.PublicBool = Public;
                model.PrivateBool = Private;
                model.Miles = Miles;
            }

            return View(model);
        }

        private bool equalsNameCity(Models.Attribute a)
        {
            return a.Name.Equals("City");
        }

        private bool equalsNameCounty(Models.Attribute a)
        {
            return a.Name.Equals("County");
        }

        private bool equalsName(Models.Attribute a)
        {
            return a.Name.Equals("Name");
        }

        private bool equalsNameZip(Models.Attribute a)
        {
            return a.Name.Equals("Zip");
        }

        private bool equalsNamePublicPrivate(Models.Attribute a)
        {
            return a.Name.Equals("PublicPrivate");
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
