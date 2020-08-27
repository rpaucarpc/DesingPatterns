using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeExa02
{
    public class ComponenteGestionDocumento : IGestionDocumento
    {
        public string Documento(int indice)
        {
            return "Documento número " + indice;
        }
    }
}
