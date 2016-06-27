using System;

namespace POSDesingnPatternsFCV.Strategy.Boleto
{
    public class GeradorBoletoItau : IGeradorBoleto
    {
        public void Gerar()
        {
            Console.WriteLine("Boleto Itau gerado com sucesso.");
        }   
    }
}
