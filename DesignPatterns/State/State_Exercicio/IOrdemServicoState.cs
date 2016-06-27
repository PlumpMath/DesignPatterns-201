namespace POSDesingnPatternsFCV.State.State_Exercicio
{
    public interface IOrdemServicoState
    {
        IOrdemServicoState Elaborar();
        IOrdemServicoState Agendar();
        IOrdemServicoState Executar();
        IOrdemServicoState Finalizar();
    }
}
