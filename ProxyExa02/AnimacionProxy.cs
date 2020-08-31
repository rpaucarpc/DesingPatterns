using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyExa02
{
    public class AnimacionProxy : IAnimacion
    {
        protected Video video = null;
        protected string foto = "mostrar la foto";
        public void Clic()
        {
            if (video == null)
            {
                video = new Video();
                video.Carga();
            }
            video.Reproduce();
        }

        public void Dibuja()
        {
            if (video != null)
            {
                video.Dibuja();
            }
            else
            {
                Dibuja(foto);
            }
        }

        public void Dibuja(string foto)
        {
            Console.WriteLine(foto);
        }
    }
}
