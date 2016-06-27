using System;
using System.Collections.Generic;

namespace POSDesingnPatternsFCV.Strategy
{
    public class FamiliaEnsaioPlanoManutencao : IEnsaioPlanoManutencao
    {
        public ICollection<string> GetAll()
        {
            Console.WriteLine("Família ensaio!");
            return new List<string>();
        }
    }
}
