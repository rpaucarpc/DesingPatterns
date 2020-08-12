using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPatternExa5
{
    public abstract class Documentacion
    {
        protected IList<string> contenido = new List<string>();
        public abstract void AgregaDocumento(string documento);
        public abstract void Imprime();
    }
}
