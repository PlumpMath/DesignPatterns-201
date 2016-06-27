using System;

namespace POSDesingnPatternsFCV.Proxy
{
    public class ImagemReal : IImagem
    {
        private string nomeArquivo;

        public ImagemReal(string nomeArquivo)
        {
            this.nomeArquivo = nomeArquivo;

            CarregarImagemDisco();
        }

        public void MostrarImagem()
        {
            Console.WriteLine($"Mostrando {nomeArquivo}");
        }

        private void CarregarImagemDisco()
        {
            Console.WriteLine($"Carregando {nomeArquivo}");
        }
    }
}
