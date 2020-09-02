using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class ComandoApagarAlarma : IComando
    {
        Automovil auto;
        public ComandoApagarAlarma(Automovil pAuto)
        {
            auto = pAuto;
        }
        public void Ejecutar()
        {
            auto.QuitarAlarma();
        }
    }
}
