using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeExa2
{
    public class FormularioMatriculacionEspaña : FormularioMatriculacion
    {
        public FormularioMatriculacionEspaña( IFormularioImpl formularioImpl) : base(formularioImpl)
        {

        }
        protected override bool ControlZona(string matricula)
        {
            return matricula.Length == 7;
        }
    }
}
