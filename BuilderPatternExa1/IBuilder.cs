using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace BuilderPatternExa1
{
    public interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void InsertWheels();
        void AddHeadLights();
        void EndOperations();
        Product GetVehicle();
    }
}
