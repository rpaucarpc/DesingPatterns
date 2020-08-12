using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternExa4
{
    public class Employee
    {
        public string Name{ get; set; }
        public int Age{ get; set; }
        public string Gender{ get; set; }

        public Address Address { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Contact> Contacts{ get; set; }

        public Employee()
        {

        }

        public Employee( string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public Employee(string name, int age, string gender, Address address, List<Phone> phones, List<Contact> contacts)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Address = address;
            Phones = phones;
            Contacts = contacts;
        }

        public override string ToString()
        {
            return "Employee{ name=" + Name +
                    "\n Age=" + Age +
                    "\n Gender= " + Gender +
                    "\n Address=" + Address +
                    "\n Phones=" + string.Join("", Phones) +
                    "\n Contacts=" + string.Join("", Contacts);
        }
    }
}
