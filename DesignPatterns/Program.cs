using System;
using POSDesingnPatternsFCV.FactoryMethod;
using POSDesingnPatternsFCV.PolimorfismoComInterface;
using POSDesingnPatternsFCV.Singleton;
using POSDesingnPatternsFCV.Facade;
using POSDesingnPatternsFCV.Facade.Facade_Exercicio;
using POSDesingnPatternsFCV.Proxy;
using POSDesingnPatternsFCV.Proxy.Proxy_Exercicio;
using POSDesingnPatternsFCV.Proxy.Proxy_ExercicioDois;
using POSDesingnPatternsFCV.State.State_Exercicio;
using POSDesingnPatternsFCV.Strategy;
using POSDesingnPatternsFCV.Strategy.Boleto;

namespace POSDesingnPatternsFCV
{
    class Program
    {
        static void Main(string[] args)
        {
            #region singleton
            var conexao1 = Conexao.GetInstance();
            var conexao2 = Conexao.GetInstance();

            Console.WriteLine(conexao1.Equals(conexao2) ? "Conexões iguais" : "Conexões diferentes");
            #endregion

            #region polimorfismo com interface
            var matrix = new Matrix();
            var crepusculo = new Crepusculo();

            var cinema = new Cinema();
            cinema.EntrarNoCinema(matrix);
            cinema.EntrarNoCinema(crepusculo);
            #endregion

            #region Factory method

            #region exemplo com enum

            //exemplo do factory com mau uso de enum, 
            //pois a cada moto nova será incrementado o enum, ferindo o princípio de aberto/fechado

            var fabricaMoto = new FabricaMoto();
            var cg = fabricaMoto.FabricarMoto(EMotos.CG150);
            var f800 = fabricaMoto.FabricarMoto(EMotos.F800);

            Console.WriteLine(cg.ExibirModelo());
            Console.WriteLine(f800.ExibirModelo());

            #endregion

            #region exemplo sem uso de enum

            Fabrica[] fabricas = new Fabrica[4];
            fabricas[0] = new FabricaCG150();
            fabricas[1] = new FabricaF800();
            fabricas[2] = new FabricaNinja250R();
            fabricas[3] = new FabricaYBR();

            foreach (var fabricador in fabricas)
            {
                var moto = fabricador.FabricarMoto();
                Console.WriteLine("Criado {0}", moto.ExibirModelo());
            }

            #endregion

            #endregion

            #region Facade
            var game = new SistemasFacade();
            game.InicializarSubSistemas();
            game.ReproduzirAudio("AC/DC-Back_in_Black.mp3");

            var venda = new VendaFacade();
            venda.FecharPedido();
            #endregion

            #region Proxy
            IImagem imagem = new ImagemProxy("c:/teste.png");
            imagem.MostrarImagem();

            var Car = new ProxyCar(new Driver(26));
            Car.DriveCar();

            var motorista = new MotoristaProxy(18);
            motorista.Dirigir();
            #endregion

            #region State
            try
            {
                IOrdemServicoState os = new Elaboracao();
                var agendamento = os.Agendar();
                var execucao = agendamento.Executar();
                var finalizacao = execucao.Finalizar();
                finalizacao.Finalizar();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region strategy

            var localizacaoEnsaioPM = new EnsaioPlanoManutencaoContext(new LocalizacaoEnsaioPlanoManutencao()).GetEnsaios();
            var equipmentoEnsaioPM = new EnsaioPlanoManutencaoContext(new EquipamentoEnsaioPlanoManutencao()).GetEnsaios();
            var familiaEnsaioPM = new EnsaioPlanoManutencaoContext(new FamiliaEnsaioPlanoManutencao()).GetEnsaios();

            new GeradorBoletoContext(new GeradorBoletoBB()).Gerar();
            new GeradorBoletoContext(new GeradorBoletoBradesco()).Gerar();
            new GeradorBoletoContext(new GeradorBoletoItau()).Gerar();
            new GeradorBoletoContext(new GeradorBoletoCaixa()).Gerar();

            #endregion
        }
    }
}
