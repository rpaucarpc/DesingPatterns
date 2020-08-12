using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternExa1
{
    public class Car : IBuilder
    {
        private string brandName;
        private Product product;
        public Car(string brand)
        {
            product = new Product();
            brandName = brand;
        }
        public void StartUpOperations()
        {
            product.Add(String.Format("Car Model name: {0}", brandName ) );
        }

        public void BuildBody()
        {
            product.Add( "This is a body of a Car" );
        }
        public void InsertWheels()
        {
            product.Add("4 wheels are added");
        }

        public void AddHeadLights()
        {
            product.Add("2 headlights are added");
        }

        public void EndOperations()
        {

        }

        public Product GetVehicle()
        {
            return product;
        }

    }
}
