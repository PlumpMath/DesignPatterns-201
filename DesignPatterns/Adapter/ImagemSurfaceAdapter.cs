using POSDesingnPatternsFCV.Adapter.APIImagem;
using POSDesingnPatternsFCV.Adapter.Interface;
using System;

namespace POSDesingnPatternsFCV.Adapter
{
    public class ImagemSurfaceAdapter : ImageSurfaceSdl, IImagemSurface
    {
        public void CarregarImagem(string arquivo)
        {
            throw new NotImplementedException();
        }

        public void DesenharImagem(int largura, int altura, int posicaoX, int posicaoY)
        {
            throw new NotImplementedException();
        }
    }
}
