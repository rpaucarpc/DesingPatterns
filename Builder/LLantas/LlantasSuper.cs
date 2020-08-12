using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class LlantasSuper : ILlantas
    {
        public string Informacion()
        {
            return "Llantas de 18 pulgadas, rines de aluminio";
        }
    }
}
