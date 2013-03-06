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
                    /*foreach (Models.Attribute a in dm.Attributes)
                    {
                        if (a.Name.Equals("NAME"))
                        {
                            States.Add(new SelectListItem() { Text = a.Name, Value = a.Name, Selected = false });
                            break;
                        }
                    }*/
                }
            }

            ViewBag.States = States;

            return View();
        }

        [HttpPost]
        public ActionResult Index(String StateList1, String StateList2, String Zip1, String Zip2)
        {
            

            if (!(Zip1.Length == 0 && Zip2.Length == 0))
            {
                DocumentStore Store = new DocumentStore { ConnectionStringName = "Raven", DefaultDatabase = "Zip" };
                Store.Initialize();

                if (Zip2.Length != 0)
                {
                    DataModel dm1, dm2;
                    using (var session = Store.OpenSession())
                    {
                        dm1 = session.Query<DataModel>().Where(x => x.Code == Zip1).ToList()[0];
                        dm2 = session.Query<DataModel>().Where(x => x.Code == Zip2).ToList()[0];
                    }
                    try
                    {
                        /*CCModel m1 = new CCModel(dm1.Attributes.Where(x => x.Name.Equals("Place")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("County_Seat")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Area")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Population_Total")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Population_Density")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Median_Age")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Average_Family_Size")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Households")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Average_Household_Size")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Median_Home_Value")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Income_per_Capita")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Median_Household_Income")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Unemployment_Rate")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Commute_Time")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("High_School_Graduation")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("College_Graduation")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Post_College_Graduation")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Average_Temp_Jan")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Average_Temp_Jul")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Precipitation")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Snow")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("State_Income_Tax_Rate")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Sales_Tax_Rate")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Local_Sales_Tax_Rate")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Food_Tax")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("Taxes_Personal_Income")).ToList()[0].Value,
                            dm1.Attributes.Where(x => x.Name.Equals("State_Taxes_per_Capita")).ToList()[0].Value);
                        CCModel m2 = new CCModel(dm2.Attributes.Where(x => x.Name.Equals("Place")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("County_Seat")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Area")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Population_Total")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Population_Density")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Median_Age")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Average_Family_Size")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Households")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Average_Household_Size")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Median_Home_Value")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Income_per_Capita")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Median_Household_Income")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Unemployment_Rate")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Commute_Time")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("High_School_Graduation")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("College_Graduation")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Post_College_Graduation")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Average_Temp_Jan")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Average_Temp_Jul")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Precipitation")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Snow")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("State_Income_Tax_Rate")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Sales_Tax_Rate")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Local_Sales_Tax_Rate")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Food_Tax")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("Taxes_Personal_Income")).ToList()[0].Value,
                            dm2.Attributes.Where(x => x.Name.Equals("State_Taxes_per_Capita")).ToList()[0].Value);*/
                        return RedirectToAction("Index");//"CompareZip", new { Zip1 = Zip1, Zip2 = Zip2, Model1 = m1, Model2 = m2 });

                    }
                    catch (Exception e)
                    {
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    DataModel dm;
                    using (var session = Store.OpenSession())
                    {
                        dm = session.Query<DataModel>().Where(x => x.Code == Zip1).ToList()[0];
                    }
                    /*CCModel m = new CCModel(dm.Attributes.Where(x => x.Name.Equals("Place")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("County_Seat")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Area")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Population_Total")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Population_Density")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Median_Age")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Average_Family_Size")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Households")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Average_Household_Size")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Median_Home_Value")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Income_per_Capita")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Median_Household_Income")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Unemployment_Rate")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Commute_Time")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("High_School_Graduation")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("College_Graduation")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Post_College_Graduation")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Average_Temp_Jan")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Average_Temp_Jul")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Precipitation")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Snow")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("State_Income_Tax_Rate")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Sales_Tax_Rate")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Local_Sales_Tax_Rate")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Food_Tax")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("Taxes_Personal_Income")).ToList()[0].Value,
                        dm.Attributes.Where(x => x.Name.Equals("State_Taxes_per_Capita")).ToList()[0].Value);*/
                    return RedirectToAction("Index");//"DisplayZip", new { Zip = Zip1, Model = m });
                }
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

        public ActionResult CompareZip(String Zip1, String Zip2, CCModel Model1, CCModel Model2)
        {
            ViewBag.Zip1 = Zip1;
            ViewBag.Zip2 = Zip2;
            ViewBag.M1 = Model1;
            ViewBag.M2 = Model2;
            return View();
        }

        public ActionResult DisplayZip(String Zip, CCModel Model)
        {
            ViewBag.Zip = Zip;
            ViewBag.M = Model;
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
                    /*foreach (Models.Attribute a in dm.Attributes)
                    {
                        if (a.Name.Equals("StateNM"))
                        {
                            /*if (a.Value.Equals(State1))
                                State1Enumerable.Add(new SelectListItem() { Text = dm.Name, Value = dm.Name });
                            else if (a.Value.Equals(State2))
                                State2Enumerable.Add(new SelectListItem() { Text = dm.Name, Value = dm.Name });
                            break;
                        }
                    }*/
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
                    /*foreach (Models.Attribute a in dm.Attributes)
                    {
                        if (a.Name.Equals("StateNM"))
                        {
                            /*if (a.Value.Equals(State))
                                StateEnumerable.Add(new SelectListItem() { Text = dm.Name, Value = dm.Name, Selected = false });
                            break;
                        }
                    }*/
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

        public ActionResult ComparePlace(String Place1, String Place2, CCModel Model1, CCModel Model2)
        {
            ViewBag.M1 = Model1;
            ViewBag.M2 = Model2;
            return View();
        }

        public ActionResult DisplayPlace(String Place, CCModel Model)
        {
            ViewBag.M = Model;
            return View();
        }

    }
}
