using Raven.Client.Document;
using RelocationEssentials.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RelocationEssentials.Models;

namespace RelocationEssentials.Controllers
{
    public class CostOfLivingController : Controller
    {
        //
        // GET: /CostOfLiving/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Display(int CurrentSalary, String OrgState, String DesState, String type1, String type2, String Value1, String Value2)
        {

            /*CountyModel OrgCounty = null, DesCounty = null;

            try
            {
                using (var session = MvcApplication.Store.OpenSession())
                {
                    if (Value1 == null)
                        return RedirectToAction("Index");
                    if (type1 == "P")
                    {
                        PlaceModel Place1 = session.Query<PlaceModel>().Where(x => x.PlaceNM.Contains(Value1)).First();
                        OrgCounty = session.Query<CountyModel>().Where(x => x.StateCD == OrgState && x.CountyCD == Place1.CountyCD).First();
                    }
                    else if (type1 == "C")
                    {
                        OrgCounty = session.Query<CountyModel>().Where(x => x.StateCD == OrgState && x.CountyNM.Contains(Value1)).First();
                    }
                    else if (type1 == "Z")
                    {
                        ZipModel Zip1 = session.Query<ZipModel>().Where(x => x.Code.Equals(Value1)).ToList()[0];
                        PlaceModel Place1 = session.Query<PlaceModel>().Where(x => x.Code.Equals(Zip1.Attributes.Find(equalsCDPlace))).ToList()[0];
                        OrgCounty = session.Query<CountyModel>().Where(x => x.Attributes.Find(equalsCDState).Value.Equals(OrgState) && x.Attributes.Find(equalsCDCounty).Value.Equals(Place1.Attributes.Find(equalsCDCounty).Value)).ToList()[0];
                    }
                    else
                        throw new Exception();

                    if (Value2 != null)
                    {
                        if (type2 == "P")
                        {
                            PlaceModel Place2 = session.Query<PlaceModel>().Where(x => x.Attributes.Find(equalsNamePlace).Value.Contains(Value1)).ToList()[0];
                            DesCounty = session.Query<CountyModel>().Where(x => x.Attributes.Find(equalsCDState).Value.Equals(DesState) && x.Attributes.Find(equalsCDCounty).Value.Equals(Place2.Attributes.Find(equalsCDCounty).Value)).ToList()[0];
                        }
                        else if (type2 == "C")
                        {
                            DesCounty = session.Query<CountyModel>().Where(x => x.Attributes.Find(equalsCDState).Value.Equals(DesState) && x.Attributes.Find(equalsNameCounty).Value.Contains(Value1)).ToList()[0];
                        }
                        else if (type2 == "Z")
                        {
                            ZipModel Zip2 = session.Query<ZipModel>().Where(x => x.Code.Equals(Value1)).ToList()[0];
                            PlaceModel Place2 = session.Query<PlaceModel>().Where(x => x.Code.Equals(Zip2.Attributes.Find(equalsCDPlace))).ToList()[0];
                            OrgCounty = session.Query<CountyModel>().Where(x => x.Attributes.Find(equalsCDState).Value.Equals(DesState) && x.Attributes.Find(equalsCDCounty).Value.Equals(Place2.Attributes.Find(equalsCDCounty).Value)).ToList()[0];
                        }
                        else
                            throw new Exception();
                    }
                }
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }

            String Name1 = OrgCounty.Attributes.Find(equalsNameCounty).Value;
            int C1 = Convert.ToInt32(OrgCounty.Attributes.Find(equalsNameComposite).Value);
            int F1 = Convert.ToInt32(OrgCounty.Attributes.Find(equalsNameFood).Value);
            int H1 = Convert.ToInt32(OrgCounty.Attributes.Find(equalsNameHousing).Value);
            int U1 = Convert.ToInt32(OrgCounty.Attributes.Find(equalsNameUtilities).Value);
            int T1 = Convert.ToInt32(OrgCounty.Attributes.Find(equalsNameTransportation).Value);
            int HC1 = Convert.ToInt32(OrgCounty.Attributes.Find(equalsNameHealthCare).Value);
            int M1 = Convert.ToInt32(OrgCounty.Attributes.Find(equalsNameMisc).Value);

            String Name2 = "";
            int C2 = 0, F2 = 0, H2 = 0, U2 = 0, T2 = 0, HC2 = 0, M2 = 0;
            if (Value2 != null)
            {
                Name2 = DesCounty.Attributes.Find(equalsNameCounty).Value;
                C2 = Convert.ToInt32(DesCounty.Attributes.Find(equalsNameComposite).Value);
                F2 = Convert.ToInt32(DesCounty.Attributes.Find(equalsNameFood).Value);
                H2 = Convert.ToInt32(DesCounty.Attributes.Find(equalsNameHousing).Value);
                U2 = Convert.ToInt32(DesCounty.Attributes.Find(equalsNameUtilities).Value);
                T2 = Convert.ToInt32(DesCounty.Attributes.Find(equalsNameTransportation).Value);
                HC2 = Convert.ToInt32(DesCounty.Attributes.Find(equalsNameHealthCare).Value);
                M2 = Convert.ToInt32(DesCounty.Attributes.Find(equalsNameMisc).Value);
            }

            CoLModel cm1 = new CoLModel(CurrentSalary, Name1, C1, F1, H1, U1, T1, HC1, M1);
            CoLModel cm2 = null;
            if(Value2 != null)
                cm2 = new CoLModel(CurrentSalary, Name2, C2, F2, H2, U2, T2, HC2, M2);*/
            return View();//new List<CoLModel>() {cm1, cm2});
        }
    }
}
