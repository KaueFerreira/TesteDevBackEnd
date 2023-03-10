namespace TesteDevBackEnd.Models
{
    public class ResponseModel
    {
        public string StatusCredito { get; set; }
        public string ValorTotal { get; set; }
        public string ValorJuros { get; set; }
        public string MensagemErro { get; set; }

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
