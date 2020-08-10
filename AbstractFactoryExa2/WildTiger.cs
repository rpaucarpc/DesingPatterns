using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExa2
{
    public class WildTiger : ITiger
    {
        public void Action()
        {
            Console.WriteLine("Wild tigers prefer hunting in jungles.");
        }

        public void Speak()
        {
            Console.WriteLine("Wild tiger says; Haklum.");
        }
    }
}
