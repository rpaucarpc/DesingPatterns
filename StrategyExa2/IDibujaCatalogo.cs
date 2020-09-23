using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExa2
{
    public interface IDibujaCatalogo
    {
        void Dibuja(IList<VistaVehiculo> contenido);
    }
}
