using System;

namespace TesteDevBackEnd.Domain
{
    public class CreditoDireto : Credito
    {
        public CreditoDireto(decimal valorCredito, TipoCredito tipoCredito, int quantidadeParcelas, DateTime dataVencimento) : base(valorCredito, tipoCredito, quantidadeParcelas, dataVencimento)
        {
        }

        public override decimal CalcularTaxaJuros()
        {
            return ValorCredito * 0.02M * QuantidadeParcelas;
        }
    }
}
