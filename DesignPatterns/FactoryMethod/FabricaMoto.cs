using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesingnPatternsFCV.FactoryMethod
{
    public class FabricaMoto
    {
        public IMoto FabricarMoto(EMotos motos)
        {
            switch (motos)
            {
                case EMotos.CG150:
                    return new CG150();
                case EMotos.F800:
                    return new F800();
                case EMotos.NINJA250R:
                    return new Ninja250R();
                case EMotos.YBR:
                    return new YBR();
                default:
                    return null;
            }
        }
    }
}
