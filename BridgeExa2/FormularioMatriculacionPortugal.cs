using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeExa2
{
    public class FormularioMatriculacionPortugal : FormularioMatriculacion
    {
        public FormularioMatriculacionPortugal( IFormularioImpl formularioImpl): base (formularioImpl)
        {

        }
        protected override bool ControlZona(string matricula)
        {
            return matricula.Length == 6;
        }
    }
}
