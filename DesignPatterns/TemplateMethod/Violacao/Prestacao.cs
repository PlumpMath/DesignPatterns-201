namespace POSDesingnPatternsFCV.TemplateMethod.Violacao
{
    /// <summary>
    /// Este é um template para prestação
    /// </summary>
    public abstract class Prestacao
    {
        protected decimal ValorPrincipal;
        protected decimal ValorDoSeguro;
        protected decimal ValorTaxaAdministrativa;

        public decimal Calcular(decimal valorTotal, int numeroDeParcelas)
        {
            CalcularValorPrincipal(valorTotal, numeroDeParcelas);
            CalcularValorTaxaAdministrativa();
            CalcularValorSeguro();

            return CalcularValorTotal();
        }

        protected abstract void CalcularValorTaxaAdministrativa();
        protected abstract void CalcularValorSeguro();

        protected virtual decimal CalcularValorTotal()
        {
            return ValorPrincipal + ValorTaxaAdministrativa + ValorDoSeguro;
        }

        protected virtual void CalcularValorPrincipal(decimal valorTotal, int numeroDeParcelas)
        {
            ValorPrincipal = valorTotal / numeroDeParcelas;
        }
    }
}
