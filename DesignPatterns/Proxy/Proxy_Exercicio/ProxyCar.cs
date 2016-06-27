using System;

namespace POSDesingnPatternsFCV.Proxy.Proxy_Exercicio
{
    public class ProxyCar : ICar
    {
        private readonly int minAge;
        private Driver driver;

        public ProxyCar(Driver driver)
        {
            minAge = 18;
            this.driver = driver;
        }

        public void DriveCar()
        {
            if (minAge > driver.Age)
                Console.WriteLine("Condutor não possui idade para dirigir");
            else
            {
                var car = new Car();
                car.DriveCar();
            }
        }
    }
}
