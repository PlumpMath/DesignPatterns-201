using System;
using System.Collections.Generic;

namespace POSDesingnPatternsFCV.Strategy
{
    public class LocalizacaoEnsaioPlanoManutencao : IEnsaioPlanoManutencao
    {
        public ICollection<string> GetAll()
        {
            Console.WriteLine("Localização ensaio!");
            return new List<string>();
        }
    }
}
