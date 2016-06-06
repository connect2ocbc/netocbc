using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ocbc.Utils;
using Newtonsoft.Json.Linq;

namespace Ocbc
{
    public class OcbcConnect 
    {
        private String url;
        private String token;

        public OcbcConnect(String url, String token)
        {
            this.url = url;
            this.token = token;
        }

        public virtual JObject Get() {
            return this.Get(null);
        }

        public virtual JObject Get(String args)
        {
            String url = this.url;
            if (args != null) {
                url = String.Format("{0}/{1}", url, args);
            }

            return request.Get(url, Headers.Get(this.token));
        }
    }
}