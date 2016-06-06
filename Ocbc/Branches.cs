using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Ocbc
{
    class Branches : OcbcConnect
    {
        public Branches(String url, String token)
            : base(url, token)
        { }

        public List<Branch> all()
        {
            return Branches.DeJson(base.Get());
        }

        public static List<Branch> DeJson(JObject json)
        {
            List<Branch> branches = new List<Branch>();

            JArray jsonbranches = (JArray)json.GetValue("branches");
            foreach (JObject jsonbranch in jsonbranches.Children<JObject>())
            {
                branches.Add(Branch.DeJson(jsonbranch));
            }

            return branches;
        }
    }
}
