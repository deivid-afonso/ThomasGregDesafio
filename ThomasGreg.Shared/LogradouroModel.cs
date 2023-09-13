namespace APIThomasGreg.Models
{
    public class LogradouroModel
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public int ClienteId { get; set; }
        public ClienteModel Cliente { get; set; }
    }
}
