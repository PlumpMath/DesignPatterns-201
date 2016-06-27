using System;

namespace POSDesingnPatternsFCV.AbstractFactory.Motos
{
    public class YamahaYBR : IMotoPopular
    {
        public void ExibirInforMotoPopular()
        {
            Console.WriteLine("YBR, PAIA!!!");
        }
    }
}
