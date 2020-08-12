using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternExa3
{
    public class Director
    {
        public void Construye(IBuilder builder)
        {
            builder.AgregarProcesador();
            builder.AgregarMemoria();
            builder.AgregarDisco();
        }
    }
}
