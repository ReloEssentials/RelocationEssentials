using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelocationEssentials.Models
{
    public class PlaceModel : DataModel
    {
        public String PlaceCD { get { return Get("PlaceCD"); } }
        public String PlaceNM { get { return Get("PlaceNM"); } }

        public String StateCD { get { return Get("StateCD"); } }

        public PlaceModel()
            : base()
        {

        }

        private String Get(String key)
        {
            return Attributes.ContainsKey(key) ? Attributes[key] : "";
        }
    }
}