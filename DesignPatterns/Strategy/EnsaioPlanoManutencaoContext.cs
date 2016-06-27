using System.Collections.Generic;

namespace POSDesingnPatternsFCV.Strategy
{
    public class EnsaioPlanoManutencaoContext
    {
        private readonly IEnsaioPlanoManutencao ensaioPlanoManutencao;

        public EnsaioPlanoManutencaoContext(IEnsaioPlanoManutencao ensaioPlanoManutencao)
        {
            this.ensaioPlanoManutencao = ensaioPlanoManutencao;
        }

        public ICollection<string> GetEnsaios()
        {
            return ensaioPlanoManutencao.GetAll();
        }
    }
}
