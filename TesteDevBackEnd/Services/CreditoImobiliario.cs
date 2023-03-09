namespace TesteDevBackEnd.Services
{
    public class CreditoImobiliario : Credito
    {
        public override decimal CalcularTaxaJuros()
        {
            return ValorCredito * 0.09M * QuantidadeParcelas;
        }
    }
}
