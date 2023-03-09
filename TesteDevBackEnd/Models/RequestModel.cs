using System;
using TesteDevBackEnd.Services;

namespace TesteDevBackEnd.Models
{
    public class RequestModel
    {
        public decimal ValorCredito { get; set; }
        public TipoCredito TipoCredito { get; set; }
        public int QuantidadeParcelas { get; set; }
        public DateTime DataVencimento { get; set; }
    }
}
