using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeExa2
{
    public class DocumentacionEnBlanco : Documentacion
    {
        private static DocumentacionEnBlanco _instance = null;
        private DocumentacionEnBlanco()
        {
            documentos = new List<Documento>();
        }

        public static DocumentacionEnBlanco Instance()
        {
            if (_instance == null)
            {
                _instance = new DocumentacionEnBlanco();
            }
            return _instance;
        }

        public void Incluye(Documento doc)
        {
            documentos.Add(doc);
        }
        public void Excluye(Documento doc)
        {
            documentos.Remove(doc);
        }
    }
}
