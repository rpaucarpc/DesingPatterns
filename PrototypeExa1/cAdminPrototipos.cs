using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeExa1
{
    public class cAdminPrototipos
    {
        private Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();

        public cAdminPrototipos()
        {
            //Adicionamos los objetos prototipo con los valores iniciales que nos interesan
            cPersona persona = new cPersona("Ciudadano", 18);
            prototipos.Add("Persona", persona);

            CValores valores = new CValores(1);
            prototipos.Add("Valores", valores);
        }

        public void AdicionaPrototipo(string pLlave, IPrototipo pPrototipo)
        {
            prototipos.Add(pLlave, pPrototipo);
        }

        public object ObtenPrototipo(string pLLave)
        {
            return prototipos[pLLave].Clonar();
        }
    }
}
