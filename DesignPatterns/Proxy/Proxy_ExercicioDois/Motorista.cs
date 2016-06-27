using System;

namespace POSDesingnPatternsFCV.Proxy.Proxy_ExercicioDois
{
    public class Motorista : IMotorista
    {
        public int idade { get; private set; }

        public Motorista(int idade)
        {
            this.idade = idade;
        }

        public void Dirigir()
        {
            Console.WriteLine("Estou dirigindo...");
        }
    }
}
