using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternExa1
{
    public class Product
    {
        private List<string> parts;
        public Product()
        {
            parts = new List<string>();
        }

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Product completed as below:");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
