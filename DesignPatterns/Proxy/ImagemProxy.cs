using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesingnPatternsFCV.Proxy
{
    public class ImagemProxy : IImagem
    {
        private readonly string nomeArquivo;
        private IImagem imagem;

        public ImagemProxy(string nomeArquivo)
        {
            this.nomeArquivo = nomeArquivo;
        }

        public void MostrarImagem()
        {
            //Protege a execução do método MostrarImagem, essa é a finalidade, proteger!
            if (imagem == null)
            {
                imagem = new ImagemReal(nomeArquivo);
                imagem.MostrarImagem();
            }
        }
    }
}
