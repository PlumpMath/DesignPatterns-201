using POSDesingnPatternsFCV.AbstractFactory.Motos;

namespace POSDesingnPatternsFCV.AbstractFactory.Fabricas
{
    public class FabricaMotoYamaha : IFabricaDeMoto
    {
        public IMotoLuxo CriarMotoLuxo()
        {
            return new Yamaha1000cc();            
        }

        public IMotoPopular CriarMotoPopular()
        {
            return new YamahaYBR();
        }
    }
}
