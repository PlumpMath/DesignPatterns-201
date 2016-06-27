using System;

namespace POSDesingnPatternsFCV.State.State_Exercicio
{
    internal class Finalizacao : IOrdemServicoState
    {
        public IOrdemServicoState Agendar()
        {
            throw new Exception("Não é possível agendar nessa fase.");
        }

        public IOrdemServicoState Elaborar()
        {
            throw new Exception("Não é possível elaborar nessa fase.");
        }

        public IOrdemServicoState Executar()
        {
            return new Execucao();
        }

        public IOrdemServicoState Finalizar()
        {
            Console.WriteLine("Finalizada Ordem de Serviço.");
            return this;
        }
    }
}