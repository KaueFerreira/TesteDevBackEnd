using System;
using TesteDevBackEnd.Models;

namespace TesteDevBackEnd.Services
{
    public class CreditoService : ICreditoService
    {
        public ResponseModel AnalisarCredito(RequestModel request)
        {
            try
            {
                //builder passando request

                return new ResponseModel();

            }
            catch (ApplicationException ex)
            {

                throw new ApplicationException(ex.Message);
            }
        }
    }
}
