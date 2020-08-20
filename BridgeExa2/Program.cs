using System;

namespace BridgeExa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************");

            FormularioMatriculacion formulario = new FormularioMatriculacionPortugal( new FormHtmlImpl());
            formulario.Visualiza();
            if (formulario.AdministraZona())
            {
                formulario.GeneraDocumento();
            }

            Console.WriteLine("--------------------------");

            formulario = new FormularioMatriculacionEspaña(new FormAppletImpl());
            formulario.Visualiza();
            if (formulario.AdministraZona())
            {
                formulario.GeneraDocumento();
            }


        }
    }
}
