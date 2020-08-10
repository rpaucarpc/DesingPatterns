using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExa2
{
    public class PetTiger : ITiger
    {
        public void Action()
        {
            Console.WriteLine("Pet tigers prefer play in an animal circus");
        }

        public void Speak()
        {
            Console.WriteLine("Pet tiger says; Haklum.");
        }
    }
}
