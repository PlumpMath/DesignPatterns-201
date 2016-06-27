namespace POSDesingnPatternsFCV.FactoryMethod.Restaurante
{
    public class Pizzaiolo : Cozinheiro
    {
        public override Comida criaComida()
        {
            return new Pizza();
        }
    }
}
