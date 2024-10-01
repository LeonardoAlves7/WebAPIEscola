namespace WebAPI.DTOs
{
    public class EnviarMensagemParaTurmaDto
    {
        public string Conteudo { get; set; }
        public int RemetenteId { get; set; }
        public string RemetenteTipo { get; set; }
        public int? TurmaId { get; set; }
    }
}
