namespace POSDesingnPatternsFCV.FactoryMethod
{
    public class FabricaYBR : Fabrica
    {
        public override IMoto FabricarMoto()
        {
            return new YBR();
        }
    }
}
