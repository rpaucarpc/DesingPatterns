using System;

namespace InterpreterExa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Expresion expresionConsulta = null;
            Console.WriteLine("Ingrese su consulta: ");
            string consulta = Console.ReadLine();
            try
            {
                expresionConsulta = Expresion.Analiza(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                expresionConsulta = null;
            }

            if (expresionConsulta != null)
            {
                Console.WriteLine("Ingrese la descripción de un vehículo: ");
                string descripcion = Console.ReadLine();
                if (expresionConsulta.Evalua(descripcion))
                    Console.WriteLine("La descripción responde a la consulta");
                else
                    Console.WriteLine("La descripción no responde a la consulta");
            }
        }
    }
}
