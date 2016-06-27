namespace POSDesingnPatternsFCV.FactoryMethod.Restaurante
{
    public abstract class Cozinheiro
    {
        public void cozinhar() { }

        public abstract Comida criaComida();
    }
}
