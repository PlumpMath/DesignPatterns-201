using System;

namespace POSDesingnPatternsFCV.Strategy.Boleto
{
    class GeradorBoletoBradesco : IGeradorBoleto
    {
        public void Gerar()
        {
            Console.WriteLine("Boleto Bradesco gerado com sucesso.");
        }    
    }
}
