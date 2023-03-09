namespace TesteDevBackEnd.Models
{
    public class ResponseModel
    {
        public Status StatusCredito { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorJuros { get; set; }

        public ResponseModel()
        {

        }
    }

    public enum Status
    {
        Aprovado,
        Recusado
    }
}
