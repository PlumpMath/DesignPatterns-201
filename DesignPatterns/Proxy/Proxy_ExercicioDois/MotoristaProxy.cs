namespace POSDesingnPatternsFCV.Proxy.Proxy_ExercicioDois
{
    public class MotoristaProxy : IMotorista
    {
        Motorista motorista;
        private const int IDADE = 18;

        public MotoristaProxy(int idade)
        {
            motorista = new Motorista(idade);
        }

        public void Dirigir()
        {
            //Protege a execução do método Dirigir, esse é o padrão proxy
            if (motorista.idade >= IDADE)
            {
                motorista.Dirigir();
            }
        }
    }
}
