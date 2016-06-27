using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesingnPatternsFCV.Adapter.APIImagem
{
    public class ImageSurfaceSdl
    {
        public void CarregarSurface(string arquivo)
        {
            Console.WriteLine("Imagem " + arquivo + " carregada.");
        }

        public void DesenharSurface(int largura, int altura, int posicaoX, int posicaoY)
        {
            Console.WriteLine("SDL_Surface_desenhada");
        }
    }
}
