using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelocationEssentials.Models
{
    public class CountyModel : DataModel
    {
        public String CountyCD { get { return Get("CountyCD"); } }
        public String CountyNM { get { return Get("CountyNM"); } }

        public String StateCD { get { return Get("StateCD"); } }
        public String County_Seat { get { return Get("County_Seat"); } }
        public String Area { get { return Get("Area"); } }
        public long Total_Population { get { return Convert.ToInt64(Attributes["Total_Population"]); } }
        public String Population_Density { get { return Get("Population_Density"); } }
        public String Median_Age { get { return Get("Median_Age"); } }
        public String Average_Family_Size { get { return Get("Average_Family_Size"); } }
        public String Households { get { return Get("Households"); } }
        public String Average_Household_Size { get { return Get("Average_Household_Size"); } }
        public String Median_Home_Value { get { return Get("Median_Home_Value"); } }
        public String Income_per_Capita { get { return Get("Income_per_Capita"); } }
        public String Median_Household_Income { get { return Get("Median_Household_Income"); } }
        public String Unemployment_Rate { get { return Get("Unemployment_Rate"); } }
        public String Commute_Time { get { return Get("Commute_Time"); } }
        public String High_School_Graduation { get { return Get("High_School_Graduation"); } }
        public String College_Graduation { get { return Get("College_Graduation"); } }
        public String Post_College_Graduation { get { return Get("Post_College_Graduation"); } }
        public String Average_Temp_Jan { get { return Get("Average_Temp_Jan"); } }
        public String Average_Temp_Jul { get { return Get("Average_Temp_Jul"); } }
        public String Precipitation { get { return Get("Precipitation"); } }
        public String Snow { get { return Get("Snow"); } }
        public String State_Income_Tax_Rate { get { return Get("State_Income_Tax_Rate"); } }
        public String Sales_Tax_Rate { get { return Get("Sales_Tax_Rate"); } }
        public String Local_Sales_Tax_Rate { get { return Get("Local_Sales_Tax_Rate"); } }
        public String Food_Tax { get { return Get("Food_Tax"); } }
        public String Taxes_Personal_Income { get { return Get("Taxes_Personal_Income"); } }
        public String State_Taxes_per_Capita { get { return Get("State_Taxes_per_Capita"); } }

        public CountyModel()
            : base()
        {

        }

        private String Get(String key)
        {
            return Attributes.ContainsKey(key) ? Attributes[key] : "N/A";
        }
    }
}