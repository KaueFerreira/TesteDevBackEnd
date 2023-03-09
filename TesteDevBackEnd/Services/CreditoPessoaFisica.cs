namespace TesteDevBackEnd.Services
{
    public class CreditoPessoaFisica : Credito
    {
        public override decimal CalcularTaxaJuros()
        {
            return ValorCredito * 0.03M * QuantidadeParcelas;
        }
    }
}
