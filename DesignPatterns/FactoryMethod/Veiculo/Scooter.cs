using System;

namespace POSDesingnPatternsFCV.FactoryMethod.Veiculo
{
    public class Scooter : IFactory
    {
        public void dirigir()
        {
            Console.WriteLine("Vamos de Scooter!");
        }
    }
}
