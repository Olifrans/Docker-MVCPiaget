namespace Docker_MVCPiaget.Models
{
    public class Aluno
    {
        public  Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public DateTime Idade { get; set; }     
    }
}
