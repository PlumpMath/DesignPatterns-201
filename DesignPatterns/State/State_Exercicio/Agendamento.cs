using System;

namespace POSDesingnPatternsFCV.State.State_Exercicio
{
    internal class Agendamento : IOrdemServicoState
    {
        public IOrdemServicoState Elaborar()
        {
            return new Elaboracao();
        }

        public IOrdemServicoState Executar()
        {
            return new Execucao();
        }

        public IOrdemServicoState Finalizar()
        {
            throw new Exception("Não é possível finalizar nessa fase.");
        }

        IOrdemServicoState IOrdemServicoState.Agendar()
        {
            return this;
        }
    }
}