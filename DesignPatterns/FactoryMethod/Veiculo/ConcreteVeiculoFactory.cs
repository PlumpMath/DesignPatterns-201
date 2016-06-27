namespace POSDesingnPatternsFCV.FactoryMethod.Veiculo
{
    public class ConcreteVeiculoFactory : VeiculoFactory
    {
        public override IFactory GetVeiculo(Veiculo veiculo)
        {
            switch (veiculo)
            {
                case Veiculo.Scooter:
                    return new Scooter();
                case Veiculo.Bicicleta:
                    return new Bicicleta();
                default:
                    return null;
            }
        }
    }
}
