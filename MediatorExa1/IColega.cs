using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExa1
{
    public interface IColega
    {
        void Recibir(string emisor, string mensaje);
        void Enviar(string mensaje);
    }
}
