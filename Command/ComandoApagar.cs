using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class ComandoApagar : IComando
    {
        Automovil auto;
        public ComandoApagar( Automovil pAuto)
        {
            auto = pAuto;
        }
        public void Ejecutar()
        {
            auto.Apagar();
        }
    }
}
