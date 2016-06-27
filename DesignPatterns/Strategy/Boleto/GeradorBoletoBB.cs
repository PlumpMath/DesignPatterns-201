using System;

namespace POSDesingnPatternsFCV.Strategy.Boleto
{
    public class GeradorBoletoBB : IGeradorBoleto
    {
        public void Gerar()
        {
            Console.WriteLine("Boleto BB gerado com sucesso.");
        }
    }
}
