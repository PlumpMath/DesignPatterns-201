using System;
using System.Collections.Generic;

namespace POSDesingnPatternsFCV.Strategy
{
    public class EquipamentoEnsaioPlanoManutencao : IEnsaioPlanoManutencao
    {
        public ICollection<string> GetAll()
        {
            Console.WriteLine("Equipamento ensaio!");
            return new List<string>();
        }
    }
}
