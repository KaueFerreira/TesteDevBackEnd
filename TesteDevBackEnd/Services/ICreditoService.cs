using TesteDevBackEnd.Models;

namespace TesteDevBackEnd.Services
{
    public interface ICreditoService
    {
        ResponseModel AnalisarCredito(RequestModel request);
    }
}