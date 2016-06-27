namespace POSDesingnPatternsFCV.FactoryMethod.Restaurante
{
    public class Churrasqueiro : Cozinheiro
    {
        public override Comida criaComida()
        {
            return new Carne();
        }
    }
}
