using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExa2
{
    public class VistaCatalogo
    {
        protected IList<VistaVehiculo> contenido = new List<VistaVehiculo>();
        protected IDibujaCatalogo dibujo;

        public VistaCatalogo(IDibujaCatalogo pDibujo)
        {
            contenido.Add(new VistaVehiculo("vehiculo economico"));
            contenido.Add(new VistaVehiculo("vehiculo especial"));
            contenido.Add(new VistaVehiculo("vehiculo radio"));
            contenido.Add(new VistaVehiculo("vehiculo confortable"));
            contenido.Add(new VistaVehiculo("vehiculo deportivo"));
            this.dibujo = pDibujo;
        }

        public void Dibuja()
        {
            dibujo.Dibuja(contenido);
        }
    }
}
