using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorExa2
{
    public abstract class Empresa
    {
        public string Nombre{ get; set; }
        public string Email { get; set; }
        public string Direccion{ get; set; }

        public Empresa(string pNombre, string pEmail, string pdireccion)
        {
            Nombre = pNombre;
            Email = pEmail;
            Direccion = pdireccion;
        }

        public abstract bool AgregaFilial(Empresa filial);
        public abstract void AceptaVisitante(IVisitante visitante);
    }
}
