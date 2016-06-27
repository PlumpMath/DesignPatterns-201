namespace POSDesingnPatternsFCV.TemplateMethod.Violacao
{
    public class PrestacaoContratoEspecial : Prestacao
    {
        protected override void CalcularValorSeguro()
        {
            ValorDoSeguro = (ValorPrincipal * 0.01m) + 1.5m;
        }

        protected override void CalcularValorTaxaAdministrativa()
        {
            ValorTaxaAdministrativa = 0.015m / ValorPrincipal + 1;
        }
    }
}
