using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Ocbc
{
    class Atms : OcbcConnect
    {
        public Atms(String url, String token)
            : base(url, token)
        { }

        public List<Atm> all()
        {
            return Atms.DeJson(base.Get());
        }

        public static List<Atm> DeJson(JObject json)
        {
            List<Atm> Atms = new List<Atm>();

            JArray jsonatms = (JArray)json.GetValue("ATMS");
            foreach (JObject jsonatm in jsonatms.Children<JObject>())
            {
                Atms.Add(Atm.DeJson(jsonatm));
            }

            return Atms;
        }
    }
}
