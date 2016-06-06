using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ocbc.Utils
{
    class Headers
    {
        static public Dictionary<String, String> Get(String token)
        {
            Dictionary<String, String> headers = new Dictionary<string,string>();
            headers.Add("Authorization", "Bearer " + token);
            headers.Add("Accept", "application/json");
            return headers;
        }
    }
}