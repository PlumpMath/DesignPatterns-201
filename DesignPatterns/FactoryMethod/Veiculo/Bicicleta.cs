using System;

namespace POSDesingnPatternsFCV.FactoryMethod.Veiculo
{
    public class Bicicleta : IFactory
    {
        public void dirigir()
        {
            Console.WriteLine("Vamos de Bicicleta!");
        }
    }
}
