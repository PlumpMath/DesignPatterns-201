using System;

namespace POSDesingnPatternsFCV.AbstractFactory.Motos
{
    public class Yamaha1000cc : IMotoLuxo
    {
        public void ExibirInfoLuxo()
        {
            Console.WriteLine("Yamaha 1000 cc, nervosa!");
        }
    }
}
