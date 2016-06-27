using System;

namespace POSDesingnPatternsFCV.AbstractFactory.Motos
{
    public class Honda1000cc : IMotoLuxo
    {
        public void ExibirInfoLuxo()
        {
            Console.WriteLine("Honda 1000 cc, motorzão!");
        }
    }
}
