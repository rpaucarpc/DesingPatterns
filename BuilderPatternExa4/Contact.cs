using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternExa4
{
    public class Contact
    {
        public string Name { get; set; }
        public Phone Phone{ get; set; }
        public Address Address{ get; set; }

        public Contact()
        {

        }

        public Contact( string name, Phone phone, Address address)
        {
            Name = name;
            Phone = phone;
            Address = address;
        }

        public Contact(string name, Phone phone)
        {
            Name = name;
            Phone = phone;
        }

        public override string ToString()
        {
            return "Contact { name=" + Name + ", Phone=" + Phone + " }";
        }

    }
}
