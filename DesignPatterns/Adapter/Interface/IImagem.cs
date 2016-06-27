namespace POSDesingnPatternsFCV.Adapter.Interface
{
    public interface IImagem
    {
        void CarregarImagem(string arquivo);
        void DesenharImagem(int posicaoX, int posicaoY);
    }
}
