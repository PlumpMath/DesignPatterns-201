using System;

namespace POSDesingnPatternsFCV.Strategy.Boleto
{
    public class GeradorBoletoCaixa : IGeradorBoleto
    {
        public void Gerar()
        {
            Console.WriteLine("Boleto Caixa gerado com sucesso.");
        }
    }
}
