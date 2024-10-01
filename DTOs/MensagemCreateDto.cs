public class MensagemCreateDto
{
    public string Conteudo { get; set; }
    public int RemetenteId { get; set; }
    public string RemetenteTipo { get; set; }
    public int? DestinatarioId { get; set; } 
    public string DestinatarioTipo { get; set; }
}
