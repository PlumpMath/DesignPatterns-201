using System;

namespace POSDesingnPatternsFCV.AbstractFactory.Motos
{
    public class HondaBiz : IMotoPopular
    {
        public void ExibirInforMotoPopular()
        {
            Console.WriteLine("Honda Biz com tudo ela combina, só não combina com posto de gasolina!");
        }
    }
}
