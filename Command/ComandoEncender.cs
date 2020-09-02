using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class ComandoEncender : IComando
    {
        Automovil auto;

        public ComandoEncender(Automovil pAuto)
        {
            auto = pAuto;
        }
        public void Ejecutar()
        {
            auto.Encender();
        }
    }
}
