using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Ocbc
{
    class CCSuggest : OcbcConnect
    {
        public CCSuggest(String url, String token)
            : base(url, token)
        { }

        public List<CreditCard> suggest(String keyword)
        {
            return CCSuggest.DeJson(base.Get(keyword));
        }

        public static List<CreditCard> DeJson(JObject json)
        {
            List<CreditCard> creditcards = new List<CreditCard>();

            JArray jsonccs = (JArray)json.GetValue("CCSuggest");
            foreach (JObject jsoncc in jsonccs.Children<JObject>())
            {
                creditcards.Add(CreditCard.DeJson(jsoncc));
            }

            return creditcards;
        }
    }
}
