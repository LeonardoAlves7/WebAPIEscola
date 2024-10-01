using WebAPI.Models;

namespace WebAPI.Models
{
    public class Mensagem
    {
        public int MensagemId { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataEnvio { get; set; }

        public int RemetenteId { get; set; }
        public string RemetenteTipo { get; set; }

        public int? TurmaId { get; set; }
        public Turma Turma { get; set; }

        public int? DestinatarioId { get; set; }
        public string DestinatarioTipo { get; set; }
    }
}
