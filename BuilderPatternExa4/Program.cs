using System;

namespace BuilderPatternExa4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************");

            EmployeeBuilder builder = new EmployeeBuilder();

            Employee employee = builder
                                .SetName("Rolando Paucar Camargo")
                                .SetGender("Male")
                                .SetAge(24)
                                .SetAddress("Jr. los Rosales", "Acapulco", "Mexico", "10023")
                                .AddContact("Contacto 01",
                                    new Phone("1236548", "025", "ti"),
                                    new Address("direcicon", "Mexico", "Mexico", "10024"))
                                .AddPhones("2598658", "02", "celular")
                                .Build();

            Console.WriteLine(employee);
        }
    }
}
