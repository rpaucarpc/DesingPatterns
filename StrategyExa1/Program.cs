using System;

namespace StrategyExa1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            double x = 0;
            double y = 0;
            double r = 0;
            string opcion = "";

            // Nuestra variable de referencia al algoritmo
            // Instanciamos con u default para permitir compilacion correcta

            IOperacion miOperacion = new CSuma();

            while(opcion != "5")
            {
                Console.WriteLine("1-Suma, 2-Resta, 3-Multi, 4-Div, 5-Salir");
                opcion = Console.ReadLine();

                if (opcion == "5")
                    break;

                Console.WriteLine("Dame el valor de a");
                dato = Console.ReadLine();
                x = Convert.ToDouble(dato);

                Console.WriteLine("Dame el valor de b");
                dato = Console.ReadLine();
                y = Convert.ToDouble(dato);

                // Aqui seleccionamos el algoritmo de acuerdo a la necesidad

                if (opcion == "1")
                    miOperacion = new CSuma();

                if (opcion == "2")
                    miOperacion = new CResta();

                if (opcion == "3")
                    miOperacion = new CMulti();

                if (opcion == "4")
                    miOperacion = new CDiv();

                r = miOperacion.Operacion(x, y);

                Console.WriteLine("El resultado es {0}", r);

            }
        }
    }
}
