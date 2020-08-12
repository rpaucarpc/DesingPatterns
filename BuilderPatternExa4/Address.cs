using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternExa4
{
    public class Address
    {
        public string Addre { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Cp  { get; set; }

        public Address()
        {

        }

        public Address( string address, string city, string country, string cp)
        {
            Addre = address;
            City = city;
            Country = country;
            Cp = cp;
        }

        public override string ToString()
        {
            return "Address { address= " + Addre + ", City=" + City + ", Country=" + Country + ", Cp=" + Cp + " }";
        }
    }
}
