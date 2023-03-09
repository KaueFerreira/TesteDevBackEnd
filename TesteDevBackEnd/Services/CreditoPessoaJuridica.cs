using System;

namespace TesteDevBackEnd.Services
{
    public class CreditoPessoaJuridica : Credito
    {
        public CreditoPessoaJuridica()
        {
            if (ValorCredito < 15000)
            {
                throw new ApplicationException("Valor mínimo de crédito Para Pessoa Jurídica é de R$15.000,00");
            }
        }

        public override decimal CalcularTaxaJuros()
        {
            return ValorCredito * 0.05M * QuantidadeParcelas;
        }
    }
}
