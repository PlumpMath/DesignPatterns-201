using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesingnPatternsFCV.FactoryMethod
{
    public class Ninja250R : IMoto
    {
        public string ExibirModelo()
        {
            return "Ninja 250R";
        }
    }
}
