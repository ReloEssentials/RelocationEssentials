using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelocationEssentials.Models
{
    public class SchoolDisplayModel
    {
        public List<DataModel> Public { get; set; }
        public List<DataModel> Private { get; set; }
        public bool PublicBool { get; set; }
        public bool PrivateBool { get; set; }
        public int Miles { get; set; }
        public bool District { get; set; }

        public SchoolDisplayModel()
        {
            Public = new List<DataModel>();
            Private = new List<DataModel>();
        }
    }
}