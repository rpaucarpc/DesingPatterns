﻿using System;

namespace CommandExa02
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo1 = new Vehiculo("A01", 1, 1000.0);
            Vehiculo vehiculo2 = new Vehiculo("A11", 6, 2000.0);
            Vehiculo vehiculo3 = new Vehiculo("Z03", 2, 3000.0);

            Catalogo catalogo = new Catalogo();

            catalogo.Agrega(vehiculo1);
            catalogo.Agrega(vehiculo2);
            catalogo.Agrega(vehiculo3);

            Console.WriteLine("Visualizacion inicial del catálogo");
            catalogo.Visualiza();
            Console.WriteLine();

            SolicitudRebaja solicitudRebaja = new SolicitudRebaja(10, 5, 0.1);
            catalogo.EjecutaSolicitudRebaja(solicitudRebaja);
            Console.WriteLine("Visualizacion del catalogo tras ejecutar la primera solicitud");
            catalogo.Visualiza();
            Console.WriteLine();

            SolicitudRebaja solicitudRebaja2 = new SolicitudRebaja(10, 5, 0.5);
            catalogo.EjecutaSolicitudRebaja(solicitudRebaja2);
            Console.WriteLine("Visualizacion del catalogo tras ejecutar la segunda solicitud");
            catalogo.Visualiza();
            Console.WriteLine();

            catalogo.AnulaSolicitudRebaja(1);
            Console.WriteLine("Visualizacion del catalogo tras anular la primera solicitud");
            catalogo.Visualiza();
            Console.WriteLine();

            catalogo.RestableceSolicitudRebaja(1);
            Console.WriteLine("Visualizacion del catalogo tras restablecer la primera solicitud");
            catalogo.Visualiza();
            Console.WriteLine();
        }
    }
}
