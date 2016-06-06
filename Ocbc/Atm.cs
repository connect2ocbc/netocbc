using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Ocbc
{

    public class Atm : OcbcObject 
    {
        private static String ADRRESS = "address";
        private static String LANDMARK = "landmark";
        private static String LATITUDE = "latitude";
        private static String LONGITUDE = "longitude";
        private static String NOTE = "note";
        private static String NOTE_DETAILS = "noteDetails";
        private static String POSTAL_CODE = "postalCode";

        private String address;
        private String landmark;
        private double latitude;
        private double longitude;
        private String note;
        private String noteDetails;
        private String postalCode;

        public Atm(String address, String landmark, double latitude, double longitude, String note, String noteDetails, String postalCode) 
        {
            this.address = address;
            this.landmark = landmark;
            this.latitude = latitude;
            this.longitude = longitude;
            this.note = note;
            this.noteDetails = noteDetails;
            this.postalCode = postalCode;
        }

        public String getPostalCode() 
        {
            return postalCode;
        }

        public double getLongitude() 
        {
            return longitude;
        }

        public double getLatitude() 
        {
            return latitude;
        }

        public String getLandmark() 
        {
            return landmark;
        }

        public String getNote() 
        { 
            return note; 
        }

        public String getNoteDetails() 
        { 
            return noteDetails; 
        }

        public String getAddress() 
        {
            return address;
        }

        public static Atm DeJson(JObject json) 
        {
            String address = (String)json.GetValue(ADRRESS);
            String landmark = (String)json.GetValue(LANDMARK);
            double latitude = (double)json.GetValue(LATITUDE);
            double longitude = (double)json.GetValue(LONGITUDE);
            String note = (String)json.GetValue(NOTE);
            String noteDetails = (String)json.GetValue(NOTE_DETAILS);
            String postalCode = (String)json.GetValue(POSTAL_CODE);
            return new Atm(address, landmark, latitude, longitude, note, noteDetails, postalCode);
        }

        public String ToString() 
        {
            StringBuilder str = new StringBuilder();
            str.Append("{");
            str.Append(ADRRESS);
            str.Append(":");
            str.Append(address);
            str.Append(", ");
            str.Append(LANDMARK);
            str.Append(":");
            str.Append(landmark);
            str.Append(", ");
            str.Append(LATITUDE);
            str.Append(":");
            str.Append(latitude);
            str.Append(", ");
            str.Append(LONGITUDE);
            str.Append(":");
            str.Append(longitude);
            str.Append(", ");
            str.Append(NOTE);
            str.Append(":");
            str.Append(note);
            str.Append(", ");
            str.Append(NOTE_DETAILS);
            str.Append(":");
            str.Append(noteDetails);
            str.Append(", ");
            str.Append(POSTAL_CODE);
            str.Append(":");
            str.Append(postalCode);
            str.Append("}");
            return str.ToString();
        }
    }
}