using System;

namespace POSDesingnPatternsFCV.Proxy.Proxy_Exercicio
{
    public class Car : ICar
    {
        public void DriveCar()
        {
            Console.WriteLine("Dirigindo Carro!");
        }
    }
}
