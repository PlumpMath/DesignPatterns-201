﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesingnPatternsFCV.State
{
    public class MarioGrande : IMarioState
    {
        public IMarioState LevarDano()
        {
            throw new NotImplementedException();
        }

        public IMarioState PegarCogumelo()
        {
            throw new NotImplementedException();
        }

        public IMarioState PegarFlor()
        {
            return new MarioFire();
        }

        public IMarioState PegarPena()
        {
            return new MarioBros();
        }
    }
}
