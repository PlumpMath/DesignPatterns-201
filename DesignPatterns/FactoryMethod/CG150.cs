using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesingnPatternsFCV.FactoryMethod
{
    public class CG150 : IMoto
    {
        public string ExibirModelo()
        {
            return "CG 150";
        }
    }
}
