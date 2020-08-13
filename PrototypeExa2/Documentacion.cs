using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeExa2
{
    public abstract class Documentacion
    {
        public IList<Documento> documentos { get; protected set; }
    }
}
