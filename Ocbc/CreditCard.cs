using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Ocbc
{
    public class CreditCard : OcbcObject 
    {
        private static String IMGAGE_URL = "imageURL";
        private static String KEYWORDS = "keywords";
        private static String NAME = "name";
        private static String PRODUCT_URL = "productURL";
        private static String TAG_LINE = "tagLine";

        private String imageURL;
        private String keywords;
        private String name;
        private String productURL;
        private String tagLine;

        CreditCard(String imageURL, String keywords, String name, String productURL, String tagLine) 
        {
            this.imageURL = imageURL;
            this.keywords = keywords;
            this.name = name;
            this.productURL = productURL;
            this.tagLine = tagLine;
        }

        public String getImageURL() 
        {
            return imageURL;
        }

        public String getKeywords() 
        {
            return keywords;
        }

        public String getName() 
        {
            return name;
        }

        public String getProductURL() 
        {
            return productURL;
        }

        public String getTagLine() 
        {
            return tagLine;
        }

        public static CreditCard DeJson(JObject json) 
        {
            String imageURL = (String)json.GetValue(IMGAGE_URL);
            String keywords = (String)json.GetValue(KEYWORDS);
            String name = (String)json.GetValue(NAME);
            String productURL = (String)json.GetValue(PRODUCT_URL);
            String tagLine = (String)json.GetValue(TAG_LINE);
            return new CreditCard(imageURL, keywords, name, productURL, tagLine);
        }

        public String ToString() 
        {
            StringBuilder str = new StringBuilder();
            str.Append("{");
            str.Append(IMGAGE_URL);
            str.Append(":");
            str.Append(this.imageURL);
            str.Append(", ");
            str.Append(KEYWORDS);
            str.Append(":");
            str.Append(this.keywords);
            str.Append(", ");
            str.Append(NAME);
            str.Append(":");
            str.Append(this.name);
            str.Append(", ");
            str.Append(PRODUCT_URL);
            str.Append(":");
            str.Append(this.productURL);
            str.Append(", ");
            str.Append(TAG_LINE);
            str.Append(":");
            str.Append(this.tagLine);
            str.Append("}");
            return str.ToString();
        }
    }
}