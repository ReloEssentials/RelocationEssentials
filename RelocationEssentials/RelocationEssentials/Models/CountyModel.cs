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

        public CountyModel()
            : base()
        {

        }

        private String Get(String key)
        {
            return Attributes.ContainsKey(key) ? Attributes[key] : "";
        }
    }
}