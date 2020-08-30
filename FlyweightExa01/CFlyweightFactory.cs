using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightExa01
{
    public class CFlyweightFactory
    {
        private List<IFlyweight> flyweights = new List<IFlyweight>();
        public int Conteo { get; set; }

        public int Adiciona(string pNombre)
        {
            //Verificamos si ya existe
            bool existe = false;

            foreach (IFlyweight  item in flyweights)
            {
                if (item.ObtenerNombre() == pNombre)
                {
                    existe = true;
                }
            }

            if (existe)
            {
                Console.WriteLine("El objeto ya existe, no se ha adicionado");
                return -1;
            }
            else
            {
                CReceta miReceta = new CReceta();
                miReceta.ColocaNombre(pNombre);
                flyweights.Add(miReceta);
                Conteo = flyweights.Count;
                return Conteo - 1;
            }
        }

        public IFlyweight this[int index]
        {
            get { return flyweights[index]; }
        }
    }
}
