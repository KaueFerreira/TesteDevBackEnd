using System;

namespace TesteDevBackEnd.Domain
{
    public class CreditoImobiliario : Credito
    {
        public CreditoImobiliario(decimal valorCredito, TipoCredito tipoCredito, int quantidadeParcelas, DateTime dataVencimento) : base(valorCredito, tipoCredito, quantidadeParcelas, dataVencimento)
        {
        }

        public override decimal CalcularTaxaJuros()
        {
            return ValorCredito * 0.09M * QuantidadeParcelas;
        }
    }
}
