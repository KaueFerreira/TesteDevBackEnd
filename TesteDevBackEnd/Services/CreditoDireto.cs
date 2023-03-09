namespace TesteDevBackEnd.Services
{
    public class CreditoDireto : Credito
    {
        public override decimal CalcularTaxaJuros()
        {
            return ValorCredito * 0.02M * QuantidadeParcelas;
        }
    }
}
