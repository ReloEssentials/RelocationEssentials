using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelocationEssentials.Models
{
    public class CoLModel
    {
        public int Salary { get; set; }
        public String Name { get; set; }
        public int Composite { get; set; }
        public int Food { get; set; }
        public int Housing { get; set; }
        public int Utilities { get; set; }
        public int Transportation { get; set; }
        public int HealthCare { get; set; }
        public int Misc { get; set; }

        public CoLModel(int Salary, String Name, int Composite, int Food, int Housing, int Utilities, int Transportation, int HealthCare, int Misc)
        {
            this.Salary = Salary;
            this.Name = Name;
            this.Composite = (int) Math.Round(100*Composite-100.0);
            this.Food = (int)Math.Round(100 * Food - 100.0);
            this.Housing = (int)Math.Round(100 * Housing - 100.0);
            this.Utilities = (int)Math.Round(100 * Utilities - 100.0);
            this.Transportation = (int)Math.Round(100 * Transportation - 100.0);
            this.HealthCare = (int)Math.Round(100 * HealthCare - 100.0);
            this.Misc = (int)Math.Round(100 * Misc - 100.0);
        }
    }
}