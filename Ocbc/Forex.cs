using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Ocbc
{
    class Forex : OcbcConnect
    {
        public Forex(String url, String token) : base(url, token)
        {}

        public List<Rate> all()
        {
            return Forex.DeJson(base.Get());
        }

        public static List<Rate> DeJson(JObject json)
        {
            List<Rate> rates = new List<Rate>();

            JArray jsonrates = (JArray)json.GetValue("ForexRates");
            foreach (JObject jsonrate in jsonrates.Children<JObject>())
            {
                rates.Add(Rate.DeJson(jsonrate));
            }

            return rates;
        }
    }
}
