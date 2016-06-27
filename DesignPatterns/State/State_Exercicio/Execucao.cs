using System;

namespace POSDesingnPatternsFCV.State.State_Exercicio
{
    internal class Execucao : IOrdemServicoState
    {
        public IOrdemServicoState Agendar()
        {
            return new Agendamento();
        }

        public IOrdemServicoState Elaborar()
        {
            throw new Exception("Não é possível elaborar nessa fase.");
        }

        public IOrdemServicoState Finalizar()
        {
            return new Finalizacao();
        }

        IOrdemServicoState IOrdemServicoState.Executar()
        {
            return this;
        }
    }
}