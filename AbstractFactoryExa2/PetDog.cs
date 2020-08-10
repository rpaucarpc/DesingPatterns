using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExa2
{
    public class PetDog : IDog
    {
        public void Action()
        {
            Console.WriteLine("Pet dogs prefer to stay at home.");
        }

        public void Speak()
        {
            Console.WriteLine("Pet dogs says: Bow-Wow");
        }
    }
}
