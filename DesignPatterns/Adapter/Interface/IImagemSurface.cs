namespace POSDesingnPatternsFCV.Adapter.Interface
{
    public interface IImagemSurface
    {
        void CarregarImagem(string arquivo);
        void DesenharImagem(int largura, int altura, int posicaoX, int posicaoY);
    }
}
