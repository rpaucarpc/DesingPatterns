using System;

namespace MementoExa1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el originador
            Originador auto = new Originador("March", 2019, 250000);
            auto.Mostrar();

            Console.WriteLine("--------------");
            // Creamos el caretaker
            CareTaker ct = new CareTaker();

            //Guardamos el estado
            ct.Memento = auto.CreaMemento();

            // Modificamos el objeto
            auto.Nombre = "Vocho";
            auto.Modelo = 1970;
            auto.Costo = 35000;
            auto.Mostrar();

            Console.WriteLine("--------------");
            //Restauramos el estado anterior
            auto.Restaura(ct.Memento);
            auto.Mostrar();

        }
    }
}
