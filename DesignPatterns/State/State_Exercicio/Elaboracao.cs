using System;

namespace POSDesingnPatternsFCV.State.State_Exercicio
{
    internal class Elaboracao : IOrdemServicoState
    {
        public IOrdemServicoState Agendar()
        {
            //define regras
            //..
            //depois retorna o novo status
            return new Agendamento();
        }

        public IOrdemServicoState Executar()
        {
            throw new Exception("Não é possível executar nessa fase.");
        }

        public IOrdemServicoState Finalizar()
        {
            throw new Exception("Não é possível finalizar nessa fase.");
        }

        public IOrdemServicoState Elaborar()
        {
            return this;
        }
    }
}
