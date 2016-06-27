namespace POSDesingnPatternsFCV.AbstractFactory
{
    public interface IFabricaDeMoto
    {
        IMotoLuxo CriarMotoLuxo();
        IMotoPopular CriarMotoPopular();
    }
}
