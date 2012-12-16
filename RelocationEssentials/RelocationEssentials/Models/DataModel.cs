using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelocationEssentials.Models
{
    public class DataModel
    {
        public String Code { get; set; }
        public String Name { get; set; }
        public List<Attribute> Attributes { get; set; }

        public DataModel(String Code)
        {
            this.Code = Code;
            Attributes = new List<Attribute>();
        }
    }
}