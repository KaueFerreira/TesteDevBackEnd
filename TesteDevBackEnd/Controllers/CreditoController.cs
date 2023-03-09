using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteDevBackEnd.Models;
using TesteDevBackEnd.Services;

namespace TesteDevBackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreditoController : ControllerBase
    {

        private readonly ICreditoService _creditoService;

        public CreditoController(ICreditoService creditoService)
        {
            _creditoService = creditoService;        
        }


        [HttpPost]
        public ActionResult<ResponseModel> AnalisarCredito([FromBody] RequestModel request)
        {
            try
            {
                var result = _creditoService.AnalisarCredito(request);
                return Ok(result);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
