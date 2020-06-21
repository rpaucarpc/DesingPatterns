using System;

namespace SingletonPatternEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comercial miComercial = Comercial.Instance;
            miComercial.Nombre = "Comercial Auto";
            miComercial.Direccion = "Lima";
            miComercial.Email = "comercial@gmail.com";

            miComercial.Visualiza();

            Console.WriteLine("*****************");

            Comercial miComercial2 = Comercial.Instance;
            miComercial2.Visualiza();


        }
    }
}
