using POSDesingnPatternsFCV.AbstractFactory.Motos;

namespace POSDesingnPatternsFCV.AbstractFactory.Fabricas
{
    public class FabricaMotoHonda : IFabricaDeMoto
    {
        public IMotoLuxo CriarMotoLuxo()
        {
            return new Honda1000cc();
        }

        public IMotoPopular CriarMotoPopular()
        {
            return new HondaBiz();
        }
    }
}
