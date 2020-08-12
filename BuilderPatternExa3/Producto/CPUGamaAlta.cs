using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternExa3
{
    public class CPUGamaAlta : IBuilder
    {
        Producto producto = new Producto();

        public void AgregarDisco()
        {
            producto.ColocarDisco(new DiscoA());
        }

        public void AgregarMemoria()
        {
            producto.ColocarMemoria(new MemoriaA());
        }

        public void AgregarProcesador()
        {
            producto.ColocarProcesador(new ProcesadorA());
        }

        public Producto ObtenerProducto()
        {
            return producto;
        }
    }
}
