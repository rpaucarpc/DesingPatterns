using System;

namespace PrototypeExa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************");
            //Creamos el administrador
            cAdminPrototipos admin = new cAdminPrototipos();

            //Obtenemos dos instancias
            cPersona uno = (cPersona)admin.ObtenPrototipo("Persona");
            cPersona dos = (cPersona)admin.ObtenPrototipo("Persona");

            //Verificamos que tengan los valores del prototipo original
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("----------------------");


            //Modificamos el estado
            uno.Nombre = "Ana";
            dos.Nombre = "Lia";

            //Verificamos que cada quien tenga su estado
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("----------------------");

            //Creamos una instancia
            CAuto auto = new CAuto("Nissan", 250000);

            //Lo colocamos como prototipo
            admin.AdicionaPrototipo("Auto", auto);

            //Obtenenmos un objeto de ese prototipo
            CAuto auto2 = (CAuto)admin.ObtenPrototipo("Auto");

            // Cambiamos el estado
            auto2.Modelo = "Honda";

            //Verificamos que cada uno tenga su estado
            Console.WriteLine(auto);
            Console.WriteLine(auto2);
            Console.WriteLine("----------------------");

            //Obtenemos una instancia del costoso
            CValores val = (CValores)admin.ObtenPrototipo("Valores");
            Console.WriteLine(val);
        }
    }
}
