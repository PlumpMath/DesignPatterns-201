using System.Collections.Generic;

namespace POSDesingnPatternsFCV.Strategy
{
    public interface IEnsaioPlanoManutencao
    {
        ICollection<string> GetAll();
    }
}
