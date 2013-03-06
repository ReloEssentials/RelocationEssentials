using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelocationEssentials.Models
{
    public class CCModel
    {
        public String Location { get; set; }
        public String CountySeat { get; set; }
        public String Area { get; set; }
        public String Population { get; set; }
        public String Density { get; set; }
        public String Age { get; set; }
        public String FamilySize { get; set; }
        public String Households { get; set; }
        public String HouseholdSize { get; set; }
        public String MHV { get; set; }
        public String IC { get; set; }
        public String MHI { get; set; }
        public String UR { get; set; }
        public String Commute { get; set; }
        public String HSG { get; set; }
        public String CG { get; set; }
        public String PCG { get; set; }
        public String TempJan { get; set; }
        public String TempJul { get; set; }
        public String Precipitation { get; set; }
        public String Snow { get; set; }
        public String SITR { get; set; }
        public String STR { get; set; }
        public String LSTR { get; set; }
        public String FT { get; set; }
        public String TPI { get; set; }
        public String STC { get; set; }

        public CCModel(String Location, String CountySeat, String Area, String Population, String Density, String Age, String FamilySize,
            String Households, String HouseholdSize, String MHV, String IC, String MHI, String UR, String Commute, String HSG, String CG, String PCG,
            String TempJan, String TempJul, String Precipitation, String Snow, String SITR, String STR, String LSTR, String FT, String TPI, String STC)
        {
            this.Location = Location;
            this.CountySeat = CountySeat;
            this.Area = Area;
            this.Population = Population;
            this.Density = Density;
            this.Age = Age;
            this.FamilySize = FamilySize;
            this.Households = Households;
            this.HouseholdSize = HouseholdSize;
            this.MHV = MHV;
            this.IC = IC;
            this.MHI = MHI;
            this.UR = UR;
            this.Commute = Commute;
            this.HSG = HSG;
            this.CG = CG;
            this.PCG = PCG;
            this.TempJan = TempJan;
            this.TempJul = TempJul;
            this.Precipitation = Precipitation;
            this.Snow = Snow;
            this.SITR = SITR;
            this.STR = STR;
            this.LSTR = LSTR;
            this.FT = FT;
            this.TPI = TPI;
            this.STC = STC;
        }
    }
}