using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternExa4
{
    public class Phone
    {
        public string PhoneNumber{ get; set; }
        public string Ext{ get; set; }
        public string PhoneType{ get; set; }

        public Phone()
        {

        }

        public Phone( string phoneNumber, string ext, string phoneType)
        {
            PhoneNumber = phoneNumber;
            Ext = ext;
            PhoneType = phoneType;
        }

        public override string ToString()
        {
            return "Phone { phoneNumber=" + PhoneNumber + ", Ext=" + Ext + ", PhoneType=" + PhoneType + " }";
        }
    }
}
