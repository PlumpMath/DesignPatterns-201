using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesingnPatternsFCV.FactoryMethod
{
    public class F800 : IMoto
    {
        public string ExibirModelo()
        {
            return "F800";
        }
    }
}
