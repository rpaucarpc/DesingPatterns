using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightExa2
{
    public class VehiculoSolicitado
    {
        protected IList<OpcionVehiculo> opciones = new List<OpcionVehiculo>();
        protected IList<int> precioDeVentaOpciones = new List<int>();

        public void AgregaOpciones(string nombre, int precioDeVenta, FabricaOpcion fabrica )
        {
            opciones.Add(fabrica.GetOpcion(nombre));
            precioDeVentaOpciones.Add(precioDeVenta);
        }

        public void MuestraOpciones()
        {
            int  tamaño;
            tamaño = opciones.Count;
            for (int i = 0; i < tamaño; i++)
            {
                opciones[i].Visualiza( precioDeVentaOpciones[i]);
                Console.WriteLine();
            }
        }
    }
}
