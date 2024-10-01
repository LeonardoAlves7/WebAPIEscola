public class MensagemDto
{
    public int MensagemId { get; set; }
    public string Conteudo { get; set; }
    public DateTime DataEnvio { get; set; }
    public int RemetenteId { get; set; }
    public string RemetenteTipo { get; set; }
    public int? DestinatarioId { get; set; }
    public string DestinatarioTipo { get; set; }
}
