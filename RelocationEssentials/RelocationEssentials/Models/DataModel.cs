using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelocationEssentials.Models
{
    public class DataModel
    {
        public String Code { get; set; }
        public Dictionary<String, String> Attributes { get; set; }

        public DataModel()
        {
            Attributes = new Dictionary<String, String>();
        }

        public DataModel(Dictionary<String, String> Attributes)
        {
            this.Attributes = Attributes;
        }
    }
}