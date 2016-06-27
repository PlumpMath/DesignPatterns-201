using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesingnPatternsFCV.PolimorfismoComInterface
{
    public class Crepusculo : IBilhete
    {
        public bool validar()
        {
            return false;
        }
    }
}
