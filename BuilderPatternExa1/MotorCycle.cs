using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternExa1
{
    public class MotorCycle : IBuilder
    {
        private string brandName;
        private Product product;

        public MotorCycle(string brand)
        {
            product = new Product();
            brandName = brand;
        }

        public void StartUpOperations()
        {
        }
        public void BuildBody()
        {
            product.Add("This is a body of a Motorcycle");
        }
        public void InsertWheels()
        {
            product.Add("2 wheels are added");
        }
        public void AddHeadLights()
        {
            product.Add("1 headlights are added");
        }

        public void EndOperations()
        {
            product.Add(String.Format("Motorcycle Model name: {0}", brandName));
        }

        public Product GetVehicle()
        {
            return product;
        }




    }
}
