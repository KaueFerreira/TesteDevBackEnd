using System;

namespace TesteDevBackEnd.Domain
{
    public class CreditoConsignado : Credito
    {
        public CreditoConsignado(decimal valorCredito, TipoCredito tipoCredito, int quantidadeParcelas, DateTime dataVencimento) : base(valorCredito, tipoCredito, quantidadeParcelas, dataVencimento)
        {
        }

        public override decimal CalcularTaxaJuros()
        {
            return ValorCredito * 0.01M * QuantidadeParcelas;
        }
    }
}
