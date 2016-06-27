namespace POSDesingnPatternsFCV.FactoryMethod
{
    public class FabricaCG150 : Fabrica
    {
        public override IMoto FabricarMoto()
        {
            return new CG150();
        }
    }
}
