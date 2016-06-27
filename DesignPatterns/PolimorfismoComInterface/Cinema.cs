using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesingnPatternsFCV.PolimorfismoComInterface
{
    public class Cinema
    {
        public void EntrarNoCinema(IBilhete Bilhete)
        {
            if (Bilhete.validar())
                Console.WriteLine("Entrou no cinema!");
            else
                Console.WriteLine("Não entrou no cinema!");
        }
    }
}
