using System;
using TesteDevBackEnd.Models;

namespace TesteDevBackEnd.Services
{
    public abstract class Credito
    {
        public decimal ValorCredito { get; set; }
        public TipoCredito TipoCredito { get; set; }
        public int QuantidadeParcelas { get; set; }
        public DateTime DataVencimento { get; set; }

        public Credito()
        {

        }

        public Credito(decimal valorCredito, TipoCredito tipoCredito, int quantidadeParcelas, DateTime dataVencimento)
        {
            ValorCredito = valorCredito;
            TipoCredito = tipoCredito;
            QuantidadeParcelas = quantidadeParcelas;
            DataVencimento = dataVencimento;

            if (ValorCredito > 1000000)
            {
                throw new ApplicationException("Valor do crédito solicitado excede o valor máximo permitido.");
            }

            if (QuantidadeParcelas < 5 || quantidadeParcelas > 72)
            {
                throw new ApplicationException("A quantidade mínima de parcelas é 5 e a máxima 72.");
            }

            if (DataVencimento < DateTime.Now.AddDays(15) || DataVencimento > DateTime.Now.AddDays(40))
            {
                throw new ApplicationException("A data do primeiro vencimento deve ser no mínimo 15 dias e no máximo 40 dias à partir da data atual.");
            }
        }

        public ResponseModel VerificarCredito()
        {
            var juros = CalcularTaxaJuros();

            return new ResponseModel()
            {
                StatusCredito = Status.Aprovado,
                ValorTotal = ValorCredito + juros,
                ValorJuros = juros
            };
        }

        public abstract decimal CalcularTaxaJuros();
    }
}
