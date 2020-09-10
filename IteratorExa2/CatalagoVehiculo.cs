using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorExa2
{
    public class CatalagoVehiculo : Catalogo<Vehiculo, IteradorVehiculo>
    {
        public CatalagoVehiculo()
        {
            contenido.Add(new Vehiculo("Vehículo economico"));
            contenido.Add(new Vehiculo("pequeño vehiculo economico"));
            contenido.Add(new Vehiculo("Vehículo de gran calidad"));
        }
    }
}
