﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeExa02
{
    public class ComponenteCatalogo : ICatalogo
    {
        protected object[] descripcionVehiculo =
        {
            "Berlin 5 puertas", 5000, "Compacto 3 puertas", 4000,
            "Escpace 5 puertas", 8000, "Break 5 puertas", 7000,
            "Coupe 2 puertas", 9000, "utiliatrio 3 puertas", 5000
        };

        public IList<string> BuscaVehiculos(int precioMin, int precioMax)
        {
            int indice, tamaño;
            IList<string> resultado = new List<string>();
            tamaño = descripcionVehiculo.Length / 2;

            for (indice = 0; indice < tamaño; indice++)
            {
                int precio = (int)descripcionVehiculo[2 * indice + 1];
                if (precio >= precioMin && precio <= precioMax)
                {
                    resultado.Add((string)descripcionVehiculo[2 * indice]);
                }
            }
            return resultado;
        }
    }
}
