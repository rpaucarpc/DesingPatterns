using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightExa2
{
    public class FabricaOpcion
    {
        protected IDictionary<string, OpcionVehiculo> opciones = new Dictionary<string, OpcionVehiculo>();

        public OpcionVehiculo GetOpcion(string nombre)
        {
            OpcionVehiculo resultado;

            if (opciones.ContainsKey(nombre))
            {
                resultado = opciones[nombre];
            }
            else
            {
                resultado = new OpcionVehiculo(nombre);
                opciones.Add(nombre, resultado);
            }
            return resultado;
        }
    }
}
