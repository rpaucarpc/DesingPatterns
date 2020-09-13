using System;

namespace MediatorExa1
{
    class Program
    {
        static void Main(string[] args)
        {
            // creamos el mediador
            Mediador miMediador = new Mediador();

            // creamos los colegas
            ColegaA Ana = new ColegaA("Ana", miMediador);
            ColegaA Luis = new ColegaA("Luis", miMediador);

            ColegaB David = new ColegaB("David", miMediador);

            Ana.Enviar("Saludos a todos");
            Luis.Enviar("Como estan?");
            David.Enviar("Visiten nicosiored");
            Console.WriteLine();

            Console.WriteLine("******** Verificamos censura *********");
            Luis.Enviar("Las palabrotas no me agradan");
            Console.WriteLine();

            miMediador.Bloqueo(Luis.Recibir);
            Ana.Enviar("Vean los playlist");
            Console.WriteLine();

            miMediador.Suscribir(Luis.Recibir);
            David.Enviar("Me gusta programar");
            Console.WriteLine();
        }
    }
}
