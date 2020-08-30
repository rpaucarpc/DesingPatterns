using System;
using System.Collections.Generic;

namespace FlyweightExa01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            List<int> Americana = new List<int>();
            List<int> Italiana = new List<int>();
            List<int> Mexicana = new List<int>();

            List<int> Carnes = new List<int>();
            List<int> Sopas = new List<int>();
            List<int> Ensaladas = new List<int>();

            List<int> Rapida = new List<int>();

            CFlyweightFactory flywf = new CFlyweightFactory();

            i = flywf.Adiciona("Hamburguesa");
            Americana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.Adiciona("Wisconsin cheese");
            Americana.Add(i);
            Ensaladas.Add(i);

            i = flywf.Adiciona("Minestrone");
            Italiana.Add(i);
            Sopas.Add(i);

            i = flywf.Adiciona("Antipasto");
            Italiana.Add(i);
            Ensaladas.Add(i);

            i = flywf.Adiciona("Tacos al pastor");
            Mexicana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.Adiciona("Coditos");
            Mexicana.Add(i);
            Sopas.Add(i);

            i = flywf.Adiciona("Nopales");
            Italiana.Add(i);
            Rapida.Add(i);

            i = flywf.Adiciona("Pizza");
            Italiana.Add(i);
            Rapida.Add(i);

            // Mostramos y llevamos a cabo proceso en la comida rapida
            foreach (int n in Rapida )
            {
                CReceta receta = (CReceta)flywf[n];
                receta.CalcularCosto();
                receta.Mostrar();
            }
            Console.WriteLine("-----------------");

            // Mostramos y llevamos a cabo proceso en la comida Americana
            foreach (int n in Americana)
            {
                CReceta receta = (CReceta)flywf[n];
                //receta.CalcularCosto();
                receta.Mostrar();
            }
            Console.WriteLine("-----------------");

            //Intentamos adicionar un ya existente
            i = flywf.Adiciona("Pizza");
            Console.WriteLine("-----------------");


            for (int m = 0; m < flywf.Conteo; m++)
            {
                CReceta receta = (CReceta)flywf[m];
                receta.Mostrar();
            }
        }
    }
}
