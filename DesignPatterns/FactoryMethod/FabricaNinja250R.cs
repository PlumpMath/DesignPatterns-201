namespace POSDesingnPatternsFCV.FactoryMethod
{
    public class FabricaNinja250R : Fabrica
    {
        public override IMoto FabricarMoto()
        {
            return new Ninja250R();
        }
    }
}
