using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesingnPatternsFCV.Adapter.APIImagem
{
    public class ImagemOpenGl
    {
        public void GlCarregarImagem(string arquivo)
        {
            Console.WriteLine("Imagem " + arquivo + " carregada.");
        }

        public void GlDesenharImagem(int posicaoX, int posicaoY)
        {
            Console.WriteLine("OpenGl Image desenhada.");
        }
    }
}
