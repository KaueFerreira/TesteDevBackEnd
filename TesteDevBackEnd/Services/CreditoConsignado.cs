namespace TesteDevBackEnd.Services
{
    public class CreditoConsignado : Credito
    {
        public override decimal CalcularTaxaJuros()
        {
            return ValorCredito * 0.01M * QuantidadeParcelas;
        }
    }
}
