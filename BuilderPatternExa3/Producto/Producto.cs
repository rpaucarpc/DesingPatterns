using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternExa3
{
    public class Producto
    {
        IProcesador procesador;
        IMemoria memoria;
        IDisco disco;
        public void ColocarProcesador(IProcesador pProcesador)
        {
            procesador = pProcesador;
            Console.WriteLine("Se coloco el procesador: {0}", pProcesador.Caracteristica() );
        }

        public void ColocarMemoria( IMemoria pMemoria)
        {
            memoria = pMemoria;
            Console.WriteLine("Se coloco la memoria: {0}", pMemoria.Caracteristica());
        }

        public void ColocarDisco( IDisco pDisco)
        {
            disco = pDisco;
            Console.WriteLine("Se coloco el disco: {0}", pDisco.Caracteristica());
        }

        public void Mostrar()
        {
            Console.WriteLine("Producto con caracterisiticas:");
            Console.WriteLine("CPU: {0}", procesador.Caracteristica());
            Console.WriteLine("Memoria: {0}", memoria.Caracteristica());
            Console.WriteLine("Disco: {0}", disco.Caracteristica());
        }
    }
}
