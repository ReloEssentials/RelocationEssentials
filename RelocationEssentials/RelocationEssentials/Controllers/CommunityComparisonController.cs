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
            //List<StateModel> Models = rm.QueryState("StateCD", false);

            //ViewBag.States = rm.GetSelectList(Models);

            return View();
        }

        public ActionResult CompareZip(String Zip1, String Zip2)
        {
            ZipModel dm1, dm2;
            try
            {
                //dm1 = rm.QueryZip("ZCTA5", Zip1).First();
               // dm2 = rm.QueryZip("ZCTA5", Zip2).First();
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
            /*CCModel m1 = new CCModel(dm1.PlaceNM,
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
            ViewBag.M2 = m2;*/
            return View();
        }

        public ActionResult DisplayZip(String Zip)
        {
            /*ZipModel dm;
            if (rm.QueryZip("ZCTA5", Zip).Any())
                dm = rm.QueryZip("ZCTA5", Zip).First();
            else
                dm = new ZipModel();
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
            ViewBag.M = m1;*/
            return View();
        }

        public ActionResult ChoosePlaceForTwo(String State1, String State2)
        {
            /*List<PlaceModel> Models1, Models2;
            Models1 = rm.QueryPlace("StateCD", State1);
            Models2 = rm.QueryPlace("StateCD", State2);

            ViewBag.S1E = rm.GetSelectList(Models1);
            ViewBag.S2E = rm.GetSelectList(Models2);*/

            return View();
        }

        public ActionResult ChoosePlace(String State)
        {
            /*List<PlaceModel> Models;
            Models = rm.QueryPlace("StateCD", State).ToList();
            ViewBag.SE = rm.GetSelectList(Models);*/
            return View();
        }

        public ActionResult ComparePlace(String Place1, String Place2)
        {
            /*PlaceModel dm1, dm2;
            try
            {
                dm1 = rm.QueryPlace("PlaceCD", Place1).First();
                dm2 = rm.QueryPlace("PlaceCD", Place2).First();
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
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
            ViewBag.M2 = m2;*/
            return View();
        }

        public ActionResult DisplayPlace(String Place)
        {
            /*PlaceModel dm;
            if (rm.QueryPlace("PlaceCD", Place).Any())
                dm = rm.QueryPlace("PlaceCD", Place).First();
            else
                dm = new PlaceModel();

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
            ViewBag.M = m1;*/
            return View();
        }

        public ActionResult DisplayCounty(String County)
        {
            /*CountyModel dm;
            if (rm.QueryCounty("CountyCD", County).Any())
                dm = rm.QueryCounty("CountyCD", County).First();
            else
                dm = new CountyModel();

            CCModel m1 = new CCModel(dm.CountyNM,
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
            ViewBag.M = m1;*/
            return View();
        }

    }
}