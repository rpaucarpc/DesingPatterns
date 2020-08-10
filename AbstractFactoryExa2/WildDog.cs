using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExa2
{
    public class WildDog : IDog
    {
        public void Action()
        {
            Console.WriteLine("Wild Dogs prefer to roam freely in jungles.");
        }

        public void Speak()
        {
            Console.WriteLine("Wild dog says: Bow-wow.");
        }
    }
}
