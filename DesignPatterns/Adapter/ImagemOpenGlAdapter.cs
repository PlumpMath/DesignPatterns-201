using POSDesingnPatternsFCV.Adapter.APIImagem;
using POSDesingnPatternsFCV.Adapter.Interface;
using System;

namespace POSDesingnPatternsFCV.Adapter
{
    /// <summary>
    /// Adapta as necessidades da funcionalidade utilizando as bibliotecas de terceiros, classe extendida
    /// Aqui será implementado a funcionalide utilizando a API e o que desejar
    /// </summary>
    public class ImagemOpenGlAdapter : ImagemOpenGl, IImagem
    {
        public void CarregarImagem(string arquivo)
        {            
            throw new NotImplementedException();
        }

        public void DesenharImagem(int posicaoX, int posicaoY)
        {
            throw new NotImplementedException();
        }
    }
}
