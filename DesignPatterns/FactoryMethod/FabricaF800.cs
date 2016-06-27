namespace POSDesingnPatternsFCV.FactoryMethod
{
    public class FabricaF800 : Fabrica
    {
        public override IMoto FabricarMoto()
        {
            return new F800();
        }
    }
}
