using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPatternEx1
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private int numberOfInstances = 0;

        private Singleton() 
        {
            Console.WriteLine("Instantiating inside the private constructor.");
            numberOfInstances++;
            Console.WriteLine("Number of instances = {0}", numberOfInstances);
        }

        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("We already have an instance now. Use it");
                return instance;
            }
        }
    }
}
