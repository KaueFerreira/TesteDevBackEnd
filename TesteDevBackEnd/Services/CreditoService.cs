using System;
using TesteDevBackEnd.Domain;
using TesteDevBackEnd.Models;

namespace TesteDevBackEnd.Services
{
    public class CreditoService : ICreditoService
    {
        public ResponseModel AnalisarCredito(RequestModel request)
        {
            try
            {
                var builder = new CreditoBuilder()
                   .RegisterBuilder(TipoCredito.Direto, () => new CreditoDireto(request.ValorCredito, request.TipoCredito, request.QuantidadeParcelas, request.DataVencimento))
                   .RegisterBuilder(TipoCredito.Consignado, () => new CreditoConsignado(request.ValorCredito, request.TipoCredito, request.QuantidadeParcelas, request.DataVencimento))
                   .RegisterBuilder(TipoCredito.PessoaJuridica, () => new CreditoPessoaJuridica(request.ValorCredito, request.TipoCredito, request.QuantidadeParcelas, request.DataVencimento))
                   .RegisterBuilder(TipoCredito.PessoaFisica, () => new CreditoPessoaFisica(request.ValorCredito, request.TipoCredito, request.QuantidadeParcelas, request.DataVencimento))
                   .RegisterBuilder(TipoCredito.Imobiliario, () => new CreditoImobiliario(request.ValorCredito, request.TipoCredito, request.QuantidadeParcelas, request.DataVencimento));

                var credito = builder.Build(request.TipoCredito);

                return credito.VerificarCredito();

            }
            catch (ApplicationException ex)
            {
                return new ResponseModel() {StatusCredito = Status.Recusado.ToString(), MensagemErro = ex.Message };
            }
        }
    }
}
