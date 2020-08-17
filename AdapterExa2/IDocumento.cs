using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterExa2
{
    public interface IDocumento
    {
        string Contenido { set; }
        void Dibuja();
        void Imprime();
    }
}
