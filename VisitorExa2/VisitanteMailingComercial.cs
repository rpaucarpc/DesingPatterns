using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorExa2
{
    public class VisitanteMailingComercial : IVisitante
    {
        public void Visita(EmpresaSinFilial empresa)
        {
            Console.WriteLine("Envia un email a " + empresa.Nombre + " direccion: " + empresa.Email + " Propuesta comercial para su empresa ");
        }

        public void Visita(EmpresaMadre empresa)
        {
            Console.WriteLine("Envia un email a " + empresa.Nombre + " direccion: " + empresa.Email + " Propuesta comercial para su grupo ");
            Console.WriteLine("Impresion de un correo electronico para " + empresa.Nombre + " direccion: " + empresa.Direccion + " Propuesta comercial para su grupo ");
        }
    }
}
