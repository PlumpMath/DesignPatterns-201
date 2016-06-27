namespace POSDesingnPatternsFCV.State
{
    public interface IMarioState
    {
        IMarioState PegarCogumelo();
        IMarioState PegarFlor();
        IMarioState PegarPena();
        IMarioState LevarDano();       
    }
}
