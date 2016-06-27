using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesingnPatternsFCV.State
{
    public class MarioPequeno : IMarioState
    {
        public IMarioState LevarDano()
        {
            throw new NotImplementedException();
        }

        public IMarioState PegarCogumelo()
        {
            return new MarioGrande();
        }

        public IMarioState PegarFlor()
        {
            throw new NotImplementedException();
        }

        public IMarioState PegarPena()
        {
            throw new NotImplementedException();
        }
    }
}
