namespace POSDesingnPatternsFCV.Strategy.Boleto
{
    public class GeradorBoletoContext : IGeradorBoleto
    {
        private readonly IGeradorBoleto gerador;

        public GeradorBoletoContext(IGeradorBoleto gerador)
        {
            this.gerador = gerador;
        }

        public void Gerar()
        {
            gerador.Gerar();
        }
    }
}
