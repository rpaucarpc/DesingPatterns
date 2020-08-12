using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternExa4
{
    public class EmployeeBuilder : IBuilder
    {
        private string name;
        private int age;
        private string gender;
        private Address address;
        private readonly List<Phone> phones = new List<Phone>();
        private readonly List<Contact> contacts = new List<Contact>();

        public EmployeeBuilder()
        {

        }

        public EmployeeBuilder SetName(string pName)
        {
            name = pName;
            return this;
        }

        public EmployeeBuilder SetAge(int pAge)
        {
            age = pAge;
            return this;
        }
        public EmployeeBuilder SetGender(string pGender)
        {
            gender = pGender;
            return this;
        }

        public EmployeeBuilder SetAddress(string addre, string city, string country, string cp)
        {
            address = new Address( addre, city, country, cp);
            return this;
        }

        public EmployeeBuilder AddPhones(string phoneNumber, string ext, string phoneType)
        {
            phones.Add( new Phone(phoneNumber, ext, phoneType) );
            return this;
        }

        public EmployeeBuilder AddContact(string name, Phone phone, Address address)
        {
            contacts.Add(new Contact(name, phone, address) );
            return this;
        }
        public Employee Build()
        {
            return new Employee(name, age, gender, address, phones, contacts);
        }
    }
}
