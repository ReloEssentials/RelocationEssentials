using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelocationEssentials.Models
{
    public class StateModel : DataModel
    {
        public String StateCD { get { return Get("StateCD"); } }
        public String StateNM { get { return Get("StateNM"); } }
        public String StateAbbrv { get { return Get("State_Abbrv"); } }

        public StateModel()
            : base()
        {

        }

        private String Get(String key)
        {
            return Attributes.ContainsKey(key) ? Attributes[key] : "";
        }
    }
}