namespace POSDesingnPatternsFCV.Facade.Facade_Exercicio
{
    public class VendaFacade
    {
        private readonly Entrega entrega;
        private readonly OrdemPedido ordemPedido;
        private readonly Pagamento pagamento;

        public VendaFacade()
        {
            entrega = new Entrega();
            ordemPedido = new OrdemPedido();
            pagamento = new Pagamento();
        }

        public void FecharPedido()
        {
            GerarOrdemPedido();
            Pagar();
            Entregar();
        }

        public void GerarOrdemPedido()
        {
            ordemPedido.Gerar();
        }

        public void Pagar()
        {
            pagamento.Pagar();
        }

        public void Entregar()
        {
            entrega.Entregar();
        }        
    }
}
