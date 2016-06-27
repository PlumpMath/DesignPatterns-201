using System;

namespace POSDesingnPatternsFCV.State
{
    public class MarioFire : IMarioState
    {
        public IMarioState LevarDano()
        {
            return new MarioPequeno();
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
            return new MarioBros();
        }
    }
}
