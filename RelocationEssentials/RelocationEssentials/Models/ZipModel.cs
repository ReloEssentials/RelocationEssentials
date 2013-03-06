using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelocationEssentials.Models
{
    public class ZipModel : DataModel
    {
        public String ZCTA5 { get { return Get("ZCTA5"); } }

        public String StateCD { get { return Get("StateCD"); } }

        public ZipModel()
            : base()
        {

        }

        private String Get(String key)
        {
            return Attributes.ContainsKey(key) ? Attributes[key] : "";
        }
    }
}