using System;

namespace DecoratorExa01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos el componente central con tipo IComponente
            //para permitir la decoracion
            IComponente miAuto = new CAuto("2018", "4 puertas", 20000);

            Console.WriteLine(miAuto);

            // si necesitamos usar un metodo propio de CAuto
            // necesitamos hacer uso de un type cast
            ((CAuto)miAuto).Puertas(true);

            Console.WriteLine("------------");

            //Decoramos el auto con un sistema de sonido
            miAuto = new CSistemaSonido(miAuto);

            //Comprobamos la adicion de las caracteristicas
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("------------");

            //Decoramos con nitrogeno
            miAuto = new CNitrogeno(miAuto);
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            ((CNitrogeno)miAuto).UsaN();

            Console.WriteLine("------------");

            //Decoramos Suspension
            miAuto = new CSuspension(miAuto);
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("------------");

            // Ojo, No podemos usar metodos especificos una vez que decoramos
            // sobre ella

            //((CNitrogeno)miAuto).UsaN();
            //((CAuto)miAuto).Puertas(false);

        }
    }
}
