namespace POSDesingnPatternsFCV.TemplateMethod.Violacao
{
    public class PrestacaoContratoPadrao : Prestacao
    {
        protected override void CalcularValorSeguro()
        {
            ValorDoSeguro = ValorPrincipal * 0.01m;
        }

        protected override void CalcularValorTaxaAdministrativa()
        {
            ValorTaxaAdministrativa = 0.015m / ValorPrincipal;
        }
    }
}
