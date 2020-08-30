using System;

namespace FlyweightExa2
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaOpcion fabrica = new FabricaOpcion();
            VehiculoSolicitado vehiculo = new VehiculoSolicitado();

            vehiculo.AgregaOpciones("air bag", 80, fabrica);
            vehiculo.AgregaOpciones("direccion asistida", 90, fabrica);
            vehiculo.AgregaOpciones("Elevalunas eléctricos", 85, fabrica);
            vehiculo.MuestraOpciones();
        }
    }
}
