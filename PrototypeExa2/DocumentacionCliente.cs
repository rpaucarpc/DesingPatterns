using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeExa2
{
    public class DocumentacionCliente : Documentacion
    {
        public DocumentacionCliente(string informacion)
        {
            documentos = new List<Documento>();
            DocumentacionEnBlanco documentacionEnBlanco = DocumentacionEnBlanco.Instance();
            IList<Documento> documentosEnBlanco = documentacionEnBlanco.documentos;
            foreach (Documento documento in documentosEnBlanco)
            {
                Documento copiaDocumento = documento.Duplica();
                copiaDocumento.Rellena(informacion);
                documentos.Add(copiaDocumento);
            }
        }

        public void Visualiza()
        {
            foreach (Documento documento  in documentos)
            {
                documento.Visualiza();
            }
        }

        public void Imprime()
        {
            foreach (Documento documento in documentos)
            {
                documento.Imprime();
            }
        }
    }
}
