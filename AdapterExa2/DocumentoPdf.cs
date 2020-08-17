using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterExa2
{
    public class DocumentoPdf : IDocumento
    {
        protected ComponentePdf componentePdf = new ComponentePdf();

        public string Contenido 
        { 
            set
            {
                componentePdf.PdfFijaContenido(value);
            }
        }

        public void Dibuja()
        {
            componentePdf.PdfPreparaVisualizacion();
            componentePdf.PdfRefresca();
            componentePdf.PdfFinalizaVisualizacion();
        }

        public void Imprime()
        {
            componentePdf.PdfEnviaImpresora();
        }
    }
}
