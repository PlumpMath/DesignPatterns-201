namespace POSDesingnPatternsFCV.FactoryMethod.Veiculo
{
    public abstract class VeiculoFactory
    {
        public enum Veiculo
        {
            Scooter = 1,
            Bicicleta = 2
        }

        public abstract IFactory GetVeiculo(Veiculo veiculo);
    }
}
