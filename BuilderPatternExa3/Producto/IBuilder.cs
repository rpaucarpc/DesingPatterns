using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternExa3
{
    public interface IBuilder
    {
        void AgregarProcesador();
        void AgregarMemoria();
        void AgregarDisco();

        Producto ObtenerProducto();
    }
}
