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
            List<SelectListItem> States = new List<SelectListItem>();
            States.Add(new SelectListItem() { Text = "", Value = "" });
            using (var session = MvcApplication.Store.OpenSession())
            {
                List<StateModel> Models = session.Query<StateModel>().OrderBy(x => x.StateCD).ToList();
                foreach (StateModel dm in Models)
                {
                    States.Add(new SelectListItem() { Text = dm.StateNM, Value = dm.StateCD, Selected = false });
                }
            }

            ViewBag.States = States;

            return View();
        }

        public ActionResult CompareZip(String Zip1, String Zip2)
        {
            ZipModel dm1, dm2;
            using (var session = MvcApplication.Store.OpenSession())
            {
                try
                {
                    dm1 = session.Query<ZipModel>().Where(x => x.Code == Zip1).First();
                    dm2 = session.Query<ZipModel>().Where(x => x.Code == Zip2).First();
                }
                catch (Exception e)
                {
                    return RedirectToAction("Index");
                }
            }
            CCModel m1 = new CCModel(dm1.PlaceNM,
                dm1.County_Seat,
                dm1.Area,
                dm1.Total_Population,
                dm1.Population_Density,
                dm1.Median_Age,
                dm1.Average_Family_Size,
                dm1.Households,
                dm1.Average_Household_Size,
                dm1.Median_Home_Value,
                dm1.Income_per_Capita,
                dm1.Median_Household_Income,
                dm1.Unemployment_Rate,
                dm1.Commute_Time,
                dm1.High_School_Graduation,
                dm1.College_Graduation,
                dm1.Post_College_Graduation,
                dm1.Average_Temp_Jan,
                dm1.Average_Temp_Jul,
                dm1.Precipitation,
                dm1.Snow,
                dm1.State_Income_Tax_Rate,
                dm1.Sales_Tax_Rate,
                dm1.Local_Sales_Tax_Rate,
                dm1.Food_Tax,
                dm1.Taxes_Personal_Income,
                dm1.State_Taxes_per_Capita);
            CCModel m2 = new CCModel(dm2.PlaceNM,
                dm2.County_Seat,
                dm2.Area,
                dm2.Total_Population,
                dm2.Population_Density,
                dm2.Median_Age,
                dm2.Average_Family_Size,
                dm2.Households,
                dm2.Average_Household_Size,
                dm2.Median_Home_Value,
                dm2.Income_per_Capita,
                dm2.Median_Household_Income,
                dm2.Unemployment_Rate,
                dm2.Commute_Time,
                dm2.High_School_Graduation,
                dm2.College_Graduation,
                dm2.Post_College_Graduation,
                dm2.Average_Temp_Jan,
                dm2.Average_Temp_Jul,
                dm2.Precipitation,
                dm2.Snow,
                dm2.State_Income_Tax_Rate,
                dm2.Sales_Tax_Rate,
                dm2.Local_Sales_Tax_Rate,
                dm2.Food_Tax,
                dm2.Taxes_Personal_Income,
                dm2.State_Taxes_per_Capita);
            ViewBag.Zip1 = Zip1;
            ViewBag.Zip2 = Zip2;
            ViewBag.M1 = m1;
            ViewBag.M2 = m2;
            return View();
        }

        public ActionResult DisplayZip(String Zip)
        {
            ZipModel dm;
            using (var session = MvcApplication.Store.OpenSession())
            {
                dm = session.Query<ZipModel>().Where(x => x.ZCTA5 == Zip).First();
            }
            CCModel m1 = new CCModel(dm.PlaceNM,
                dm.County_Seat,
                dm.Area,
                dm.Total_Population,
                dm.Population_Density,
                dm.Median_Age,
                dm.Average_Family_Size,
                dm.Households,
                dm.Average_Household_Size,
                dm.Median_Home_Value,
                dm.Income_per_Capita,
                dm.Median_Household_Income,
                dm.Unemployment_Rate,
                dm.Commute_Time,
                dm.High_School_Graduation,
                dm.College_Graduation,
                dm.Post_College_Graduation,
                dm.Average_Temp_Jan,
                dm.Average_Temp_Jul,
                dm.Precipitation,
                dm.Snow,
                dm.State_Income_Tax_Rate,
                dm.Sales_Tax_Rate,
                dm.Local_Sales_Tax_Rate,
                dm.Food_Tax,
                dm.Taxes_Personal_Income,
                dm.State_Taxes_per_Capita);
            ViewBag.Zip = Zip;
            ViewBag.M = m1;
            return View();
        }

        public ActionResult ChoosePlaceForTwo(String State1, String State2)
        {
            List<SelectListItem> State1Enumerable = new List<SelectListItem>();
            List<SelectListItem> State2Enumerable = new List<SelectListItem>();

            State1Enumerable.Add(new SelectListItem() { Text = "", Value = "" });
            State2Enumerable.Add(new SelectListItem() { Text = "", Value = "" });

            List<PlaceModel> Models1, Models2;
            using (var session = MvcApplication.Store.OpenSession())
            {
                Models1 = session.Query<PlaceModel>().Where(x => x.StateCD == State1).ToList();
                Models2 = session.Query<PlaceModel>().Where(x => x.StateCD == State2).ToList();
                foreach (PlaceModel pm in Models1)
                    State1Enumerable.Add(new SelectListItem() { Text = pm.PlaceNM, Value = pm.PlaceCD });
                foreach(PlaceModel pm in Models2)
                    State2Enumerable.Add(new SelectListItem() { Text = pm.PlaceNM, Value = pm.PlaceCD });
            }

            ViewBag.S1E = State1Enumerable;
            ViewBag.S2E = State2Enumerable;

            return View();
        }

        public ActionResult ChoosePlace(String State)
        {
            List<SelectListItem> StateEnumerable = new List<SelectListItem>();
            StateEnumerable.Add(new SelectListItem() { Text = "", Value = "" });

            List<PlaceModel> Models;
            using (var session = MvcApplication.Store.OpenSession())
            {
                Models = session.Query<PlaceModel>().Where(x => x.StateCD == State).ToList();
                foreach (PlaceModel pm in Models)
                     StateEnumerable.Add(new SelectListItem() { Text = pm.PlaceNM, Value = pm.PlaceCD, Selected = false });
            }
            ViewBag.SE = StateEnumerable;
            return View();
        }

        public ActionResult ComparePlace(String Place1, String Place2)
        {
            PlaceModel dm1, dm2;
            using (var session = MvcApplication.Store.OpenSession())
            {
                try
                {
                    dm1 = session.Query<PlaceModel>().Where(x => x.PlaceCD == Place1).First();
                    dm2 = session.Query<PlaceModel>().Where(x => x.PlaceCD == Place2).First();
                }
                catch (Exception e)
                {
                    return RedirectToAction("Index");
                }
            }
            CCModel m1 = new CCModel(dm1.PlaceNM,
                dm1.County_Seat,
                dm1.Area,
                dm1.Total_Population,
                dm1.Population_Density,
                dm1.Median_Age,
                dm1.Average_Family_Size,
                dm1.Households,
                dm1.Average_Household_Size,
                dm1.Median_Home_Value,
                dm1.Income_per_Capita,
                dm1.Median_Household_Income,
                dm1.Unemployment_Rate,
                dm1.Commute_Time,
                dm1.High_School_Graduation,
                dm1.College_Graduation,
                dm1.Post_College_Graduation,
                dm1.Average_Temp_Jan,
                dm1.Average_Temp_Jul,
                dm1.Precipitation,
                dm1.Snow,
                dm1.State_Income_Tax_Rate,
                dm1.Sales_Tax_Rate,
                dm1.Local_Sales_Tax_Rate,
                dm1.Food_Tax,
                dm1.Taxes_Personal_Income,
                dm1.State_Taxes_per_Capita);
            CCModel m2 = new CCModel(dm2.PlaceNM,
                dm2.County_Seat,
                dm2.Area,
                dm2.Total_Population,
                dm2.Population_Density,
                dm2.Median_Age,
                dm2.Average_Family_Size,
                dm2.Households,
                dm2.Average_Household_Size,
                dm2.Median_Home_Value,
                dm2.Income_per_Capita,
                dm2.Median_Household_Income,
                dm2.Unemployment_Rate,
                dm2.Commute_Time,
                dm2.High_School_Graduation,
                dm2.College_Graduation,
                dm2.Post_College_Graduation,
                dm2.Average_Temp_Jan,
                dm2.Average_Temp_Jul,
                dm2.Precipitation,
                dm2.Snow,
                dm2.State_Income_Tax_Rate,
                dm2.Sales_Tax_Rate,
                dm2.Local_Sales_Tax_Rate,
                dm2.Food_Tax,
                dm2.Taxes_Personal_Income,
                dm2.State_Taxes_per_Capita);
            ViewBag.M1 = m1;
            ViewBag.M2 = m2;
            return View();
        }

        public ActionResult DisplayPlace(String Place)
        {
            PlaceModel dm;
            using (var session = MvcApplication.Store.OpenSession())
            {
                dm = session.Query<PlaceModel>().Where(x => x.PlaceCD == Place).First();
            }
            CCModel m1 = new CCModel(dm.PlaceNM,
                dm.County_Seat,
                dm.Area,
                dm.Total_Population,
                dm.Population_Density,
                dm.Median_Age,
                dm.Average_Family_Size,
                dm.Households,
                dm.Average_Household_Size,
                dm.Median_Home_Value,
                dm.Income_per_Capita,
                dm.Median_Household_Income,
                dm.Unemployment_Rate,
                dm.Commute_Time,
                dm.High_School_Graduation,
                dm.College_Graduation,
                dm.Post_College_Graduation,
                dm.Average_Temp_Jan,
                dm.Average_Temp_Jul,
                dm.Precipitation,
                dm.Snow,
                dm.State_Income_Tax_Rate,
                dm.Sales_Tax_Rate,
                dm.Local_Sales_Tax_Rate,
                dm.Food_Tax,
                dm.Taxes_Personal_Income,
                dm.State_Taxes_per_Capita);
            ViewBag.M = m1;
            return View();
        }

    }
}