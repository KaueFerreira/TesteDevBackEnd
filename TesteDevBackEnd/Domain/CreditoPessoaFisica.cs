using System;

namespace TesteDevBackEnd.Domain
{
    public class CreditoPessoaFisica : Credito
    {
        public CreditoPessoaFisica(decimal valorCredito, TipoCredito tipoCredito, int quantidadeParcelas, DateTime dataVencimento) : base(valorCredito, tipoCredito, quantidadeParcelas, dataVencimento)
        {
        }

        public override decimal CalcularTaxaJuros()
        {
            return ValorCredito * 0.03M * QuantidadeParcelas;
        }
    }
}
