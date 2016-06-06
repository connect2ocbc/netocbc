using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Ocbc
{
    class Rate : OcbcObject
    {
        private static String BANK_BUYING_RATE_TT = "bankBuyingRateTT";
        private static String BANK_SELLING_RATE = "bankSellingRate";
        private static String FROM_CURRENCY = "fromCurrency";
        private static String TO_CURRENCY = "toCurrency";
        private static String UNIT = "unit";

        private double bankBuyingRateTT;
        private double bankSellingRate;
        private String fromCurrency;
        private String toCurrency;
        private int unit;

        public Rate(double bankBuyingRateTT, double bankSellingRate, String fromCurrency, String toCurrency, int unit) 
        {
            this.bankBuyingRateTT = bankBuyingRateTT;
            this.bankSellingRate = bankSellingRate;
            this.fromCurrency = fromCurrency;
            this.toCurrency = toCurrency;
            this.unit = unit;
        }

        public double GetBankBuyingRateRTT() { return bankBuyingRateTT; }

        public double GetBankSellingRate() { return bankSellingRate; }

        public String GetFromCurrency() { return fromCurrency; }

        public String GetToCurrency() { return toCurrency; }

        public int GetUnit() { return unit; }

        public static Rate DeJson(JObject json)
        {
            double bankBuyingRateTT = (double)json.GetValue(BANK_BUYING_RATE_TT);
            double bankSellingRate = (double)json.GetValue(BANK_SELLING_RATE);
            String fromCurrency = (String)json.GetValue(FROM_CURRENCY);
            String toCurrency = (String)json.GetValue(TO_CURRENCY);
            int unit = (int)json.GetValue(UNIT);
            return new Rate(bankBuyingRateTT, bankSellingRate, fromCurrency, toCurrency, unit);
        }

        public String ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("{");
            str.Append(BANK_BUYING_RATE_TT);
            str.Append(":");
            str.Append(this.bankBuyingRateTT);
            str.Append(", ");
            str.Append(BANK_SELLING_RATE);
            str.Append(":");
            str.Append(this.bankSellingRate);
            str.Append(", ");
            str.Append(FROM_CURRENCY);
            str.Append(":");
            str.Append(this.fromCurrency);
            str.Append(", ");
            str.Append(TO_CURRENCY);
            str.Append(":");
            str.Append(this.toCurrency);
            str.Append(", ");
            str.Append(UNIT);
            str.Append(":");
            str.Append(this.unit);
            str.Append("}");
            return str.ToString();
        }
    }
}
