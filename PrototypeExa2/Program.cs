using System;

namespace PrototypeExa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************");
            DocumentacionEnBlanco documentacionEnBlanco = DocumentacionEnBlanco.Instance();
            documentacionEnBlanco.Incluye(new OrdenPedido());
            documentacionEnBlanco.Incluye(new CertificadoCesion());
            documentacionEnBlanco.Incluye(new SolicitudMatriculacion());

            //Creacion de documentacion nueva para dos clientes
            DocumentacionCliente documentacionCliente1 = new DocumentacionCliente("Martin");
            DocumentacionCliente documentacionCliente2 = new DocumentacionCliente("Simon");

            documentacionCliente1.Visualiza();
            documentacionCliente2.Imprime();

        }
    }
}
