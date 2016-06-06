using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Ocbc.Utils
{
    class request
    {
        static public JObject Get(String url, Dictionary<String, String> headers)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            SetHeaders(headers, request);

            Stream stream = request.GetResponse().GetResponseStream();
            StreamReader reader = new StreamReader(stream);
        
            String jsonresponse = "";
            string line = "";
        
            while (line != null)
            {
                line = reader.ReadLine();
                if (line != null)
                    jsonresponse += line;
            }
        
            JObject json = JObject.Parse(jsonresponse);
            return json;
        }

        private static void SetHeaders(Dictionary<String, String> headers, HttpWebRequest request)
        {
            if (headers != null)
            {
                foreach (var item in headers)
                {
                    if (item.Key == "Accept")
                        request.Accept = item.Value;
                    else
                        request.Headers.Add((String)item.Key, (String)item.Value);
                }
            }
        }
    }
}